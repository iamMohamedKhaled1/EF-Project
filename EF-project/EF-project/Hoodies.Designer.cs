namespace EF_project
{
    partial class Hoodies
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
            dgv_hoodies = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            txt_search = new TextBox();
            btn_search = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_hoodies).BeginInit();
            SuspendLayout();
            // 
            // dgv_hoodies
            // 
            dgv_hoodies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_hoodies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_hoodies.Dock = DockStyle.Bottom;
            dgv_hoodies.Location = new Point(0, 125);
            dgv_hoodies.Name = "dgv_hoodies";
            dgv_hoodies.RowHeadersWidth = 51;
            dgv_hoodies.Size = new Size(1081, 473);
            dgv_hoodies.TabIndex = 0;
            dgv_hoodies.RowHeaderMouseDoubleClick += dgv_hoodies_RowHeaderMouseDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(121, 62);
            button1.TabIndex = 3;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(808, 12);
            button2.Name = "button2";
            button2.Size = new Size(261, 74);
            button2.TabIndex = 6;
            button2.Text = "ADD TO CART";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(183, 20);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(199, 27);
            txt_search.TabIndex = 7;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(432, 20);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 29);
            btn_search.TabIndex = 8;
            btn_search.Text = "search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // Hoodies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 598);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgv_hoodies);
            Name = "Hoodies";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hoodies";
            Load += Hoodies_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_hoodies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_hoodies;
        private Button button1;
        private Button button2;
        private TextBox txt_search;
        private Button btn_search;
    }
}