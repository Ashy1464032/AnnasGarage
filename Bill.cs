using System;
using System.Windows.Forms;

namespace AnnasGarage
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            Text = "Anna's Garage - "+Form1.CustName+ " , " + Form1.JobNum;
            textBox1.Text = Form1.TotalBill.ToString("C");
        }

        private void Bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}