using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LoginForm
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection("Data Source=Hanako;Initial Catalog=loginapp;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "" && textPas.Text == "" && textConfirmPas.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textPas.Text == textConfirmPas.Text)
            {
                con.Open();
                string register = "INSERT INTO loginapp VALUES ('" + textUsername.Text + "','" + textPas.Text + "')";
                SqlCommand cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                textUsername.Text = "";
                textPas.Text = "";
                textConfirmPas.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Password does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPas.Text = "";
                textConfirmPas.Text = "";
                textPas.Focus();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpass.Checked)
            {
                textPas.PasswordChar = '\0';
                textConfirmPas.PasswordChar = '\0';
            }
            else
            {
                textPas.PasswordChar = '*';
                textConfirmPas.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textUsername.Text = "";
            textPas.Text = "";
            textConfirmPas.Text = "";
            textUsername.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
