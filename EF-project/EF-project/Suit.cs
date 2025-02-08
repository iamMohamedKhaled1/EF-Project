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
    public partial class Suit : Form
    {
        EFContext db;
        int ssn;
        string name;
        public Suit(string name, int ssn)
        {
            InitializeComponent();
            db = new EFContext();
            this.ssn = ssn;
            this.name = name;
        }

        private void Suit_Load(object sender, EventArgs e)
        {
            var q1 = db.Products.Where(s => s.CategoryId == 5).Select(s => s).ToList();
            dgv_Suit.DataSource = q1;
            dgv_Suit.Columns[0].Visible = false;
            dgv_Suit.Columns[3].Visible = false;
            dgv_Suit.Columns[4].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(name, ssn);
            categoryForm.Show();
            this.Close();
        }
        int id;
        private void dgv_Suit_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_Suit.SelectedRows[0].Cells[0].Value;
            Products p = db.Products.Where(s => s.ProductId == id).SingleOrDefault();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var q1 = db.Favorites.Where(s => s.UserId == ssn).Select(s => s.ProductId).ToList();
            if (id == 0)
            {
                MessageBox.Show("Select item");
            }
            else if (q1.Contains(id))
            {
                MessageBox.Show("Already Add It");
            }
            else
            {
                Favorites favorites = new Favorites()
                {
                    ProductId = id,
                    UserId = ssn,
                };
                db.Favorites.Add(favorites);
                db.SaveChanges();
                MessageBox.Show("ADDED");
                id = 0;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string text = txt_search.Text;
            var q1 = db.Products.Where(s => s.ProductName.StartsWith(text)).ToList();
            dgv_Suit.DataSource = q1;
        }
    }
}
