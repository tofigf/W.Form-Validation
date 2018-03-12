using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Char_validation
{
    public partial class Form1 : Form
    {
        public static string passingText;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
                passingText = txtName.Text;
                Dashboard dsb = new Dashboard();
                dsb.Show();
                this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Email leave required @
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains("@"))
            {
                lblError.Text = "An email address must contain a single @";
            }
        }
        //Email enter become empty
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            lblError.Text = " ";
        }
        // Name enter write this..
        private void txtName_Enter(object sender, EventArgs e)
        {
                lblEnter.Text = " Choose a username that contains only letters and numbers.";
        }
        //Name leave vanish
        private void txtName_Leave(object sender, EventArgs e)
        {
            lblEnter.Text = " ";
        }
        //Form1 exit definitly
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //passvord changes
        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            string password = txtpass.Text;
            if (password.Any(char.IsLower))
            {
                lblLow.ForeColor = Color.Gray;
            }
            else
            {
                lblLow.ForeColor = Color.Black;
            }
            if (password.Any(char.IsUpper))
            {
                lblUpper.ForeColor = Color.Gray;
            }
            else
            {
                lblUpper.ForeColor = Color.Black;
            }
            if (password.Any(char.IsNumber))
            {
                lblNumber.ForeColor = Color.Gray;
            }
            else
            {
                lblNumber.ForeColor = Color.Black;
            }
            if (password.Any(char.IsPunctuation)|| password.Any(char.IsSymbol))
            {
                lblSpecial.ForeColor = Color.Gray;
            }
            else
            {
                lblSpecial.ForeColor = Color.Black;
            }
            if (password.Length > 7)
            {
                lblMax.ForeColor = Color.Gray;
                btnClick.Enabled = true;
                btnClick.BackColor = Color.LightSeaGreen;
            }
            else
            {
                lblMax.ForeColor = Color.Black;
                btnClick.Enabled = false;
                btnClick.BackColor = Color.White;
            }
        }
    }
}
