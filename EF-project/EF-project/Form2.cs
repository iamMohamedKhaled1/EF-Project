using Dapper;
using EF_project.Models;
using Microsoft.Data.SqlClient;
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

    public partial class Form2 : Form
    {
        EFContext db;
        private string name;
        int id;
        SqlConnection con;
        public Form2(string name, int id)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            db = new EFContext();
            con = new SqlConnection("Server = MOHAMEDKHALED\\SQLEXPRESS; Database = EF-Project; Trusted_Connection = True; Trust Server Certificate = True");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            var q1 = con.Query($"select * from Users  where USERID={id}").SingleOrDefault();
            lb_name.Text = $"Welcome Back ({q1.Username})";
            txt_name.Text = q1.Username;
            txt_email.Text = q1.Email;
            txt_password.Text = q1.Password;
            numirc_age.Value = (int)q1.Age;
            txt_addres.Text = q1.Address;
            //var q1 = db.Users.Where(s => s.UserID == id).Select(s => s).SingleOrDefault();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update_profile update_Profile = new Update_profile(id);
            update_Profile.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            After_login after_Login = new After_login(name, id);
            after_Login.Show();
            this.Close();
        }
    }
}
