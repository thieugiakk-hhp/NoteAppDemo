using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppDemo
{
    public partial class frmAddNote : Form
    {
        public frmAddNote()
        {
            InitializeComponent();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAddNote_Click(object sender, EventArgs e)
        {
            frmAddNote frmAN = new frmAddNote();
            frmAN.Show();
        }

        private void setTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddTypeNote frmATN = new frmAddTypeNote();
            frmATN.ShowDialog();
        }
    }
}
