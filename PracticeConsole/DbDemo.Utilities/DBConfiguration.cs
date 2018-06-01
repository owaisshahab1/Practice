using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDemo.Utilities
{
    public class DBConfiguration
    {
        private static string connectionString;

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["loginprobdb"].ConnectionString;
            }
        }
    }
}
