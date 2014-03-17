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
        private const int rowsByDefault = 5;
        private const int columnsCount = 4;
        private int rightClickedRow;
        private string defaultWindowText = "New file";
        private bool fileModified = false;
        private string currentFileName = ""; // with the full path and extension

        public MarkovForm()
        {
            InitializeComponent();
            for (int i = 0; i < rowsByDefault - 1; i++)
                this.addRow();
            Text = defaultWindowText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = MinimizeBox = false;
        }

        private void setGridModified(bool modified)
        {
            if (modified)
            {
                if (!fileModified)
                {
                    fileModified = true;
                    Text += "*";
                }
            }
            else
            {
                if (fileModified)
                {
                    fileModified = false;
                    // I am sorry...
                    if (Text.Length == 0)
                        Text = defaultWindowText;
                    else
                    {
                        if (Text[Text.Length - 1] == '*')
                            Text = Text.Substring(0, Text.Length - 1);
                    }
                }
            }
        }

        private void addRow()
        {
            programGrid.Rows.Add();
        }

        private void programGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int rowsCount = programGrid.Rows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                programGrid.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void programGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int rowsCount = programGrid.Rows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                programGrid.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void programGrid_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Tab && programGrid.CurrentCell.ColumnIndex == 3)
            {
                e.Handled = true;
                int row = programGrid.CurrentCell.RowIndex;
                int rowsCount = programGrid.Rows.Count;
                int newRow = (row + 1) % rowsCount;
                DataGridViewCell cell = programGrid.Rows[newRow].Cells[1];
                programGrid.CurrentCell = cell;
                programGrid.BeginEdit(false);
            }*/
        }

        private void insertRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programGrid.CurrentCell = null;
            programGrid.Rows.Insert(rightClickedRow);
            setGridModified(true);
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programGrid.CurrentCell = null;
            if (rightClickedRow < programGrid.Rows.Count-1)
                programGrid.Rows.RemoveAt(rightClickedRow);
            setGridModified(true);
        }

        private void clearRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programGrid.CurrentCell = null;
            for (int i = 1; i < 4; i++)
                programGrid.Rows[rightClickedRow].Cells[i].Value = null;
            setGridModified(true);
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addRow();
            setGridModified(true);
        }

        private void programGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DataGridView dgv = sender as DataGridView;
                DataGridView.HitTestInfo hit = dgv.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    rightClickedRow = hit.RowIndex;
                    dgv.ContextMenuStrip = programMenuStrip;
                }
                else
                    dgv.ContextMenuStrip = null;
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            runProgram();
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
                    }
                }
                Text = Path.GetFileName(saveDialog.FileName);
                currentFileName = saveDialog.FileName;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (currentFileName.Length == 0)
                saveFileAs();
            else
                saveFile();
            setGridModified(false);
        }

        private void openFile()
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
                catch (IOException ex)
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

        private void OpenButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            debugProgram();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            stopProgram();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F5) && runButton.Enabled)
                runProgram();
            else if (keyData == (Keys.Shift | Keys.F5) && StopButton.Enabled)
                stopProgram();
            else if (keyData == (Keys.F5) && debugButton.Enabled)
                debugProgram();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void programGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            setGridModified(true);
        }

        private void MarkovForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileModified)
            {
                var response = MessageBox.Show("Would you like to save changes?", "Warning", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    if (currentFileName.Length == 0)
                        saveFileAs();
                    else
                        saveFile();
                }
                // TODO: handle somehow calcellation of saving a file
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileAs();
        }

        private void statementTextBox_TextChanged(object sender, EventArgs e)
        {
            setGridModified(true);
        }
        
    }
}
