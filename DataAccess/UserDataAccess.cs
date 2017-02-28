using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.DataAccessObjects;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class UserDataAccess
    {
        static List<DataAccessUser> _UserList = new List<DataAccessUser>();
        DataAccessUser user = new DataAccessUser();
          string _connection = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
          string _FileLocation = "C:/Users/Admin2/Desktop/important3.txt";
    }
}
