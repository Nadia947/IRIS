﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
               
                Form f = new Form4();
                f.ShowDialog();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             Program.nume = textBox1.Text;   
        }
    }
}
