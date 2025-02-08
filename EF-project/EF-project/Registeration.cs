using EF_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EF_project
{
    public partial class Registeration : Form
    {
        EFContext db;
        public Registeration()
        {
            InitializeComponent();
            db = new EFContext();
        }
        private bool ValidateForm()
        {
            bool isValid = true;

            if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                errorProvider1.SetError(txt_email, "Not Valid Email");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txt_email, "");
            }

            if (txt_password.Text.Length < 6)
            {
                errorProvider1.SetError(txt_password, "Password Must Contain More than 6 number!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txt_password, "");
            }

            if (string.IsNullOrWhiteSpace(txt_name.Text))
            {
                errorProvider1.SetError(txt_name, "Please Enter your Name  !");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txt_name, "");
            }

            if (string.IsNullOrWhiteSpace(txt_address.Text))
            {
                errorProvider1.SetError(txt_address, "Please Enter your Address  !");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txt_address, "");
            }

            return isValid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Username = txt_name.Text,
                Email = txt_email.Text,
                Age = (int)numirc_age.Value,
                Address = txt_address.Text,
                Password = txt_password.Text,
            };
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Done");
            txt_name.Text = txt_email.Text = txt_address.Text = txt_password.Text = "";
            numirc_age.Value = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var q1 = db.Users.Select(s=>s.Username).ToList();
            if (q1.Contains(txt_name.Text))
            {
                MessageBox.Show("Already have this user");
            }
            else if (ValidateForm())
            {
            User user = new User()
            {
                Username = txt_name.Text,
                Email = txt_email.Text,
                Age = (int)numirc_age.Value,
                Address = txt_address.Text,
                Password = txt_password.Text,
            };
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Done");
            txt_name.Text = txt_email.Text = txt_address.Text = txt_password.Text = "";
            numirc_age.Value = 0;
            Form1 form1 = new Form1();  
            form1.Show();
            this.Close();
            }
            else
            {
                MessageBox.Show("Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
