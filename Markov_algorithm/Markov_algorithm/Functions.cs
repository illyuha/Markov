using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Markov_algorithm
{
    public partial class MarkovForm : Form
    {
        private int commandsCount, totalRowsCount;
        private string[] messages = { "left string", "arrow", "right string" };
        private const int stepsLimit = 1000;
        private const string ordinaryArrow = "→";
        private const string finishArrow = "↦";
        private bool debugModeOn = false;
        private int debugCurrentCommand = 0;
        private bool onSubstitute = false;

        private void runProgram()
        {
            programGrid.CurrentCell = null;
            if (compileProgram() == 0)
            {
                StopButton.Enabled = true;
                outputRichTextBox.Text = inputTextBox.Text;
                freezeFields();
                int steps = 0;
                while (steps < stepsLimit)
                {
                    String curString = outputRichTextBox.Text;
                    bool finish = true;
                    for (int command = 0; command < commandsCount; command++ )
                    {
                        object lv = programGrid[1, command].Value;
                        String left = (lv == null ? "" : lv.ToString());
                        int ind = curString.IndexOf(left);
                        if (ind >= 0)
                        {
                            DataGridViewComboBoxCell arrow = (DataGridViewComboBoxCell)programGrid[2, command];
                            String s = arrow.Value.ToString();
                            object rv = programGrid[3, command].Value;
                            String right = (rv == null ? "" : rv.ToString());
                            curString = curString.Remove(ind, left.Length);
                            curString = curString.Insert(ind, right);
                            if (s == ordinaryArrow)
                                finish = false;
                            break;
                        }
                    }
                    outputRichTextBox.Text = curString;
                    if (finish) break;
                    ++steps;
                }
                if (steps == stepsLimit)
                {
                    MessageBox.Show("Commands limit reached (possibly endless program");
                    outputRichTextBox.Text = "";
                }
                unfreezeFields();
                StopButton.Enabled = false;
            }
        }

        private int compileProgram()
        {
            int wasBlanc = -1;
            int fail = -1;
            for (int i = 0; i < programGrid.Rows.Count; i++)
            {
                bool blanc = isBlancRow(i);
                int full = isFullRow(i);
                if (!blanc && full != 0)
                    fail = full;
                else if (blanc)
                    wasBlanc = i + 1;
                else if (full == 0 && wasBlanc >= 0)
                    fail = 0;
                else
                    commandsCount = i + 1;
                if (fail >= 0)
                {
                    String message;
                    if (fail == 0)
                        message = "Blanc row: " + wasBlanc;
                    else
                        message = "Missing " + messages[fail - 1] + " in row " + (i + 1);
                    MessageBox.Show(message, "Compilation failed", MessageBoxButtons.OK);
                    return 1;
                }
            }
            return 0;
        }

        private bool isBlancRow(int index)
        {
            if (index >= programGrid.Rows.Count)
                return true;
            for (int i = 1; i < columnsCount; i++)
                if (programGrid[i,index].Value != null)
                    return false;
            return true;
        }

        private int isFullRow(int index)
        {
            if (index >= programGrid.Rows.Count)
                return -1;
            if (programGrid[2,index].Value == null)
                return 2;
            return 0;
        }

        private void freezeFields() { freeze(true); }
        private void unfreezeFields() { freeze(false); }

        private void freeze(bool state)
        {
            statementTextBox.ReadOnly = state;
            inputTextBox.ReadOnly = state;
            // The following field should be readonly
            // outputTextBox.ReadOnly = state;
            programGrid.ReadOnly = state;
        }

        private void calculateRowsCount()
        {
            totalRowsCount = 0;
            for (int i = 0; i < programGrid.Rows.Count; i++)
                if (!isBlancRow(i))
                    totalRowsCount = i + 1;  
        }

        private int arrowIndex(int rowIndex)
        {
            DataGridViewComboBoxCell arrow = (DataGridViewComboBoxCell)programGrid[2, rowIndex];
            if (arrow.Value == null)
                return 0;
            else
            {
                String s = arrow.Value.ToString();
                if (s == ordinaryArrow)
                    return 1;
                else
                    return 2;
            }
        }
       
        private void debugProgram()
        {
            if (!debugModeOn)
            {
                if (compileProgram() == 0)
                {
                    debugModeOn = true;
                    outputRichTextBox.Text = inputTextBox.Text;
                    runButton.Enabled = false;
                    StopButton.Enabled = true;
                    freezeFields();
                }
            }
            else
            {
                if (debugCurrentCommand + 1 == programGrid.Rows.Count)
                    stopProgram();
                else
                {
                    if (debugCurrentCommand > 0)
                        programGrid.Rows[debugCurrentCommand - 1].DefaultCellStyle.BackColor = Color.White;
                    programGrid.Rows[debugCurrentCommand].DefaultCellStyle.BackColor = Color.Yellow;
                    String curString = outputRichTextBox.Text;
                    object lv = programGrid[1, debugCurrentCommand].Value;
                    String left = (lv == null ? "" : lv.ToString());
                    int ind = curString.IndexOf(left);
                    if (ind >= 0)
                    {
                        if (!onSubstitute)
                        {
                            onSubstitute = true;
                            outputRichTextBox.SelectionStart = ind;
                            outputRichTextBox.SelectionLength = left.Length;
                            outputRichTextBox.SelectionColor = Color.Yellow;
                            programGrid.Rows[debugCurrentCommand].DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else
                        {
                            outputRichTextBox.SelectionColor = Color.Black;
                            DataGridViewComboBoxCell arrow = (DataGridViewComboBoxCell)programGrid[2, debugCurrentCommand];
                            String s = arrow.Value.ToString();
                            object rv = programGrid[3, debugCurrentCommand].Value;
                            String right = (rv == null ? "" : rv.ToString());
                            curString = curString.Remove(ind, left.Length);
                            curString = curString.Insert(ind, right);
                            programGrid.Rows[debugCurrentCommand].DefaultCellStyle.BackColor = Color.White;
                            debugCurrentCommand = 0;
                            onSubstitute = false;
                            outputRichTextBox.Text = curString;
                            if (s == finishArrow)
                                stopProgram();
                        }
                    }
                    else
                        ++debugCurrentCommand;
                }
            }
        }

        private void stopProgram()
        {
            debugModeOn = false;
            debugCurrentCommand = 0;
            unfreezeFields();
            runButton.Enabled = true;
            StopButton.Enabled = false;
            for (int i = 0; i < programGrid.Rows.Count; ++i)
                programGrid.Rows[i].DefaultCellStyle.BackColor = Color.White;
            outputRichTextBox.SelectionColor = Color.Black;
        }

        private void writeToFile(StreamWriter ofs)
        {
            calculateRowsCount();
            ofs.WriteLine(totalRowsCount);
            for (int i = 0; i < totalRowsCount; i++)
            {
                ofs.Write(programGrid[1, i].Value + " ");
                ofs.Write(arrowIndex(i) + " ");
                ofs.Write(programGrid[3, i].Value + "\r\n");
            }
            ofs.WriteLine(statementTextBox.Text);
        }
        
        private void saveFile()
        {
            StreamWriter ofs = new StreamWriter(currentFileName);//(saveDialog.OpenFile());
            try
            {
                writeToFile(ofs);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ofs.Close();
                setGridModified(false);
            }
        }

        private void saveFileAs()
        {
            //if (compileProgram() == 0)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Markov algorithm programs (*.nam)|*.nam";
                saveDialog.RestoreDirectory = true;
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter ofs = new StreamWriter(saveDialog.OpenFile());
                    try
                    {
                        writeToFile(ofs);
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        ofs.Close();
                        Text = Path.GetFileName(saveDialog.FileName);
                        currentFileName = saveDialog.FileName;
                        setGridModified(false);
                    }
                }
            }
        }

        private void saveProgram()
        {
            if (currentFileName.Length == 0)
                saveFileAs();
            else
                saveFile();
        }

        private void openProgram()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Markov algorithm programs (*.nam)|*.nam";
            bool readingSuccessful = true;
            uint commandsNum = 0;
            string[,] commands = null;
            string message = "Unknown error =(";
            string fileName = null;
            string problemStatement = "";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openDialog.FileName;
                try
                {
                    string text = File.ReadAllText(fileName);
                    string[] lines = text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    if (uint.TryParse(lines[0], out commandsNum))
                    {
                        if (lines.Length >= commandsNum)
                        {
                            commands = new string[commandsNum, 3];
                            for (uint line = 0; line < commandsNum && readingSuccessful; ++line)
                            {
                                string[] parts = lines[line + 1].Split();
                                if (parts.Length == 3)
                                {
                                    commands[line, 0] = parts[0];
                                    commands[line, 2] = parts[2];
                                    uint rowType;
                                    if (uint.TryParse(parts[1], out rowType))
                                    {
                                        if (rowType == 1)
                                            commands[line, 1] = ordinaryArrow;
                                        else if (rowType == 2)
                                            commands[line, 1] = finishArrow;
                                        else if (rowType == 0)
                                            commands[line, 1] = "";
                                        else
                                        {
                                            readingSuccessful = false;
                                            message = string.Format("Failed to read the type of arrow in row {0};\nshould be either 1 or 2", line + 1);
                                        }
                                    }
                                    else
                                    {
                                        readingSuccessful = false;
                                        message = string.Format("Failed to read the type of arrow in row {0};\nshould be either 1 or 2", line + 1);
                                    }
                                }
                                else if (parts.Length == 2)
                                {
                                    // TODO
                                }
                                else if (parts.Length == 1)
                                {
                                    // TODO
                                }
                                else
                                {
                                    readingSuccessful = false;
                                    message = string.Format("Failed to read command in row {0}", line + 1);
                                }
                            }
                            if (readingSuccessful)
                            {
                                if (lines.Length > commandsNum + 1)
                                {
                                    problemStatement = lines[commandsNum + 1];
                                }
                            }
                        }
                        else
                        {
                            readingSuccessful = false;
                            message = string.Format("Too few commands in the file (expected - {0})", commandsNum);
                        }
                    }
                    else
                    {
                        readingSuccessful = false;
                        message = "Failed to read the number of commands";
                    }
                }
                catch (IOException)
                {
                    readingSuccessful = false;
                    message = "Failed to open file";
                }
            }
            //else
            //{
            //    readingSuccessful = false;
            //    message = "Failed to open dialog";
            //}
            if (readingSuccessful)
            {
                programGrid.Rows.Clear();
                for (int row = 0; row < commandsNum; ++row)
                {
                    addRow();
                    for (int col = 1; col <= 3; ++col)
                        programGrid[col, row].Value = commands[row, col - 1];
                }
                /*while (programGrid.RowCount < 5)
                    addRow();*/
                Text = Path.GetFileName(fileName);
                currentFileName = fileName;
                statementTextBox.Text = problemStatement;
                setGridModified(false);
            }
            else
                MessageBox.Show(message, "Parsing file failed", MessageBoxButtons.OK);
        }

        private void createNewFile()
        {
            Text = defaultWindowText;
            statementTextBox.Text = "";
            setGridModified(false);
            programGrid.Rows.Clear();
            for (int i = 0; i < 4; ++i)
                addRow();
            currentFileName = "";
        }

        private void createNewProgram()
        {
            if (fileModified)
            {
                var response = MessageBox.Show("Would you like to save changes?", "Warning", MessageBoxButtons.YesNoCancel);
                if (response == DialogResult.Yes)
                {
                    saveProgram();
                    createNewFile();
                }
                else if (response == DialogResult.No)
                    createNewFile();
            }
            else
                createNewFile();
        }



    }
}
