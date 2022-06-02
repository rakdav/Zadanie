using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadanie.Model;

namespace Zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBrowse.Checked)
            {
                textPassword.UseSystemPasswordChar=false;
            }
            else
            {
                textPassword.UseSystemPasswordChar=true;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            using (ModelDB db=new ModelDB())
            {
                if (textLogin.Text.Length != 0 && textPassword.Text.Length != 0)
                {
                    Administrator admin = db.Administrator.
                        Where(p => p.login.Equals(textLogin.Text)
                        & p.password.Equals(textPassword.Text)).FirstOrDefault();
                    Laborants laborants = db.Laborants.
                        Where(p => p.login.Equals(textLogin.Text)
                        & p.password.Equals(textPassword.Text)).FirstOrDefault();
                    buhgalters Buhgalters = db.buhgalters.
                       Where(p => p.login.Equals(textLogin.Text)
                       & p.password.Equals(textPassword.Text)).FirstOrDefault();
                    if (admin != null)
                    {
                        AdminForm form = new AdminForm(admin.login);
                        form.Show();
                        this.Hide();
                    }
                    else if (laborants!=null)
                    {
                        if(laborants.isIsled==false)
                        {
                            LabForm labForm = new LabForm(laborants.FirstName,laborants.LastName);
                            labForm.Show();
                            this.Hide();
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Не правильный логин или пароль");
                    }
                }
                else
                {
                    MessageBox.Show("Введите логин или пароль");
                }
            }
        }
    }
}
