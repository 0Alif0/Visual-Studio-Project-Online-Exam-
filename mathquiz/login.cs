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

namespace mathquiz
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
             
                string connectionstring = @"server=localhost;port=3306;database=application;userid=root;password=;";
                MySqlConnection connection = new MySqlConnection(connectionstring);
                connection.Open();
                string query = "select * from application where email='" + textBox1.Text + "' and password='" + textBox2.Text + "';";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MySqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    this.Hide();
                    welcome a = new welcome();
                    a.Show();
                }
              
                else
                {
                    MessageBox.Show("Email Or Password are Incorrect");
                }


            }
        }

    }
}

