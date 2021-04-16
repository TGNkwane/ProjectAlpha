using System;
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
    public partial class Package : Form
    {
        public Package()
        {
            InitializeComponent();
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            Form5 manager = new Form5();
            this.Hide();
            manager.Show();
        }
    }
}
