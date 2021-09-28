using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ListaToDo.Helpers
{
    public class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Server=ENDERSSONMENDOZ; Initial catalog=ListaToDo; Integrated security= true; MultipleActiveResultSets=true");
        }
    }
}
