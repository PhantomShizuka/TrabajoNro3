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
    public partial class EjerPro3 : Form
    {
        private string database = "Northwind";
        private DataSet ds;
        private CurrencyManager cm;

        public EjerPro3()
        {
            InitializeComponent();
        }

        private void EjerPro3_Load(object sender, EventArgs e)
        {
            List<Table> tables = new List<Table>
            {
                new Table("select EmployeeID, LastName, FirstName, HireDate from Employees", "Empleado"),
                new Table("select OrderID, CompanyName, EmployeeID, OrderDate, Freight from Orders O join Customers C on O.CustomerID = C.CustomerID", "Orden"),
                new Table("select * from [Order Details]", "DetalleOrden"),
            };

            ds = ConexionSql.GetDataSet(tables, database);

            cm = (CurrencyManager)this.BindingContext[ds.Tables["Empleado"]];

            LblRegistro.Text = "Registro " + (cm.Position + 1) + " de " + cm.Count;
            TxtNombre.DataBindings.Add("text", ds.Tables["Empleado"], "FirstName");
            TxtApellidos.DataBindings.Add("text", ds.Tables["Empleado"], "LastName");
            TxtFecha.DataBindings.Add("text", ds.Tables["Empleado"], "HireDate");
            TxtTotalVenta.Text = TotalVentas(cm.Position);

            DgvOrdenes.DataSource = ds.Tables["Orden"];
            DgvDetalleOrdenes.DataSource = ds.Tables["DetalleOrden"];
        }

        private string TotalVentas(int indexrow)
        {
            double total = 0;

            DataTable dt = ds.Tables["Orden"];

            dt.DefaultView.RowFilter = "EmployeeID = '" + ds.Tables["Empleado"].Rows[indexrow][0] + "'";

            foreach (DataRow row in dt.DefaultView.ToTable().Rows)
            {
                total += Convert.ToDouble(row["Freight"].ToString());
            }

            return total.ToString("f2");
        }

        private void DgvOrdenes_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            try
            {
                ds.Tables["DetalleOrden"].DefaultView.RowFilter = "OrderID = '" + DgvOrdenes.Rows[e.Cell.RowIndex].Cells[0].Value + "'";
            }
            catch (Exception)
            {
                ds.Tables["DetalleOrden"].DefaultView.RowFilter = "OrderID = '" + DgvOrdenes.Rows[0].Cells[0].Value + "'";
            }
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            cm.Position = 0;
            TxtTotalVenta.Text = TotalVentas(cm.Position);
            LblRegistro.Text = "Registro " + (cm.Position + 1) + " de " + cm.Count;
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            if(cm.Position > 0)
            {
                --cm.Position;
                TxtTotalVenta.Text = TotalVentas(cm.Position);
            }

            LblRegistro.Text = "Registro " + (cm.Position + 1) + " de " + cm.Count;
        }

        private void BtnAdelante_Click(object sender, EventArgs e)
        {
            if (cm.Position < cm.Count - 1)
            {
                ++cm.Position;
                TxtTotalVenta.Text = TotalVentas(cm.Position);
            }

            LblRegistro.Text = "Registro " + (cm.Position + 1) + " de " + cm.Count;
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            cm.Position = cm.Count - 1;
            TxtTotalVenta.Text = TotalVentas(cm.Position);
            LblRegistro.Text = "Registro " + (cm.Position + 1) + " de " + cm.Count;
        }
    }
}
