using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Am_I_Positive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double integer = Convert.ToDouble(inputBox.Text);

            if(integer > 0)
            {
                outputLabel.Text = $"{integer} is a positive number";
            }
            else
            {
                outputLabel.Text = $"{integer} is a negative number";
            }
        }
    }
}
