using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection("Data Source=Hanako;Initial Catalog=loginapp;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPas.Checked)
            {
                textPassword.PasswordChar = '\0';
                
            }
            else
            {
                textPassword.PasswordChar = '*';
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            string login = "SELECT * FROM loginapp WHERE username= '" + textUsername.Text + "' and password= '" + textPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new Main().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUsername.Text = "";
                textPassword.Text = "";
                textUsername.Focus(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }
    }
}
