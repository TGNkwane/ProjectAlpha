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
    public partial class Client_Home : Form
    {
        public Client_Home()
        {
            InitializeComponent();
        }

        private void Client_Home_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            callForm callForm = new callForm();
            this.Hide();
            callForm.Show();
        }
    }
}
