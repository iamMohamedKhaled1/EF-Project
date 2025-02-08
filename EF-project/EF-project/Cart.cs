using EF_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_project
{
    public partial class Cart : Form
    {
        EFContext db;
        int ssn;
        string name;
        public Cart(string name, int ssn)
        {
            InitializeComponent();
            db = new EFContext();
            this.ssn = ssn;
            this.name = name;
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            var q1 = db.Favorites.Where(s => s.UserId == ssn).Select(s => new { s.products.ProductId, s.products.ProductName, s.products.Price }).ToList();
            dgv_cart.DataSource = q1;
            var q2 = q1.Sum(s => s.Price);
            var q3 = q1.Count();
            lb_count.Text = $"Num Of products In Cart : {q3}";
            lb_total.Text = $"Total Cost : {q2} $";
            dgv_cart.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(name, ssn);
            categoryForm.Show();
            this.Close();
        }
        int id;
        private void dgv_cart_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_cart.SelectedRows[0].Cells[0].Value;
            Favorites p = db.Favorites.Where(s => s.ProductId == id).FirstOrDefault();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Select Item");
            }
            else
            {
                Favorites n = db.Favorites.Where(s => s.ProductId == id).FirstOrDefault();
                db.Favorites.Remove(n);
                db.SaveChanges();
                MessageBox.Show("DELETED");
                var q1 = db.Favorites.Where(s => s.UserId == ssn).Select(s => new { s.products.ProductId, s.products.ProductName, s.products.Price }).ToList();
                dgv_cart.DataSource = q1;
                var q2 = q1.Sum(s => s.Price);
                lb_total.Text = $"Total Cost : {q2} $";
                var q3 = q1.Count();
                lb_count.Text = $"Num Of products In Cart : {q3}";
                dgv_cart.Columns[0].Visible = false;
                id = 0;
            }
        }
    }
}
