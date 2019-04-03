namespace Registration_System_Montelongo {
    partial class Home {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addSectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Form";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(244, 98);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 1;
            this.addStudentButton.Text = "Add";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Location = new System.Drawing.Point(244, 140);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.addTeacherButton.TabIndex = 2;
            this.addTeacherButton.Text = "Add";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(244, 226);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Teacher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Register for Class";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(191, 312);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Add Section";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // addSectionButton
            // 
            this.addSectionButton.Location = new System.Drawing.Point(244, 182);
            this.addSectionButton.Name = "addSectionButton";
            this.addSectionButton.Size = new System.Drawing.Size(75, 23);
            this.addSectionButton.TabIndex = 8;
            this.addSectionButton.Text = "Add";
            this.addSectionButton.UseVisualStyleBackColor = true;
            this.addSectionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 382);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addSectionButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.addTeacherButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addSectionButton;
    }
}