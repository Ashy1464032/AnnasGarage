using System;
using System.Windows.Forms;

namespace AnnasGarage
{
    public partial class MOT : Form
    {
        public MOT()
        {
            InitializeComponent();
        }

        private void MOT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MOT_Load(object sender, EventArgs e)
        {
            Text = "Anna's Garage - "+Form1.CustName+ " , " + Form1.JobNum;
        }
    }
}