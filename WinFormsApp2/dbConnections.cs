using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meraki_POS_System
{
    internal class dbConnections
    {
        public string getConnection()
        {
            string dbConnect = ("Data Source = LIYAN\\SQLEXPRESS; Initial Catalog = Finals; Integrated Security = True");
            return dbConnect;
               

        }
    }
}
