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
    public partial class After_login : Form
    {
        string name;
        int id;
        public After_login(string name, int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(name, id);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(name,id);
            categoryForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
