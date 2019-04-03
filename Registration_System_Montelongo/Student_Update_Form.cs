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

                string queryStudent = "SELECT lname, fname, student_id FROM student_table Order by lname, fname ASC;";
                string querySection = "SELECT section_id, teacher_id, course_name, section, days, start_time, end_time FROM section_table Order by course_name, section ASC;";
                MessageBox.Show(queryStudent);
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
    }
}
