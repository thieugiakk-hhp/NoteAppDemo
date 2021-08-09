using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteAppDemo.Class;

namespace NoteAppDemo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            Class.Connection.Connect();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Class.Connection.Disconnect();
            Application.Exit();
        }

        private void tsbAddNote_Click(object sender, EventArgs e)
        {
            frmAddNote frmAN = new frmAddNote();
            frmAN.Show();
        }
    }
}
