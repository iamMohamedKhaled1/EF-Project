namespace EF_project
{
    partial class Jacket
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
            dgv_Jacket = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            btn_search = new Button();
            txt_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Jacket).BeginInit();
            SuspendLayout();
            // 
            // dgv_Jacket
            // 
            dgv_Jacket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Jacket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Jacket.Dock = DockStyle.Bottom;
            dgv_Jacket.Location = new Point(0, 129);
            dgv_Jacket.Name = "dgv_Jacket";
            dgv_Jacket.RowHeadersWidth = 51;
            dgv_Jacket.Size = new Size(1081, 469);
            dgv_Jacket.TabIndex = 0;
            dgv_Jacket.RowHeaderMouseDoubleClick += dgv_Jacket_RowHeaderMouseDoubleClick;
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
            button2.TabIndex = 5;
            button2.Text = "ADD TO CART";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(475, 26);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 29);
            btn_search.TabIndex = 10;
            btn_search.Text = "search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(217, 28);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(199, 27);
            txt_search.TabIndex = 9;
            // 
            // Jacket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 598);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgv_Jacket);
            Name = "Jacket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jacket";
            Load += Jacket_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Jacket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Jacket;
        private Button button1;
        private Button button2;
        private Button btn_search;
        private TextBox txt_search;
    }
}