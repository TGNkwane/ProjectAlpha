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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            Individual_Client_Info info = new Individual_Client_Info();
            this.Hide();
            info.Show();
        }
    }
}
