using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
using static TransferObject.Account;
using BusinessLayer;

namespace Multilayer
{
    public partial class formLogin : Form
    {
       
        public formLogin()
        {
            InitializeComponent(); 
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

            string username, password;
            username = textBox1.Text.Trim();
            password = textBox2.Text;

            Account acc = new Account(username, password);
            bool b = true;
            try 
            {
                b = new LoginBL().Login(acc);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (b) 
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                string msg = "Username or Password is incorrect !";
                DialogResult result = MessageBox.Show(msg,"Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    textBox1.Focus();
                }
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
