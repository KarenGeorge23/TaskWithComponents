﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskWithComponents
{
    public partial class Lesson32Form : Form
    {
        public Lesson32Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали кнопку");
        }

        private void Lesson32Form_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
