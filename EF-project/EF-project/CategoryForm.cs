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

    public partial class CategoryForm : Form
    {
        int id;
        string name;
        public CategoryForm(string name,int id)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hoodies hoodies = new Hoodies(name, id);
            hoodies.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            T_Shirts t = new T_Shirts(name, id);
            t.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Jeans jeans = new Jeans(name,id);
            jeans.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Jacket jacket = new Jacket(name, id);
            jacket.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Suit suit = new Suit(name, id);
            suit.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(name, id);
            cart.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            After_login after_Login= new After_login(name,id);
            after_Login.Show();
            this.Close();
        }
    }
}
