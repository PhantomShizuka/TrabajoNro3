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
    public partial class EjerPro2 : Form
    {
        private string database = "Northwind";
        private string EmployeeID;
        private DataSet ds;

        public EjerPro2()
        {
            InitializeComponent();
        }

        private void EjerPro2_Load(object sender, EventArgs e)
        {
            List<Table> tables = new List<Table>
            {
                new Table("select EmployeeID, LastName, FirstName from Employees", "Empleado"),
                new Table("select OrderID, CustomerID, EmployeeID, OrderDate from Orders", "Orden"),
                new Table("select * from [Order Details]", "DetalleOrden"),
                new Table("select distinct Year(OrderDate) as Year from Orders Order by Year", "Year")
            };

            ds = ConexionSql.GetDataSet(tables, database);

            EmployeeID = ds.Tables["Empleado"].Rows[0][0].ToString();

            CbxYear.ValueMember = "Year";
            CbxYear.DisplayMember = "Year";
            CbxYear.DataSource = ds.Tables["Year"];

            DgvEmpleado.DataSource = ds.Tables["Empleado"];
            DgvOrden.DataSource = ds.Tables["Orden"];
            DgvDetalleOrden.DataSource = ds.Tables["DetalleOrden"];
        }

        private void CbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds.Tables["Orden"].DefaultView.RowFilter = "OrderDate >= #1/1/" + CbxYear.Text + "# AND  OrderDate <=  #12/31/" + CbxYear.Text + "# and " +
                                                       "EmployeeID = '" + EmployeeID + "'";
        }

        private void DgvEmpleado_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeID = ds.Tables["Empleado"].Rows[e.RowIndex][0].ToString();

            ds.Tables["Orden"].DefaultView.RowFilter = "OrderDate >= #1/1/" + CbxYear.Text + "# AND  OrderDate <=  #12/31/" + CbxYear.Text + "# and " +
                                                       "EmployeeID = '" + EmployeeID + "'";
        }

        private void DgvOrden_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            try
            {
                ds.Tables["DetalleOrden"].DefaultView.RowFilter = "OrderID = " + DgvOrden.Rows[e.Cell.RowIndex].Cells[0].Value;
            }
            catch (Exception)
            {

                ds.Tables["DetalleOrden"].DefaultView.RowFilter = "OrderID = " + DgvOrden.Rows[0].Cells[0].Value;
            }
        }
    }
}
