using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackCRUD
{
    public partial class Form2 : Form
    {
        String name;
        String description;
        Int32 rating;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String name, String desc, Int32 rating)
        {
            InitializeComponent();

            this.name = name;
            this.description = desc;
            this.rating = rating;

            NameTextBox.Text = name;
            RatingNumericValue.Value = rating;
            DescriptionTextBox.Text = description;
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


            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
