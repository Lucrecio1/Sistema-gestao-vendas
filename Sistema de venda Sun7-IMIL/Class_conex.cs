using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Sistema_de_venda_Sun7_IMIL
{
    class Class_conex
    {
        public OleDbConnection c1 = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Lucrécio D. Barnsbé\Documents\curso access\Sistema de Venda Sun7 IMIL.mdb");
        public OleDbDataAdapter adp1 = new OleDbDataAdapter();
        public OleDbCommand cm1 = new OleDbCommand();
    }
}
