using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnnasGarage
{
    public partial class Form1 : Form
    {
        
        public static String[,] ReciptItems = {{"","",""},{"","",""},{"","",""} };
        public static String CustName;
        public static String JobNum;
        public static Double TotalBill;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustName = textBox1.Text;
            JobNum = textBox2.Text;
            JobSelection jobSelection = new JobSelection();
            jobSelection.Show();
            Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}