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
    public partial class frmServiceRequest : Form
    {
        public frmServiceRequest()
        {
            InitializeComponent();
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            this.Hide();
            service.Show();
        }
    }
}
