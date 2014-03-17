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

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveProgram();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            openProgram();
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
            //if (keyData == (Keys.Control | Keys.F5) && runButton.Enabled)
            //    runProgram();
            //else if (keyData == (Keys.Shift | Keys.F5) && StopButton.Enabled)
            //    stopProgram();
            //else if (keyData == (Keys.F5) && debugButton.Enabled)
            //    debugProgram();
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
                    saveProgram();
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openProgram();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveProgram();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            createNewProgram();
        }

        private void runToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            runProgram();
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            debugProgram();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopProgram();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewProgram();
        }

        private void aboutMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
        
    }
}
