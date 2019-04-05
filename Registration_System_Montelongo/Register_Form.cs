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
    public partial class Register_Form : Form {
        public Register_Form() {
            InitializeComponent();

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {
                conn.Open();

                string queryStudent = "SELECT lname, fname, student_id FROM student_table Order by lname, fname ASC;";
                string querySection = "SELECT section_id, teacher_id, course_name, section, days, start_time, end_time FROM section_table Order by course_name, section ASC;";
                MySqlCommand cmd = new MySqlCommand(queryStudent, conn);
                MySqlCommand cmd2 = new MySqlCommand(querySection, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable tableStudent = new DataTable();
                DataTable tableSection = new DataTable();

                tableStudent.Load(reader);

                for (int i = 0; i < tableStudent.Rows.Count; i++) {
                    studentComboBox.Items.Add(tableStudent.Rows[i]["student_id"] + " " + tableStudent.Rows[i]["lname"] + "," + tableStudent.Rows[i]["fname"]);
                }


                reader = cmd2.ExecuteReader();
                tableSection.Load(reader);

                for (int i = 0; i < tableSection.Rows.Count; i++) {
                    sectionComboBox.Items.Add(tableSection.Rows[i]["section_id"] + " : " + tableSection.Rows[i]["course_name"] + " " + tableSection.Rows[i]["section"]);
                }

                reader.Close();
                conn.Close();

            }

        }

        private void Register_Form_Load(object sender, EventArgs e) {

        }

        private void exitButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e) {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {

                string studentID = studentComboBox.Text;
                string sectionID = sectionComboBox.Text;

                conn.Open();

                string query = $"INSERT INTO `registration_table` (`registration_id`, `student_id`, `section_id`, `date_registered`, `grade_earned`) VALUES (NULL, '{studentID}', '{sectionID}', CURRENT_TIMESTAMP, NULL);";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

            this.Close();

        }

        
    }
}


