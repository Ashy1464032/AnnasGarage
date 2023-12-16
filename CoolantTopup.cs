using System;
using System.Windows.Forms;

namespace AnnasGarage
{
    public partial class CoolantTopup : Form
    {
        public CoolantTopup()
        {
            InitializeComponent();
        }
        
        private void CoolantTopup_Load(object sender, EventArgs e)
        {
            Text = "Anna's Garage - "+Form1.CustName+ " , " + Form1.JobNum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form1.TotalBill += 2;
                Form1.ReciptItems[0, 0] = "Normal Coolant Top up";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£2";
            }
            if (radioButton2.Checked)
            {
                Form1.TotalBill += 10;
                Form1.ReciptItems[0, 0] = "Anti-Freeze Coolant Top up";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£10";
            }
            Bill bill = new Bill();
            bill.Show();
            Hide();
        }
    }
}