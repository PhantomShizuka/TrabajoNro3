using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoNro3
{
    internal class Table
    {
        public string ComandoSql;
        public string NombreTabla;

        public Table(string comandoSql, string nombreTabla)
        {
            ComandoSql = comandoSql;
            NombreTabla = nombreTabla;
        }
    }
}
