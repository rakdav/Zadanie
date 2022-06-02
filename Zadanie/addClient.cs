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
    public partial class addClient : Form
    {
        public addClient()
        {
            InitializeComponent();
            using (ModelDB db=new ModelDB())
            {
                List<Company> list=db.Company.ToList();
                foreach (Company company in list)
                    comboBox2.Items.Add(company.name);
            }
        }
    }
}
