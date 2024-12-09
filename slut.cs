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
    public partial class slut : Form
    {
        Random rnd = new Random();
        public slut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomizeShapes();
        }
        private void RandomizeShapes()
        {
            // Array of PictureBoxes
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                // Clear the PictureBox
                pictureBox.Image = null;

                // Randomly choose a shape (0: Rectangle, 1: Square, 2: Oval)
                int shapeType = rnd.Next(0, 3);

                // Generate a random color
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                // Draw the shape
                DrawShape(pictureBox, shapeType, randomColor);
            }
        }
        private void DrawShape(PictureBox pictureBox, int shapeType, Color fillColor)
        {
            // Create a bitmap to draw the shape
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Create a brush for the color
                using (SolidBrush brush = new SolidBrush(fillColor))
                {
                    switch (shapeType)
                    {
                        case 0: // Rectangle
                            g.FillRectangle(brush, 10, 10, pictureBox.Width - 20, pictureBox.Height - 20);
                            break;
                        case 1: // Square
                            int size = Math.Min(pictureBox.Width, pictureBox.Height) - 20;
                            g.FillRectangle(brush, 10, 10, size, size);
                            break;
                        case 2: // Oval
                            g.FillEllipse(brush, 10, 10, pictureBox.Width - 20, pictureBox.Height - 20);
                            break;
                    }
                }
            }

            // Set the generated image to the PictureBox
            pictureBox.Image = bmp;
        }

        private void slut_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
