﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime dateIn1940 = new DateTime(1940, 1, 1);
            long a = dateIn1940.Ticks;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}