namespace EF_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_user = new TextBox();
            txt_pass = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txt_user.Location = new Point(351, 207);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(381, 47);
            txt_user.TabIndex = 1;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txt_pass.Location = new Point(351, 289);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(381, 47);
            txt_pass.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.Location = new Point(351, 395);
            button1.Name = "button1";
            button1.Size = new Size(147, 54);
            button1.TabIndex = 3;
            button1.Text = "Log-in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(182, 207);
            label1.Name = "label1";
            label1.Size = new Size(95, 38);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(182, 296);
            label2.Name = "label2";
            label2.Size = new Size(139, 38);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button2.Location = new Point(568, 395);
            button2.Name = "button2";
            button2.Size = new Size(164, 54);
            button2.TabIndex = 6;
            button2.Text = "Sign-Up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(465, 50);
            label3.Name = "label3";
            label3.Size = new Size(173, 41);
            label3.TabIndex = 7;
            label3.Text = "WELCOME ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 598);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_user;
        private TextBox txt_pass;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
    }
}
