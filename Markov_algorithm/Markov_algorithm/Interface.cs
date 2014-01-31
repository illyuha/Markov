using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Markov_algorithm
{
    public partial class MarkovForm : Form
    {
        private const int rowsByDefault = 5;
        private const int columnsCount = 4;
        private int rightClickedRow;

        public MarkovForm()
        {
            InitializeComponent();
            for (int i = 0; i < rowsByDefault - 1; i++)
                this.addRow();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programGrid.CurrentCell = null;
            if (rightClickedRow < programGrid.Rows.Count-1)
                programGrid.Rows.RemoveAt(rightClickedRow);
        }

        private void clearRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programGrid.CurrentCell = null;
            for (int i = 1; i < 4; i++)
                programGrid.Rows[rightClickedRow].Cells[i].Value = null;
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addRow();
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

    }
}
