using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enter tuşu çalışıyor");    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("esc tuşu çalışıyor");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.ControlBox == true)

                this.ControlBox = false;
            else 
                this.ControlBox = true;



        }

        private void button4_Click(object sender, EventArgs e)
        {
        this.CenterToScreen();
        }
         
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.ShowDialog();
        }
       
    }
    }

