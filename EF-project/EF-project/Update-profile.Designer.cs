namespace EF_project
{
    partial class Update_profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_name = new TextBox();
            txt_email = new TextBox();
            txt_address = new TextBox();
            txt_password = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numirc_age = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numirc_age).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txt_name.Location = new Point(203, 113);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(292, 47);
            txt_name.TabIndex = 0;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txt_email.Location = new Point(203, 256);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(292, 47);
            txt_email.TabIndex = 1;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txt_address.Location = new Point(402, 390);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(307, 47);
            txt_address.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txt_password.Location = new Point(737, 256);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(292, 47);
            txt_password.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(370, 470);
            button1.Name = "button1";
            button1.Size = new Size(339, 71);
            button1.TabIndex = 5;
            button1.Text = "UPDATE-PROFILE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(32, 119);
            label1.Name = "label1";
            label1.Size = new Size(95, 38);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(32, 262);
            label2.Name = "label2";
            label2.Size = new Size(89, 38);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.Location = new Point(218, 396);
            label3.Name = "label3";
            label3.Size = new Size(121, 38);
            label3.TabIndex = 8;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.Location = new Point(596, 119);
            label4.Name = "label4";
            label4.Size = new Size(69, 38);
            label4.TabIndex = 9;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label5.Location = new Point(570, 262);
            label5.Name = "label5";
            label5.Size = new Size(139, 38);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // numirc_age
            // 
            numirc_age.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numirc_age.Location = new Point(737, 117);
            numirc_age.Name = "numirc_age";
            numirc_age.Size = new Size(292, 43);
            numirc_age.TabIndex = 14;
            // 
            // Update_profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 598);
            Controls.Add(numirc_age);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txt_password);
            Controls.Add(txt_address);
            Controls.Add(txt_email);
            Controls.Add(txt_name);
            Name = "Update_profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update_profile";
            Load += Update_profile_Load;
            ((System.ComponentModel.ISupportInitialize)numirc_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_email;
        private TextBox txt_address;
        private TextBox txt_password;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numirc_age;
    }
}