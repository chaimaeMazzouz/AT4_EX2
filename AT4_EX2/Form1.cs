using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AT4_EX2
{
    public partial class Form1 : Form
    {
        //Declaration des Childs 
        Employes EmployesForm;
        Products ProductsForm;
        Customers CustomersForm;
        public Form1()
        {
            InitializeComponent();
        }
        void Changer_Form(Form NewForm)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            NewForm.MdiParent = this;
            NewForm.Dock = DockStyle.Fill;
            NewForm.Show();
        }

        private void employesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployesForm = new Employes();
            Changer_Form(EmployesForm);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm = new Products();
            Changer_Form(ProductsForm);
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm = new Customers();
            Changer_Form(CustomersForm);
        }
    }
}
