using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;

namespace OOPLab7
{
    public partial class Form1 : DarkForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        Array A;

        private void darkButton2_Click(object sender, EventArgs e)
        {
            darkButton1.Visible = true;
            try
            {
                if ((darkTextBox1.Text == "") & ((darkTextBox2.Text == "")))
                    A = new Array();
                else A = new Array(darkTextBox2.Text, Convert.ToInt32(darkTextBox1.Text));
            }
            catch { }
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            darkGroupBox1.Visible = true;
            try
            {
                A.Display(listBox1);
                A.NName(darkTextBox4);
                A.SRAR(darkTextBox5, darkTextBox6);
                A.SRG(darkTextBox7);
            }
            catch { }
        }

        private void darkButton3_Click(object sender, EventArgs e)
        {
            try
            {
                A.Plus(Convert.ToInt32(darkTextBox8.Text));
            }
            catch { }
        }
    }
}
