namespace Registration_System_Montelongo {
    partial class Student_Insert_Form {
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
            this.fnameLabel = new System.Windows.Forms.Label();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.degreeTextBox = new System.Windows.Forms.TextBox();
            this.degreeLabel = new System.Windows.Forms.Label();
            this.majorTextBox = new System.Windows.Forms.TextBox();
            this.majorLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLabel.Location = new System.Drawing.Point(36, 103);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(73, 16);
            this.fnameLabel.TabIndex = 0;
            this.fnameLabel.Text = "First Name";
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Location = new System.Drawing.Point(115, 102);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(160, 20);
            this.fnameTextBox.TabIndex = 0;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Location = new System.Drawing.Point(115, 128);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(160, 20);
            this.lnameTextBox.TabIndex = 1;
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLabel.Location = new System.Drawing.Point(36, 129);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(73, 16);
            this.lnameLabel.TabIndex = 2;
            this.lnameLabel.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Insert Form";
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.Location = new System.Drawing.Point(115, 180);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.Size = new System.Drawing.Size(160, 20);
            this.degreeTextBox.TabIndex = 3;
            // 
            // degreeLabel
            // 
            this.degreeLabel.AutoSize = true;
            this.degreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeLabel.Location = new System.Drawing.Point(36, 181);
            this.degreeLabel.Name = "degreeLabel";
            this.degreeLabel.Size = new System.Drawing.Size(54, 16);
            this.degreeLabel.TabIndex = 7;
            this.degreeLabel.Text = "Degree";
            // 
            // majorTextBox
            // 
            this.majorTextBox.Location = new System.Drawing.Point(115, 154);
            this.majorTextBox.Name = "majorTextBox";
            this.majorTextBox.Size = new System.Drawing.Size(160, 20);
            this.majorTextBox.TabIndex = 2;
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorLabel.Location = new System.Drawing.Point(36, 155);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(42, 16);
            this.majorLabel.TabIndex = 5;
            this.majorLabel.Text = "Major";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(23, 280);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(89, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(200, 280);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Student_Insert_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 321);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.degreeTextBox);
            this.Controls.Add(this.degreeLabel);
            this.Controls.Add(this.majorTextBox);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(this.fnameLabel);
            this.Name = "Student_Insert_Form";
            this.Text = "Student Insert Form";
            this.Load += new System.EventHandler(this.Student_Insert_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox degreeTextBox;
        private System.Windows.Forms.Label degreeLabel;
        private System.Windows.Forms.TextBox majorTextBox;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
    }
}

