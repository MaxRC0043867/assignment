using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //read length, width and height from textboxes
                double length = double.Parse(textBox1.Text);
                double width = double.Parse(textBox2.Text);
                double height = double.Parse(textBox3.Text);
                // calculation of area and volume
                double area = 2.0 * ((length * width) + (length * height) + (width * height));
                double volume = length * width * height;
                // put values in labels
                label1.Text = "surface area = " + area;
                label2.Text = "volume = " + volume;


            }
            catch
            {
                // show error message on screen if fail
                MessageBox.Show("Error! Error!! Error!!!!!!!");

            }
        }

        }
    }

