using System;
using System.Windows.Forms;

namespace AnnasGarage
{
    public partial class JobSelection : Form
    {
        public JobSelection()
        {
            InitializeComponent();
        }

        private void JobSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MOT mot = new MOT();
                mot.Show();
                Hide();
            }
            if (radioButton2.Checked)
            {
                CoolantTopup coolantTopup = new CoolantTopup();
                coolantTopup.Show();
                Hide();
            }
            if (radioButton3.Checked)
            {
                OilChange oilChange = new OilChange();
                oilChange.Show();
                Hide();
            }
            if (radioButton4.Checked)
            {
                WiperBlades wiperBlades = new WiperBlades();
                wiperBlades.Show();
                Hide();
            }
            if (radioButton5.Checked)
            {
                
            }
            if (radioButton6.Checked)
            {
                
            }
        }

        private void JobSelection_Load(object sender, EventArgs e)
        {
            Text = "Anna's Garage - "+Form1.CustName+ " , " + Form1.JobNum;
        }
    }
}