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
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            Client_Home client = new Client_Home();
            this.Hide();
            client.Show();
        }
    }
}
