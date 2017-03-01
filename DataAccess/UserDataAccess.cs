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
        public void CreateDaUser(DataAccessUser customer)
        {
            SqlConnection lConnection = new SqlConnection(_connection);
            SqlCommand cmd = new SqlCommand("SP_CreateNewCustomer", lConnection);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                lConnection.Open();
                cmd.Parameters.AddWithValue("@UserName", customer.UserName);
                cmd.Parameters.AddWithValue("@Password", customer.Password);
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Birthdate", customer.Birthdate);
                cmd.Parameters.AddWithValue("@City", customer.City);
                cmd.Parameters.AddWithValue("@State", customer.State);
                cmd.Parameters.AddWithValue("@Address", customer.StreetAddress);
                cmd.Parameters.AddWithValue("@Zipcode", customer.Zipcode);
                cmd.Parameters.AddWithValue("@Question", customer.SecurityQuestion);
                cmd.Parameters.AddWithValue("@Answer", customer.SecurityAnswer);
                cmd.Parameters.AddWithValue("@Arrival", customer.Arrival);
                cmd.Parameters.AddWithValue("@Departure", customer.Depature);

            }
            catch (SqlException error)
            {

                string _ErrorLogFileLocation = @"C:\Users\admin2\Desktop\\ErrorLog.txt";
                using (StreamWriter lwriter = new StreamWriter(_ErrorLogFileLocation, true))
                {
                    lwriter.WriteLine(error.Message);

                }
            }
            finally
            {
                lConnection.Close();
            }



        }
    }
}
