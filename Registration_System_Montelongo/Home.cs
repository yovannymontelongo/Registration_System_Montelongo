﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_System_Montelongo {
    public partial class Home : Form {
        public Home() {
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, EventArgs e) {
            Home homeForm = new Home();
            homeForm.ShowDialog();

        }

        private void exitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void addTeacherButton_Click(object sender, EventArgs e) {
            Teacher_Insert_Form teacherForm = new Teacher_Insert_Form();
            teacherForm.ShowDialog();
        }

        private void registerButton_Click(object sender, EventArgs e) {
            Register_Form regForm = new Register_Form();
            regForm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Section_Insert_Form sectionForm = new Section_Insert_Form();
            sectionForm.ShowDialog();
        }
    }
}