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
    public partial class frmIncident : Form
    {
        public frmIncident()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            Form4 followUp = new Form4();
            this.Hide();
            followUp.Show();
        }
    }
}
