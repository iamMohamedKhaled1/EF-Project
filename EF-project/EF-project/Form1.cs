using EF_project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace EF_project
{
    public partial class Form1 : Form
    {
        EFContext db;
        public Form1()
        {
            InitializeComponent();
            db = new EFContext();
        }

        public void ValidUser(string name, string pass)
        {
            var q1 = db.Users.Where(s => s.Username == name && s.Password == pass).ToList();
            var id = q1.Select(s => s.UserID).SingleOrDefault();

            if (q1.Count() > 0)
            {
                Form2 form2 = new Form2(name, id);
                MessageBox.Show($"WELCOME BACK ({name}) ");
                After_login after_Login = new After_login(name,id);
                after_Login.Show();
                //form2.Show();
            }
            else
            {
                MessageBox.Show("ENTER VALID DATA");
                txt_user.Text = txt_pass.Text ="";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var name = txt_user.Text;
            var pass = txt_pass.Text;
            ValidUser(name, pass);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registeration registeration = new Registeration();
            registeration.Show();
        }
    }
}
