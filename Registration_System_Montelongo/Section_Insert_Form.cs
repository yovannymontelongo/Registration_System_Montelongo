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
    public partial class Section_Insert_Form : Form {
        public Section_Insert_Form() {
            InitializeComponent();

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {
                conn.Open();

                string query = "SELECT lname, fname, teacher_id FROM teacher_table Order by lname, fname ASC;";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++) {
                    teacherComboBox.Items.Add(table.Rows[i]["teacher_id"] + " " + table.Rows[i]["lname"] + "," + table.Rows[i]["fname"]);
                }

                reader.Close();
                conn.Close();

            }

        }

        private void Section_Insert_Form_Load(object sender, EventArgs e) {

        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e) {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {

                string teacherID = teacherComboBox.Text;
                string course = courseTextBox.Text;
                string section = sectionTextBox.Text;
                string days = daysTextBox.Text;
                string start = startTextBox.Text;
                string end = endTextBox.Text;
                string[] words = teacherID.Split(' ');
                string teacherIDNum = words[0]; //get the id from the split string. 

                conn.Open();

                string query = $"INSERT INTO `section_table` (`section_id`, `teacher_id`, `course_name`, `section`, `days`, `start_time`, `end_time`) VALUES (NULL, '{teacherIDNum}', '{course}', '{section}', '{days}', '{start}', '{end}');";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }

            this.Close();

        }

        private void teacherComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
