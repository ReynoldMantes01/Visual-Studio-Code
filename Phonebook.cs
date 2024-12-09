using System;
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
    public partial class Phonebook : Form
    {
        public Phonebook()
        {
            InitializeComponent();
        }
        private string loginConnectionString = "Data Source=Hanako;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private string phonebookConnectionString = "Data Source=Hanako;Initial Catalog=Phonebook;Integrated Security=True;Trust Server Certificate=True";

        private void label7_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        public static int CurrentUserId;

        private void Phonebook_Load(object sender, EventArgs e)
        {
            
            LoadContacts();
        }
        private void LoadContacts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(phonebookConnectionString))
                {
                    conn.Open();

                    // Query to fetch all contacts
                    string query = "SELECT ID, Name, Number, Email FROM ContactsTables";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        // Fill the DataTable and bind it to the DataGridView
                        da.Fill(dt);
                        dataGridView.DataSource = dt;
                        ConfigureGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading contacts: {ex.Message}");
            }
        }
        private void ConfigureGridView()
        {
            // Ensure columns fill the available horizontal space
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust column widths proportionally using FillWeight
            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns["ID"].FillWeight = 15;       // Smaller space for ID
                dataGridView.Columns["Name"].FillWeight = 35;     // Larger space for Name
                dataGridView.Columns["Number"].FillWeight = 25;   // Medium space for Number
                dataGridView.Columns["Email"].FillWeight = 35;    // Larger space for Email
            }

            // Optionally adjust column headers
            dataGridView.Columns["ID"].HeaderText = "ID";
            dataGridView.Columns["Name"].HeaderText = "Full Name";
            dataGridView.Columns["Number"].HeaderText = "Phone Number";
            dataGridView.Columns["Email"].HeaderText = "Email Address";
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textNumber.Clear();
            textEmail.Clear();
            textName.Focus();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a contact to edit.");
                return;
            }

            try
            {
                // Get selected contact's ID
                int contactId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID"].Value);

                using (SqlConnection conn = new SqlConnection(phonebookConnectionString))
                {
                    conn.Open();

                    // Update query
                    string query = "UPDATE ContactsTables SET Name = @Name, Number = @Number, Email = @Email WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@Number", textNumber.Text);
                        cmd.Parameters.AddWithValue("@Email", textEmail.Text);
                        cmd.Parameters.AddWithValue("@ID", contactId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Contact updated successfully.");
                    }
                }

                // Refresh the grid
                LoadContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating contact: {ex.Message}");
            }
        }
        

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a contact to delete.");
                return;
            }

            try
            {
                // Get selected contact's ID
                int contactId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID"].Value);

                using (SqlConnection conn = new SqlConnection(phonebookConnectionString))
                {
                    conn.Open();

                    // Delete query
                    string query = "DELETE FROM ContactsTables WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", contactId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Contact deleted successfully.");
                    }
                }

                // Refresh the grid
                LoadContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while deleting contact: {ex.Message}");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text) ||
        string.IsNullOrWhiteSpace(textNumber.Text) ||
        string.IsNullOrWhiteSpace(textEmail.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(phonebookConnectionString))
                {
                    conn.Open();

                    // Updated query without the ID column
                    string query = "INSERT INTO ContactsTables (Name, Number, Email) VALUES (@Name, @Number, @Email)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Name", textName.Text);
                        cmd.Parameters.AddWithValue("@Number", textNumber.Text);
                        cmd.Parameters.AddWithValue("@Email", textEmail.Text);

                        cmd.ExecuteNonQuery(); // Execute the query
                        MessageBox.Show("Contact added successfully.");
                    }
                }

                // Refresh the grid view after saving
                LoadContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving contact: {ex.Message}");
            }
        }
      
    }
}
