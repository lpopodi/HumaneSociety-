using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsDbProject
{
    public class DbSaver
    {
        private SqlConnection connection;
        public SqlConnection Connection { get { return connection; } }

        public DbSaver()
        {
            connection = new SqlConnection("Server=LISA-LAPTOP;Database=HsDb;Integrated Security=true");
        }
    }
}
