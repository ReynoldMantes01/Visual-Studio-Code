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
    public partial class area : Form
    {
        public area()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void area_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double length = double.Parse(textWitdth.Text);
            double width = double.Parse(textLength.Text);

            double area = length * width;

            textArea.Text = $"Area: {area}";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
