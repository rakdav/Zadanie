using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class LabForm : Form
    {
        public LabForm()
        {
            InitializeComponent();
        }
        public LabForm(string firstName,string lastName)
        {
            InitializeComponent();
            labelFirstName.Text = firstName;
            labelLastName.Text = lastName;
        }

        private void btPriem_Click(object sender, EventArgs e)
        {
            FormPriemBio priemBio=new FormPriemBio();
            priemBio.Show();
        }
    }
}
