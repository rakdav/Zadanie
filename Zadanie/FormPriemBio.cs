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
    public partial class FormPriemBio : Form
    {
        public FormPriemBio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addClient addc=new addClient();
            addc.Show();
            //if(add.ShowDialog()==DialogResult.OK)
            //{

            //}
        }
    }
}
