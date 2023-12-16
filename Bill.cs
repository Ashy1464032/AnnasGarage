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
            MOT mot = new MOT();
            Text = "Anna's Garage - "+Form1.CustName+ " , " + Form1.JobNum;
            textBox1.Text = Form1.TotalBill.ToString("C");

            dataGridView1.Rows.Add(Form1.ReciptItems[0,0],Form1.ReciptItems[0,1],Form1.ReciptItems[0,2]);
            if (Form1.ReciptItems[1, 0] != "")
            {
                dataGridView1.Rows.Add(Form1.ReciptItems[1,0],Form1.ReciptItems[1,1],Form1.ReciptItems[1,2]);
                if (Form1.ReciptItems[2,0] != "")
                {
                    dataGridView1.Rows.Add(Form1.ReciptItems[2,0],Form1.ReciptItems[2,1],Form1.ReciptItems[2,2]);
                }
            }
        }

        private void Bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}