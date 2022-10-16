using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoNro3
{
    internal class ConexionSql
    {
        private static readonly string connectionString = "Data Source=.;Initial Catalog=Base;Integrated Security=True";

        public static DataSet GetDataSet(List<Table> tables, string database)
        {
            DataSet dataSet = new DataSet();

            try
            {
                for (int i = 0; i < tables.Count; i++)
                {
                    new SqlDataAdapter(tables[i].ComandoSql, connectionString.Replace("Base", database)).Fill(dataSet, tables[i].NombreTabla);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return dataSet;
        }

        public static DataTable GetDataTable(string comandoSql, string database)
        {
            DataTable dataTable = new DataTable();

            try
            {
                new SqlDataAdapter(comandoSql, connectionString.Replace("Base", database)).Fill(dataTable);
            }
            catch (Exception)
            {
                return null;
            }

            return dataTable;
        }
    }
}
