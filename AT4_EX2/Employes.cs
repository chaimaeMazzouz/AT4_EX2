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
    public partial class Employes : Form
    {
        public Employes()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source =DESKTOP-7TC9CTO\SQLEXPRESS;database=ComptoirAnglais;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader read;
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, City, Country FROM Employees";
            try
            {
                dataGridView1.Rows.Clear();
                con.Open();
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    dataGridView1.Rows.Add(read["EmployeeID"], read["LastName"], read["FirstName"], read["Title"], read["City"], read["Country"]);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Erreur levée :" + exp.Message);
            }
            finally
            {
                read.Close();
                con.Close();
            }
        }
    }
}
