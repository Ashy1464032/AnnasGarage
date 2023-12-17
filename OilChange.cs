using System;
using System.Windows.Forms;

namespace AnnasGarage
{
    public partial class OilChange : Form
    {
        public OilChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form1.TotalBill += 4;
                Form1.ReciptItems[0, 0] = "Type 1 Oil Filter";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£4";
            }
            if (radioButton2.Checked)
            {
                Form1.TotalBill += 7;
                Form1.ReciptItems[0, 0] = "Type 2 Oil Filter";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£7";
            }
            if (radioButton3.Checked)
            {
                Form1.TotalBill += 10;
                Form1.ReciptItems[0, 0] = "Type 3 Oil Filter";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£10";
            }
            if (radioButton4.Checked)
            {
                Form1.TotalBill += 15;
                Form1.ReciptItems[0, 0] = "Type 4 Oil Filter";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£15";
            }
            Form1.TotalBill += (double)numericUpDown1.Value * 9.99;
            Form1.ReciptItems[1, 0] = "Oil change";
            Form1.ReciptItems[1, 1] = numericUpDown1.Value.ToString();
            Form1.ReciptItems[1, 2] = ((double)numericUpDown1.Value * 9.99).ToString("C");
            
            Bill bill = new Bill();
            bill.Show();
            Hide();
        }

        private void OilChange_Load(object sender, EventArgs e)
        {
            Text = "Anna's Garage - "+Form1.CustName+ " , " + Form1.JobNum;
        }
    }
}