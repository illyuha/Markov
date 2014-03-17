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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            try
            {
                string path = Path.GetDirectoryName(Application.ExecutablePath);
                string fileName = "help.txt";
                string fullName = Path.Combine(path, fileName);
                helpTextBox.Text = File.ReadAllText(@fullName);
            }
            catch (IOException)
            {
            }
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
        }
    }
}
