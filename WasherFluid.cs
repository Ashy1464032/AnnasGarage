using System;
using System.Windows.Forms;

namespace AnnasGarage
{
    public partial class WasherFluid : Form
    {
        public WasherFluid()
        {
            InitializeComponent();
        }

        private void WasherFluid_Load(object sender, EventArgs e)
        {
            Text = "Anna's Garage - "+Form1.CustName+ " , " + Form1.JobNum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form1.TotalBill += 5;
                Form1.ReciptItems[0, 0] = "Washer Fluid Top up";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£5";
            }

            Bill bill = new Bill();
            bill.Show();
            Hide();
        }
    }
}