﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinStock
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }
    

    private void backBtn_Click(object sender, EventArgs e)
        {
            Archive obj = new Archive();
            obj.Show();
            this.Hide();
        }
    }
}
