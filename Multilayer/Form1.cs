using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multilayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;

            formLogin login = new formLogin();
            DialogResult result = login.ShowDialog();

            if (result == DialogResult.OK)
            {
                label1.Text = "Welcome!";
                this.Enabled = true;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
