﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private string _name;
        public Form2(string name)
        {
            InitializeComponent();

            _name = name;
            label1.Text = $"Hi{_name}";
        }
    }
}
