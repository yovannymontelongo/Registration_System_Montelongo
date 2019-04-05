using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Registration_System_Montelongo {
    public partial class Teacher_Insert_Form : Form {
        public Teacher_Insert_Form() {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e) {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {

                string fname = fnameTextBox.Text;
                string lname = lnameTextBox.Text;
                string title = titleTextBox.Text;
                string rank = rankTextBox.Text;

                conn.Open();

                string query = $"INSERT INTO `teacher_table` (`teacher_id`, `fname`, `lname`, `title`, `rank`) VALUES (NULL, '{fname}', '{lname}', '{title}', '{rank}');";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int numRowsAffected = cmd.ExecuteNonQuery();
                long lastInserted = cmd.LastInsertedId;

                //if (numRowsAffected >= 1) {
                //    MessageBox.Show("Rows: " + numRowsAffected + ". ID entered: " + lastInserted);
                //} else {
                //    MessageBox.Show("Error in insert query");
                //}

                conn.Close();
            }

            this.Close();

        }
    }
}
