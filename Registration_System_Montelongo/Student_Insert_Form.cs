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
    public partial class Student_Insert_Form : Form {
        public Student_Insert_Form() {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e) {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root")) {

                string fname = fnameTextBox.Text;
                string lname = lnameTextBox.Text;
                string major = majorTextBox.Text;
                string degree = degreeTextBox.Text;

                conn.Open();

                string query = $"INSERT INTO `student_table` (`student_id`, `fname`, `lname`, `major`, `degree`) VALUES (NULL, '{fname}', '{lname}', '{major}', '{degree}');";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int numRowsAffected = cmd.ExecuteNonQuery();
                long lastInserted = cmd.LastInsertedId;

                if(numRowsAffected >= 1) {
                    MessageBox.Show("Rows: " + numRowsAffected + ". ID entered: " + lastInserted);
                } else {
                    MessageBox.Show("Error in insert query");
                }
                
                conn.Close();
            }
            
            this.Close();

        }

        private void exitButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void Student_Insert_Form_Load(object sender, EventArgs e) {

        }
    }
}
