using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            label4.Text = $"Witaj {textBox1.Text} {textBox2.Text}";
            string line = textBox3.Text;
            try
            {
                int wiek = Int32.Parse(line);
                if (wiek < 67)
                {
                    label5.Text = string.Format($"do emerytury zostalo ci {67 - wiek} ");
                }
                else
                {
                    label5.Text = "jestes emerytem";
                }

            }
            catch(FormatException)
            {
                label5.Text = "Bledne dane";
            }
            catch(OverflowException)
            {
                label5.Text = "Bledne dane";
            }

            
        }
    }
}
