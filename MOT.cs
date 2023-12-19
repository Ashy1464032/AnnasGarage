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
                Form1.ReciptItems[0, 0] = "Class 4 MOT";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£40";
            } else if (radioButton2.Checked)
            {
                Form1.TotalBill += 50;
                Form1.ReciptItems[0, 0] = "Class 5 MOT";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£50";
            } else if (radioButton3.Checked)
            {
                Form1.TotalBill += 60;
                Form1.ReciptItems[0, 0] = "Class 7 MOT";
                Form1.ReciptItems[0, 1] = "1";
                Form1.ReciptItems[0, 2] = "£60";
            }

            if (checkBox1.Checked)
            {
                Form1.TotalBill += (double)numericUpDown1.Value * 10.0;
                Form1.ReciptItems[1, 0] = "Halogen Head Lights";
                Form1.ReciptItems[1, 1] = numericUpDown1.Value.ToString();
                Form1.ReciptItems[1, 2] = ((double)numericUpDown1.Value * 10.0).ToString("C");
            }
            else
            {
                Form1.TotalBill += (double)numericUpDown1.Value * 7.0;
                Form1.ReciptItems[1, 0] = "Standard Head Lights";
                Form1.ReciptItems[1, 1] = numericUpDown1.Value.ToString();
                Form1.ReciptItems[1, 2] = ((double)numericUpDown1.Value * 10.0).ToString("C");
            }

            if (numericUpDown1.Value != 0){
                Form1.TotalBill += (double)numericUpDown2.Value * 3.60;
                Form1.ReciptItems[2, 0] = "Tail Lights";
                Form1.ReciptItems[2, 1] = numericUpDown2.Value.ToString();
                Form1.ReciptItems[2, 2] = ((double)numericUpDown2.Value * 3.60).ToString("C");
            }
            else
            {
                Form1.TotalBill += (double)numericUpDown2.Value * 3.60;
                Form1.ReciptItems[1, 0] = "Tail Lights";
                Form1.ReciptItems[1, 1] = numericUpDown1.Value.ToString();
                Form1.ReciptItems[1, 2] = ((double)numericUpDown2.Value * 3.60).ToString("C");
            }

            Bill bill = new Bill();
            bill.Show();
            Hide();
        }
    }
}