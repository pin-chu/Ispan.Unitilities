﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;//顯示轉型,若sender不是Button會錯
            Button btn2 = sender as Button;//這比較好,若無法轉型,2=,不會報錯
            
            bool isButton=sender is Button;//較少用,如果sender型別是Button,傳回true
            
        }
    }
}
