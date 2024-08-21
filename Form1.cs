using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FeedbackCRUD
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=DOTNET;User Id=root;Password=Admin@123Admin@123";
            string query = "SELECT * FROM Feedbacks";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand feedbackQuery = new MySqlCommand("SELECT * FROM Feedbacks"))
                {
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter())
                    {
                        feedbackQuery.Connection = connection;
                        dataAdapter.SelectCommand = feedbackQuery;

                        using (DataTable table = new DataTable())
                        {
                            dataAdapter.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = NameTextBox.Text;
            String description = DescriptionTextBox.Text;
            Int32 ratings = Convert.ToInt32(Math.Round(RatingNumericValue.Value, 0));

            string connectionString = "Server=localhost;Database=DOTNET;User Id=root;Password=Admin@123Admin@123";
            string query = "INSERT INTO Feedbacks (presenter_name , feedback_rating , feedback_desc) VALUES (@name , @rating , @desc)";

            Console.WriteLine(query);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand feedbackQuery = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter())
                    {
                        feedbackQuery.Parameters.AddWithValue("@name", name);
                        feedbackQuery.Parameters.AddWithValue("@rating", ratings);
                        feedbackQuery.Parameters.AddWithValue("@desc", description);

                        connection.Open();
                        int rowsAffected = feedbackQuery.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Feedback added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Error adding feedback!");
                        }

                    }
                }
            }
        }


        private DataTable GetData(String query)
        {
            string connectionString = "Server=localhost;Database=DOTNET;User Id=root;Password=Admin@123Admin@123";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand feedbackQuery = new MySqlCommand(query))
                {
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter())
                    {
                        feedbackQuery.Connection = connection;
                        dataAdapter.SelectCommand = feedbackQuery;

                        using (DataTable table = new DataTable())
                        {
                            dataAdapter.Fill(table);

                            return table;
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();

            string query = "SELECT * FROM Feedbacks";

            foreach (DataRow row in GetData(query).Rows)
            {
                checkedListBox1.Items.Add(row["presenter_name"].ToString() + " (Rating: " + row["feedback_rating"].ToString() + ", Description: " + row["feedback_desc"].ToString() + ")");
            }
        }

        public static (string Name, int Rating, string Description) ParseFeedback(string input)
        {
            // Define a regex pattern to match the string format
            string pattern = @"^(.*)\s+\(Rating:\s*(\d+),\s*Description:\s*(.*)\)$";

            // Match the input string against the pattern
            Match match = Regex.Match(input, pattern);

            // If the match is successful, extract the values
            if (match.Success)
            {
                string name = match.Groups[1].Value.Trim();
                int rating = int.Parse(match.Groups[2].Value);
                string description = match.Groups[3].Value.Trim();

                return (name, rating, description);
            }
            else
            {
                throw new FormatException("The input string is not in the expected format.");
            }
        }

        private void DeleteData(String person)
        {
            var details = ParseFeedback(person);

            String name = details.Name;
            String desc = details.Description;
            Int32 rating = details.Rating;

            string connectionString = "Server=localhost;Database=DOTNET;User Id=root;Password=Admin@123Admin@123";
            string deleteQuery = "DELETE FROM Feedbacks WHERE presenter_name = @name AND feedback_rating = @rating AND feedback_desc = @desc";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Create the MySqlCommand object
                using (MySqlCommand query = new MySqlCommand(deleteQuery, connection))
                {
                    // Add parameters to the query
                    query.Parameters.AddWithValue("@name", name);
                    query.Parameters.AddWithValue("@rating", rating);
                    query.Parameters.AddWithValue("@desc", desc);

                    // Open the connection
                    connection.Open();

                    // Execute the query
                    int rowsAffected = query.ExecuteNonQuery();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Object selection in checkedListBox1.CheckedItems)
            {
                String selectedPerson = (selection.ToString());
                DeleteData(selectedPerson);
            }

            MessageBox.Show("Deleted Successfully!");
            button3_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();

            string query = "SELECT * FROM Feedbacks";

            foreach (DataRow row in GetData(query).Rows)
            {
                checkedListBox2.Items.Add(row["presenter_name"].ToString() + " (Rating: " + row["feedback_rating"].ToString() + ", Description: " + row["feedback_desc"].ToString() + ")");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Object selection in checkedListBox2.CheckedItems)
            {
                String selectedPerson = (selection.ToString());
                DeleteData(selectedPerson);

                var details = ParseFeedback(selectedPerson);

                String name = details.Name;
                String desc = details.Description;
                Int32 rating = details.Rating;

                button3_Click(sender, e);

                Form2 changeForm = new Form2(name, desc, rating);
                changeForm.ShowDialog();
            }


            button3_Click(sender, e);
        }
    }
}
