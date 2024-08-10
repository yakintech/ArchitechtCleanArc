using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Models
{
    public class DbHelper
    {

        private static DbHelper _dbHelper;

        private DbHelper()
        {
            
        }
        private DbHelper(string connectionString)
        {
            ConnectionString = connectionString;
            
        }


        public static DbHelper GetInstance(string connectionString)
        {
            if(_dbHelper == null)
            {
                _dbHelper = new DbHelper(connectionString);
            }
            return _dbHelper;
        }

        public string Status { get; set; }
        public string ConnectionString { get; set; }

    }
}
