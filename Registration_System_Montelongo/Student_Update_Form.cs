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
    
    public partial class Student_Update_Form : Form {
        
        public Student_Update_Form() {
            InitializeComponent();

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {
                conn.Open();

                string query = "SELECT lname, fname, student_id, major, degree FROM student_table Order by lname, fname ASC;";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable tableStudent = new DataTable();

                tableStudent.Load(reader);

                for (int i = 0; i < tableStudent.Rows.Count; i++) {
                    studentComboBox.Items.Add(tableStudent.Rows[i]["student_id"] + " " + tableStudent.Rows[i]["lname"] + "," + tableStudent.Rows[i]["fname"]);
                }

                reader.Close();
                conn.Close();

            }

        }

        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {

                string studentselectionid = studentComboBox.Text;
                string[] words = studentselectionid.Split(' ');
                string student_id_num = words[0]; //get the id from the split string. 


                conn.Open();

                string query = $"SELECT * FROM student_table WHERE student_id = '{student_id_num}';";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++) {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    MessageBox.Show("Adding Student ID: " + table.Rows[i]["student_id"]);
                    fnameTextBox.Text = table.Rows[i]["fname"].ToString();
                    lnameTextBox.Text = table.Rows[i]["lname"].ToString();
                    majorTextBox.Text = table.Rows[i]["major"].ToString();
                    degreeTextBox.Text = table.Rows[i]["degree"].ToString();
                }


                conn.Close();
            }

        }

        private void submitButton_Click(object sender, EventArgs e) {

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {

                string studentselectionid = studentComboBox.Text;
                string[] words = studentselectionid.Split(' ');
                string studentID = words[0]; //get the id from the split string. 

                conn.Open();

                string query = $"UPDATE `student_table` SET `fname` = '{fnameTextBox.Text}', `lname` = '{lnameTextBox.Text}', `major` = '{majorTextBox.Text}', `degree` = '{degreeTextBox.Text}' WHERE `student_table`.`student_id` = {studentID};";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++) {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    MessageBox.Show("Adding Student ID: " + table.Rows[i]["student_id"]);
                    fnameTextBox.Text = table.Rows[i]["fname"].ToString();
                    lnameTextBox.Text = table.Rows[i]["lname"].ToString();
                    majorTextBox.Text = table.Rows[i]["major"].ToString();
                    degreeTextBox.Text = table.Rows[i]["degree"].ToString();
                }

                conn.Close();
            }

            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
