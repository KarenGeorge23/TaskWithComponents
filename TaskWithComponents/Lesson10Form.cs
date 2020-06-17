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
    public partial class Lesson10Form : Form
    {
        public Lesson10Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Text += "Размер экрана: " + SystemInformation.PrimaryMonitorSize.ToString() + "\n";
            richTextBox1.Text += "Имя компьютера: " + SystemInformation.ComputerName.ToString() + "\n";
            richTextBox1.Text += "Количество кнопок у мыши: " + SystemInformation.MouseButtons.ToString() + "\n";
            richTextBox1.Text += "Используемый шрифт для меню и его имя: " + SystemInformation.MenuFont.Name + "\n";
            richTextBox1.Text += "Имя текущего пользователя: " + SystemInformation.UserName + "\n";
        }
    }
}
