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

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form1.TotalBill += 40;
            } else if (radioButton2.Checked)
            {
                Form1.TotalBill += 50;
            } else if (radioButton3.Checked)
            {
                Form1.TotalBill += 60;
            }

            if (checkBox1.Checked)
            {
                Form1.TotalBill += (double)numericUpDown1.Value * 10.0;
            }
            else
            {
                Form1.TotalBill += (double)numericUpDown1.Value * 7.0;
            }

            Form1.TotalBill += (double)numericUpDown2.Value * 3.60;

            Bill bill = new Bill();
            bill.Show();
            Hide();
        }
    }
}