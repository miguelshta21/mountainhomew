using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron.mountain.test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void eid_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            idtxt.MaxLength = 8;
            bool IsNum = true;
            foreach (char item in idtxt.Text)
            {
                if (!Char.IsNumber(item))
                {
                    IsNum = false;
                }
            }
            if (IsNum = false)
            {
                MessageBox.Show("Only Numbers.");
            }
        }
    }

}
