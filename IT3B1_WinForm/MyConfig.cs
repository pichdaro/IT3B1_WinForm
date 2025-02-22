using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace IT3B1_WinForm
{
    internal class MyConfig
    {
        public static User activeUser;
        //Create logger object to log error/info
        public static Logger logger = LogManager.GetCurrentClassLogger();

        //Ms.Access Create connection
        public static OleDbConnection AccCon = new
                OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Application.StartupPath +
            "myDB.accdb;Jet OLEDB:Database Password=adm@123;");

        //SQLServer Connection
        public static SqlConnection SqlCon = new SqlConnection(
            "Data Source=localhost;" +
            "Initial Catalog=IT3B1;" +
            "User ID=it3b1_usr;Password=adm@123;" +
            "TrustServerCertificate=True;");
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
    //Creating Enumeration
    public enum Sex { Male , Female }
    public enum Shift { Morning, Afernoon, Evening}
    public enum Address { Phnom_Penh, Province}
    
    //Creating enum UserRoles for user which include SysAdmin, Admin and User.
    public enum UserRoles { SuperAdmin, Admin, User };
}
