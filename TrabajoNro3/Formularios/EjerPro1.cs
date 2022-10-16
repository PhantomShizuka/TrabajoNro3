using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoNro3
{
    public partial class EjerPro1 : Form
    {
        private string database = "Northwind";
        private DataSet ds;

        public EjerPro1()
        {
            InitializeComponent();           
        }

        private void EjerPro1_Load(object sender, EventArgs e)
        {
            List<Table> tables = new List<Table>
            {
                new Table("select CustomerID, CompanyName, City, Country, Phone from Customers", "Maestro"),
                new Table("select OrderID, CustomerID, EmployeeID, OrderDate, Freight from Orders", "Detalle")
            };

            ds = ConexionSql.GetDataSet(tables, database);

            DgvMaestro.DataSource = ds.Tables["Maestro"];
            DgvDetalle.DataSource = ds.Tables["Detalle"];
        }

        private void DgvMaestro_RowEnter(object sender, DataGridViewCellEventArgs e)
        {       
            ds.Tables["Detalle"].DefaultView.RowFilter = "CustomerID = '" + ds.Tables["Maestro"].Rows[e.RowIndex][0] + "'";
        }
    }
}
