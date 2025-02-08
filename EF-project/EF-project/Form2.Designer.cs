namespace EF_project
{
    partial class Form2
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
            lb_name = new Label();
            txt_name = new TextBox();
            txt_email = new TextBox();
            txt_addres = new TextBox();
            txt_password = new TextBox();
            btn_update = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numirc_age = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numirc_age).BeginInit();
            SuspendLayout();
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(36, 29);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(104, 41);
            lb_name.TabIndex = 0;
            lb_name.Text = "label1";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txt_name.Location = new Point(211, 117);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(299, 47);
            txt_name.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txt_email.Location = new Point(211, 241);
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            txt_email.Size = new Size(299, 47);
            txt_email.TabIndex = 2;
            // 
            // txt_addres
            // 
            txt_addres.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txt_addres.Location = new Point(413, 366);
            txt_addres.Name = "txt_addres";
            txt_addres.ReadOnly = true;
            txt_addres.Size = new Size(271, 47);
            txt_addres.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txt_password.Location = new Point(725, 241);
            txt_password.Name = "txt_password";
            txt_password.ReadOnly = true;
            txt_password.Size = new Size(271, 47);
            txt_password.TabIndex = 5;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(356, 458);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(403, 81);
            btn_update.TabIndex = 7;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(45, 123);
            label1.Name = "label1";
            label1.Size = new Size(95, 38);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(41, 247);
            label2.Name = "label2";
            label2.Size = new Size(89, 38);
            label2.TabIndex = 9;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.Location = new Point(591, 123);
            label3.Name = "label3";
            label3.Size = new Size(69, 38);
            label3.TabIndex = 10;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.Location = new Point(545, 247);
            label4.Name = "label4";
            label4.Size = new Size(139, 38);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label5.Location = new Point(211, 372);
            label5.Name = "label5";
            label5.Size = new Size(121, 38);
            label5.TabIndex = 12;
            label5.Text = "Address";
            // 
            // numirc_age
            // 
            numirc_age.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numirc_age.Location = new Point(725, 117);
            numirc_age.Name = "numirc_age";
            numirc_age.ReadOnly = true;
            numirc_age.Size = new Size(271, 43);
            numirc_age.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 492);
            button1.Name = "button1";
            button1.Size = new Size(154, 81);
            button1.TabIndex = 14;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 598);
            Controls.Add(button1);
            Controls.Add(numirc_age);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_update);
            Controls.Add(txt_password);
            Controls.Add(txt_addres);
            Controls.Add(txt_email);
            Controls.Add(txt_name);
            Controls.Add(lb_name);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numirc_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_name;
        private TextBox txt_name;
        private TextBox txt_email;
        private TextBox txt_addres;
        private TextBox txt_password;
        private Button btn_update;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numirc_age;
        private Button button1;
    }
}