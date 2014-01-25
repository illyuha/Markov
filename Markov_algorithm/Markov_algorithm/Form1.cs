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

        private void programGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && programGrid.CurrentCell.ColumnIndex == 3)
            {
                e.Handled = true;
                int row = programGrid.CurrentCell.RowIndex;
                int rowsCount = programGrid.Rows.Count;
                int newRow = (row + 1) % rowsCount;
                DataGridViewCell cell = programGrid.Rows[newRow].Cells[1];
                programGrid.CurrentCell = cell;
                programGrid.BeginEdit(false);
            }
        }


    }
}
