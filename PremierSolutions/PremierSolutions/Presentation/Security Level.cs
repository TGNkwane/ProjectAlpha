﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierSolutions
{
    public partial class Security_Level : Form
    {
        public Security_Level()
        {
            InitializeComponent();
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            this.Hide();
            package.Show();
        }
    }
}
