using System;
using System.Windows.Forms;

namespace AnnasGarage
{
    public partial class Valeting : Form
    {
        public Valeting()
        {
            InitializeComponent();
        }

        private void Valeting_Load(object sender, EventArgs e)
        {
            Text = "Anna's Garage - "+Form1.CustName+ " , " + Form1.JobNum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form1.TotalBill += 25;
                Form1.ReciptItems[0, 0] = "Bronze Valet";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£25";
            }
            if (radioButton2.Checked)
            {
                Form1.TotalBill += 35;
                Form1.ReciptItems[0, 0] = "Silver Valet";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£35";
            }
            if (radioButton3.Checked)
            {
                Form1.TotalBill += 50;
                Form1.ReciptItems[0, 0] = "Gold Valet";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£50";
            }

            if (checkBox1.Checked)
            {
                Form1.TotalBill += 10;
                Form1.ReciptItems[1, 0] = "4 by four/7 Seater";
                Form1.ReciptItems[1, 1] = "1";
                Form1.ReciptItems[1, 2] = "£10";
            }

            Bill bill = new Bill();
            bill.Show();
            Hide();
        }
    }
}