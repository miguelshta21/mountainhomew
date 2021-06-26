using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Testv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool IsInteger(String strNumber)
        {
            Regex objNotIntPattern = new Regex("[0-9]{1,8}");
            return objNotIntPattern.IsMatch(strNumber);
        }

        private void Idtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
          
    }

        private void Idtxt_TextChanged(object sender, EventArgs e)
        {
            if (IsInteger(Idtxt.Text))
            {


                MessageBox.Show("Only Numbers.");
                int textLength = Idtxt.TextLength;
                switch (textLength)
                {
                    case 1: Idtxt.Text = "0000000" + Idtxt.Text; break;
                    case 2: Idtxt.Text = "000000" + Idtxt.Text; break;
                    case 3: Idtxt.Text = "00000" + Idtxt.Text; break;
                    case 4: Idtxt.Text = "0000" + Idtxt.Text; break;
                    case 5: Idtxt.Text = "000" + Idtxt.Text; break;
                    case 6: Idtxt.Text = "00" + Idtxt.Text; break;
                    case 7: Idtxt.Text = "0" + Idtxt.Text; break;

                }
            }
            else
            {
                MessageBox.Show("Only Numbers.");
            }
    }
}
}
