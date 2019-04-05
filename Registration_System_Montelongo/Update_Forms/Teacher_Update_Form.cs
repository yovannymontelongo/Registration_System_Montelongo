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
    public partial class Teacher_Update_Form : Form {
        public Teacher_Update_Form() {
            InitializeComponent();

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {
                conn.Open();

                string query = "SELECT lname, fname, teacher_id, title, rank FROM teacher_table Order by lname, fname ASC;";
                //MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable tableTeacher = new DataTable();

                tableTeacher.Load(reader);

                for (int i = 0; i < tableTeacher.Rows.Count; i++) {
                    teacherComboBox.Items.Add(tableTeacher.Rows[i]["teacher_id"] + " " + tableTeacher.Rows[i]["lname"] + " , " + tableTeacher.Rows[i]["fname"]);
                }

                reader.Close();
                conn.Close();

            }
        }

        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {

                string teacherSelectionID = teacherComboBox.Text;
                string[] words = teacherSelectionID.Split(' ');
                string teacherID = words[0]; //get the id from the split string. 


                conn.Open();

                string query = $"SELECT * FROM teacher_table WHERE teacher_id = '{teacherID}';";
                //MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++) {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    //MessageBox.Show("Adding Teacher ID: " + table.Rows[i]["teacher_id"]);
                    fnameTextBox.Text = table.Rows[i]["fname"].ToString();
                    lnameTextBox.Text = table.Rows[i]["lname"].ToString();
                    titleTextBox.Text = table.Rows[i]["title"].ToString();
                    rankTextBox.Text = table.Rows[i]["rank"].ToString();
                }


                conn.Close();
            }
        }

        private void submitButton_Click(object sender, EventArgs e) {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {

                string teacherSelectionID = teacherComboBox.Text;
                string[] words = teacherSelectionID.Split(' ');
                string teacherID = words[0]; //get the id from the split string. 

                conn.Open();

                string query = $"UPDATE `teacher_table` SET `fname` = '{fnameTextBox.Text}', `lname` = '{lnameTextBox.Text}', `title` = '{titleTextBox.Text}', `rank` = '{rankTextBox.Text}' WHERE `teacher_table`.`teacher_id` = {teacherID};";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++) {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    //MessageBox.Show("Adding Student ID: " + table.Rows[i]["student_id"]);
                    fnameTextBox.Text = table.Rows[i]["fname"].ToString();
                    lnameTextBox.Text = table.Rows[i]["lname"].ToString();
                    titleTextBox.Text = table.Rows[i]["title"].ToString();
                    rankTextBox.Text = table.Rows[i]["rank"].ToString();
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
