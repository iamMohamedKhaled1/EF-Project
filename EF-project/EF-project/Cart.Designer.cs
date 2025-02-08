namespace EF_project
{
    partial class Cart
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
            dgv_cart = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            lb_total = new Label();
            lb_count = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_cart).BeginInit();
            SuspendLayout();
            // 
            // dgv_cart
            // 
            dgv_cart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cart.Dock = DockStyle.Bottom;
            dgv_cart.Location = new Point(0, 172);
            dgv_cart.Name = "dgv_cart";
            dgv_cart.RowHeadersWidth = 51;
            dgv_cart.Size = new Size(1081, 426);
            dgv_cart.TabIndex = 0;
            dgv_cart.RowHeaderMouseDoubleClick += dgv_cart_RowHeaderMouseDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(121, 62);
            button1.TabIndex = 4;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(763, 12);
            button2.Name = "button2";
            button2.Size = new Size(306, 73);
            button2.TabIndex = 5;
            button2.Text = "DELETE FROM CART";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_total.Location = new Point(294, 27);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(96, 38);
            lb_total.TabIndex = 6;
            lb_total.Text = "label1";
            // 
            // lb_count
            // 
            lb_count.AutoSize = true;
            lb_count.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_count.Location = new Point(294, 107);
            lb_count.Name = "lb_count";
            lb_count.Size = new Size(96, 38);
            lb_count.TabIndex = 7;
            lb_count.Text = "label1";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 598);
            Controls.Add(lb_count);
            Controls.Add(lb_total);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgv_cart);
            Name = "Cart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_cart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_cart;
        private Button button1;
        private Button button2;
        private Label lb_total;
        private Label lb_count;
    }
}