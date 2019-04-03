namespace Registration_System_Montelongo {
    partial class Register_Form {
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
            this.exitButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(208, 174);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 23);
            this.exitButton.TabIndex = 27;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(19, 174);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(89, 23);
            this.submitButton.TabIndex = 25;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(44, 114);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(69, 16);
            this.titleLabel.TabIndex = 28;
            this.titleLabel.Text = "Section ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 33);
            this.label3.TabIndex = 26;
            this.label3.Text = "Register Form";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLabel.Location = new System.Drawing.Point(44, 88);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(69, 16);
            this.lnameLabel.TabIndex = 23;
            this.lnameLabel.Text = "Student ID";
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(153, 87);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(121, 21);
            this.studentComboBox.TabIndex = 29;
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(153, 113);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.sectionComboBox.TabIndex = 30;
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 219);
            this.Controls.Add(this.sectionComboBox);
            this.Controls.Add(this.studentComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnameLabel);
            this.Name = "Register_Form";
            this.Text = "Register_Form";
            this.Load += new System.EventHandler(this.Register_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.ComboBox sectionComboBox;
    }
}