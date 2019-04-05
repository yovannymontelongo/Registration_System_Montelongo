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

namespace Registration_System_Montelongo {
    public partial class Section_Update_Form : Form {
        public Section_Update_Form() {
            InitializeComponent();

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {
                conn.Open();

                string query = "SELECT lname, fname, teacher_id FROM teacher_table Order by lname, fname ASC;";
                string query2 = "SELECT section_id, teacher_id, course_name, section, days FROM section_table Order by section_id, course_name, section ASC;";
                //MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable sectionTable = new DataTable();
                DataTable teacherTable = new DataTable();

                teacherTable.Load(reader);

                for (int i = 0; i < teacherTable.Rows.Count; i++) {
                    teacherComboBox.Items.Add(teacherTable.Rows[i]["teacher_id"] + " " + teacherTable.Rows[i]["lname"] + " , " + teacherTable.Rows[i]["fname"]);
                }

                reader.Close();

                MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                sectionTable.Load(reader2);

                for (int i = 0; i < sectionTable.Rows.Count; i++) {
                    sectionComboBox.Items.Add(sectionTable.Rows[i]["section_id"] + " " + sectionTable.Rows[i]["course_name"] + " , " + sectionTable.Rows[i]["section"] + " , " + sectionTable.Rows[i]["days"]);
                }

                reader2.Close();
                
                conn.Close();

            }
        }

        private void sectionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {

                string sectionSelectionID = sectionComboBox.Text;
                string[] sectionWords = sectionSelectionID.Split(' ');
                string sectionID = sectionWords[0]; //get the id from the split string.

                conn.Open();

                string query = $"SELECT * FROM section_table WHERE section_id = '{sectionID}';";
                //MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++) {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    //MessageBox.Show("Adding Teacher ID: " + table.Rows[i]["teacher_id"]);
                    courseNameTextBox.Text = table.Rows[i]["course_name"].ToString();
                    sectionTextBox.Text = table.Rows[i]["section"].ToString();
                    daysTextBox.Text = table.Rows[i]["days"].ToString();
                    startTimeTextBox.Text = table.Rows[i]["start_time"].ToString();
                    endTimeTextBox.Text = table.Rows[i]["end_time"].ToString();
                }

                conn.Close();
            }
        }

        private void teacherComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {

                string teacherSelectionID = teacherComboBox.Text;
                string[] words = teacherSelectionID.Split(' ');
                string teacherID = words[0]; //get the id from the split string. 
                string sectionSelectionID = sectionComboBox.Text;
                string[] sectionWords = sectionSelectionID.Split(' ');
                string sectionID = sectionWords[0]; //get the id from the split string.

                DataTable data = new DataTable();


                conn.Open();

                string query = $"SELECT * FROM teacher_table WHERE teacher_id = '{teacherID}';";
                //MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable teacherTable = new DataTable();

                teacherTable.Load(reader);

                string query2 = $"SELECT * FROM section_table WHERE teacher_id = '{teacherID}' AND section_id = '{sectionID}';";
                //MessageBox.Show(query);
                MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                DataTable sectionTable = new DataTable();

                sectionTable.Load(reader2);

                for (int i = 0; i < sectionTable.Rows.Count; i++) {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    //MessageBox.Show("Adding Student ID: " + table.Rows[i]["student_id"]);
                    teacherComboBox.Text = getTeacherIds(sectionTable.Rows[i]["teacher_id"].ToString());
                    courseNameTextBox.Text = sectionTable.Rows[i]["course_name"].ToString();
                    sectionTextBox.Text = sectionTable.Rows[i]["section"].ToString();
                    daysTextBox.Text = sectionTable.Rows[i]["days"].ToString();
                    startTimeTextBox.Text = sectionTable.Rows[i]["start_time"].ToString();
                    endTimeTextBox.Text = sectionTable.Rows[i]["end_time"].ToString();
                }

                reader.Close();
                reader2.Close();

                conn.Close();
            }
        }

        private string getTeacherIds(string current_id) {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT lname, fname, teacher_id FROM teacher_table ORDER BY lname, fname ASC;", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++) {
                    teacherComboBox.Items.Add(table.Rows[i]["teacher_id"] + ", " + table.Rows[i]["fname"] + " " + table.Rows[i]["lname"]);
                }

                reader.Close();

                MySqlCommand current = new MySqlCommand($"SELECT t.teacher_id, t.fname, t.lname, s.teacher_id FROM teacher_table as t, section_table as s WHERE t.teacher_id = s.teacher_id AND t.teacher_id = '{current_id}';", conn);
                MySqlDataReader reader_current = current.ExecuteReader();

                DataTable table_current = new DataTable();

                table_current.Load(reader_current);

                string teacher_id_db = table_current.Rows[0]["teacher_id"] + ", " + table_current.Rows[0]["fname"] + " " + table_current.Rows[0]["lname"];

                reader_current.Close();
                conn.Close();

                return teacher_id_db;
            }

        }

        private void submitButton_Click(object sender, EventArgs e) {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {

                string sectionSelectionID = teacherComboBox.Text;
                string[] words = sectionSelectionID.Split(' ');
                string sectionID = words[0]; //get the id from the split string. 

                conn.Open();

                string query = $"UPDATE `section_table` SET `course_name` = '{courseNameTextBox.Text}', `section` = '{sectionTextBox.Text}', `days` = '{daysTextBox.Text}', `start_time` = '{startTimeTextBox.Text}', `end_time` = '{endTimeTextBox.Text}' WHERE `section_table`.`section_id` = {sectionID};";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++) {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    //MessageBox.Show("Adding Student ID: " + table.Rows[i]["student_id"]);
                    courseNameTextBox.Text = table.Rows[i]["course_name"].ToString();
                    sectionTextBox.Text = table.Rows[i]["section"].ToString();
                    daysTextBox.Text = table.Rows[i]["days"].ToString();
                    startTimeTextBox.Text = table.Rows[i]["start_time"].ToString();
                    endTimeTextBox.Text = table.Rows[i]["end_time"].ToString();
                }

                conn.Close();
            }

            Close();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Close();
        }

        
    }
}
