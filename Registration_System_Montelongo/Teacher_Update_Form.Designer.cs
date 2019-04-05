namespace Registration_System_Montelongo {
    partial class Teacher_Update_Form {
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
            this.teacherComboBox = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.rankTextBox = new System.Windows.Forms.TextBox();
            this.rankLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teacherComboBox
            // 
            this.teacherComboBox.FormattingEnabled = true;
            this.teacherComboBox.Location = new System.Drawing.Point(114, 82);
            this.teacherComboBox.Name = "teacherComboBox";
            this.teacherComboBox.Size = new System.Drawing.Size(160, 21);
            this.teacherComboBox.TabIndex = 42;
            this.teacherComboBox.SelectedIndexChanged += new System.EventHandler(this.studentComboBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(199, 268);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 23);
            this.exitButton.TabIndex = 39;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(22, 268);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(89, 23);
            this.submitButton.TabIndex = 37;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // rankTextBox
            // 
            this.rankTextBox.Location = new System.Drawing.Point(114, 187);
            this.rankTextBox.Name = "rankTextBox";
            this.rankTextBox.Size = new System.Drawing.Size(160, 20);
            this.rankTextBox.TabIndex = 36;
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankLabel.Location = new System.Drawing.Point(35, 188);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(40, 16);
            this.rankLabel.TabIndex = 41;
            this.rankLabel.Text = "Rank";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(114, 161);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(160, 20);
            this.titleTextBox.TabIndex = 34;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(35, 162);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(34, 16);
            this.titleLabel.TabIndex = 40;
            this.titleLabel.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 33);
            this.label3.TabIndex = 38;
            this.label3.Text = "Teacher Update Form";
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Location = new System.Drawing.Point(114, 135);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(160, 20);
            this.lnameTextBox.TabIndex = 33;
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLabel.Location = new System.Drawing.Point(35, 136);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(73, 16);
            this.lnameLabel.TabIndex = 35;
            this.lnameLabel.Text = "Last Name";
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Location = new System.Drawing.Point(114, 109);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(160, 20);
            this.fnameTextBox.TabIndex = 31;
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLabel.Location = new System.Drawing.Point(35, 110);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(73, 16);
            this.fnameLabel.TabIndex = 32;
            this.fnameLabel.Text = "First Name";
            // 
            // Teacher_Update_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 321);
            this.Controls.Add(this.teacherComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.rankTextBox);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(this.fnameLabel);
            this.Name = "Teacher_Update_Form";
            this.Text = "Teacher_Update_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teacherComboBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox rankTextBox;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.Label fnameLabel;
    }
}