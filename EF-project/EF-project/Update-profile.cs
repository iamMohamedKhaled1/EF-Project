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
    public partial class Update_profile : Form
    {
        EFContext db;
        int id;
        public Update_profile(int id)
        {
            InitializeComponent();
            db = new EFContext();
            this.id = id;
        }

        private void Update_profile_Load(object sender, EventArgs e)
        {
            var q1 = db.Users.Where(s => s.UserID == id).Select(s => s).SingleOrDefault();
            txt_name.Text = q1.Username;
            txt_email.Text = q1.Email;
            txt_password.Text = q1.Password;
            numirc_age.Value = (int) q1.Age;
            txt_address.Text = q1.Address;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q1 = db.Users.Where(s => s.UserID == id).SingleOrDefault();
            q1.Username = txt_name.Text;
            q1.Email = txt_email.Text;
            q1.Password = txt_password.Text;
            q1.Address = txt_address.Text;
            q1.Age = (int) numirc_age.Value;
            db.SaveChanges();
            MessageBox.Show("PROFILE-UPDATED");
            txt_address.Text  = txt_email.Text = txt_password.Text = txt_name.Text = "";
            numirc_age.Value = 0;
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
