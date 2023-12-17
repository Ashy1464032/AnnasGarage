using System;
using System.Windows.Forms;

namespace AnnasGarage
{
    public partial class WiperBlades : Form
    {
        public WiperBlades()
        {
            InitializeComponent();
        }

        private void WiperBlades_Load(object sender, EventArgs e)
        {
            Text = "Anna's Garage - "+Form1.CustName+ " , " + Form1.JobNum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form1.TotalBill += 12;
                Form1.ReciptItems[0, 0] = "Small Pair of Wiper Blades";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£12";
            }
            if (radioButton2.Checked)
            {
                Form1.TotalBill += 17;
                Form1.ReciptItems[0, 0] = "Medium Pair of Wiper Blades";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£17";
            }
            if (radioButton3.Checked)
            {
                Form1.TotalBill += 25;
                Form1.ReciptItems[0, 0] = "Large Pair of Wiper Blades";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£25";
            }
            Bill bill = new Bill();
            bill.Show();
            Hide();
        }
    }
}