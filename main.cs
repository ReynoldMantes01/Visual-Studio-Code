using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new area().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Phonebook().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Calculator().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new slut().Show();
            this.Hide();
        }
    }
}
