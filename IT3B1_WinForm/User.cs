using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT3B1_WinForm
{
    internal class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password_Salt { get; set; }
        public string Password_Hash { get; set; }
        public string Email { get; set; }
        public UserRoles Role { get; set; }
        public byte[] Avata { get; set; }

        public static void FetchData(ListView lv)
        {
            try
            {
                //Open connection
                MyConfig.SqlCon.Open();

                //Create SQL Command
                SqlCommand cmd = MyConfig.SqlCon.CreateCommand();
                cmd.CommandText = "SELECT * FROM [User] ";

                // cmd.ExecuteNonQuery() will return a number of affected records.
                SqlDataReader reader = cmd.ExecuteReader();
                lv.Columns.Clear();
                lv.Items.Clear();
                lv.Columns.Add("ID", 200);
                lv.Columns.Add("Username", 300);
                lv.Columns.Add("Email", 500);
                lv.Columns.Add("Role", 300);
                lv.FullRowSelect = true;
                lv.View = View.Details;

                while (reader.Read())
                {
                    User usr = new User();
                    usr.ID = (int)reader[0];
                    usr.Username = (string)reader[1];
                    usr.Password_Salt = (string)reader[2];
                    usr.Password_Hash = (string)reader[3];
                    usr.Email = (string)reader[4];
                    usr.Role = (UserRoles)reader[5];

                    string[] usrArray = new string[5];
                    usrArray[0] = usr.ID.ToString();
                    usrArray[1] = usr.Username;
                    usrArray[2] = usr.Email;
                    usrArray[3] = usr.Role.ToString();

                    ListViewItem usrItem = new ListViewItem(usrArray);
                    usrItem.Tag = usr;
                    lv.Items.Add(usrItem);
                }
            }
            catch (Exception ex)
            {
                // Display error message to user
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close active connection
                if (MyConfig.SqlCon.State == ConnectionState.Open)
                    MyConfig.SqlCon.Close();
            }
        }
        private static bool IsExist(string userName)
        {
            try
            {
                MyConfig.SqlCon.Open();
                SqlCommand cmd = MyConfig.SqlCon.CreateCommand();
                cmd.CommandText = "SELECT [Username] FROM [User]" +
                                        " WHERE [Username]=@username";

                cmd.Parameters.AddWithValue("username", userName);
                SqlDataReader reader = cmd.ExecuteReader();

                //Check if the data reader has row
                if (reader.HasRows)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (MyConfig.SqlCon.State == ConnectionState.Open)
                    MyConfig.SqlCon.Close();
            }
        }

        public static bool Add(string uName, string rawPassword,
                                    string email, int role)
        {
            //Check if user exist
            if (IsExist(uName))
            {
                MessageBox.Show("User is already existed!");
                return false;
            }

            //Add new user
            try
            {
                //Open Connection
                MyConfig.SqlCon.Open();

                //Creating password salt and hash using BCrypt.Net
                string pwd_salt = BCrypt.Net.BCrypt.GenerateSalt();
                string pwd_hash = BCrypt.Net.BCrypt.HashPassword(rawPassword, pwd_salt);

                //Create SqlCommand
                SqlCommand cmd = MyConfig.SqlCon.CreateCommand();
                cmd.CommandText = "INSERT INTO [User]([Username], " +
                    "[Password_Salt], [Password_Hash], [Email], [Role])" +
                    " VALUES(@user, @pwd_salt, @pwd_hash, @email, @role);";

                cmd.Parameters.AddWithValue("user", uName);
                cmd.Parameters.AddWithValue("pwd_salt", pwd_salt);
                cmd.Parameters.AddWithValue("pwd_hash", pwd_hash);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("role", role);

                // cmd.ExecuteNonQuery() will return a number of affected records.
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                // Display error message to user
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Close active connection
                if (MyConfig.SqlCon.State == ConnectionState.Open)
                    MyConfig.SqlCon.Close();
            }
        }
        public static bool Login(string Username, string Password)
        {
            try
            {
                MyConfig.SqlCon.Open();
                SqlCommand cmd = MyConfig.SqlCon.CreateCommand();
                cmd.CommandText = "SELECT * FROM [User] WHERE " +
                    "[Username]=@username;";
                cmd.Parameters.AddWithValue("username", Username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    User objUser = new User();
                    objUser.ID = (int)reader.GetValue(0);
                    objUser.Username = reader.GetValue(1).ToString();
                    objUser.Password_Salt = reader.GetValue(2).ToString();
                    objUser.Password_Hash = reader.GetValue(3).ToString();
                    objUser.Email = reader.GetValue(4).ToString();

                    //Converting user's role from database into enum of UserRoles
                    objUser.Role = (UserRoles)Enum.Parse(typeof(UserRoles), reader.GetValue(5).ToString());

                    if(reader.GetValue(6) != System.DBNull.Value)
                    {
                        objUser.Avata = (byte[])reader.GetValue(6);
                    }

                    string userPwdHash = BCrypt.Net.BCrypt.HashPassword(Password, objUser.Password_Salt);

                    if (objUser.Password_Hash != userPwdHash)
                    {
                        MyConfig.logger.Warn("Invalid login attemp! " +
                            "User: " + Username);
                        return false;
                    }
                    MyConfig.activeUser = objUser;
                    MyConfig.logger.Info("User " + Username + " login.");
                }
                else
                {
                    MyConfig.logger.Warn("Invalid login attemp! " +
                            "User: " + Username);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MyConfig.logger.Error("User.Login() - " + ex.Message);
                MessageBox.Show("An error has occured. Please contact system administrator!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (MyConfig.SqlCon.State == ConnectionState.Open)
                    MyConfig.SqlCon.Close();
            }
        }
        public bool UpdatePwd()
        {
            try
            {
                //Open Connection
                MyConfig.SqlCon.Open();

                //Create SqlCommand
                SqlCommand cmd = MyConfig.SqlCon.CreateCommand();
                cmd.CommandText = "UPDATE [User] SET  " +
                    "[Password_Salt]=@pwd_salt, " +
                    "[Password_Hash]=@pwd_hash " +
                    "WHERE [ID]=@id;";
                cmd.Parameters.AddWithValue("pwd_salt", Password_Salt);
                cmd.Parameters.AddWithValue("pwd_hash", Password_Hash);
                cmd.Parameters.AddWithValue("id", ID);

                // cmd.ExecuteNonQuery() will return a number of affected records.
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                // Display error message to user
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Close active connection
                if (MyConfig.SqlCon.State == ConnectionState.Open)
                    MyConfig.SqlCon.Close();
            }
        }
        //Overloading method: update password, email and role
        public static bool Update(int id, string rawPassword,
                                    string email, int role)
        {
            try
            {
                //Open Connection
                MyConfig.SqlCon.Open();

                //Creating password salt and hash using BCrypt.Net
                string pwd_salt = BCrypt.Net.BCrypt.GenerateSalt();
                string pwd_hash = BCrypt.Net.BCrypt.HashPassword(rawPassword,
                                        pwd_salt);

                //Create SqlCommand
                SqlCommand cmd = MyConfig.SqlCon.CreateCommand();
                cmd.CommandText = "UPDATE [User] SET" +
                    "[Password_Salt]=@salt, [Password_Hash]=@hash," +
                    " [Email]=@email, [Role]=@role WHERE [ID]=@id";

                cmd.Parameters.AddWithValue("salt", pwd_salt);
                cmd.Parameters.AddWithValue("hash", pwd_hash);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("role", role);
                cmd.Parameters.AddWithValue("id", id);

                // cmd.ExecuteNonQuery() will return a number of affected records.
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                // Display error message to user
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Close active connection
                if (MyConfig.SqlCon.State == ConnectionState.Open)
                    MyConfig.SqlCon.Close();
            }
        }
        //Overloading method: Update email and role
        public static bool Update(int id, string email, int role)
        {
            try
            {
                //Open Connection
                MyConfig.SqlCon.Open();

                //Create SqlCommand
                SqlCommand cmd = MyConfig.SqlCon.CreateCommand();
                cmd.CommandText = "UPDATE [User] SET" +
                    " [Email]=@email, [Role]=@role WHERE [ID]=@id";

                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("role", role);
                cmd.Parameters.AddWithValue("id", id);

                // cmd.ExecuteNonQuery() will return a number of affected records.
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                // Display error message to user
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Close active connection
                if (MyConfig.SqlCon.State == ConnectionState.Open)
                    MyConfig.SqlCon.Close();
            }
        }

        public static bool SetAvata(int id, byte[] picture)
        {
            try
            {
                //Open Connection
                MyConfig.SqlCon.Open();

                //Create SqlCommand
                SqlCommand cmd = MyConfig.SqlCon.CreateCommand();
                cmd.CommandText = "UPDATE [User] SET" +
                    " [Avata]=@avata WHERE [ID]=@id";

                cmd.Parameters.AddWithValue("Avata", picture);
                cmd.Parameters.AddWithValue("id", id);

                // cmd.ExecuteNonQuery() will return a number of affected records.
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                // Display error message to user
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Close active connection
                if (MyConfig.SqlCon.State == ConnectionState.Open)
                    MyConfig.SqlCon.Close();
            }
        }
        public static bool RemoveAvata(int id)
        {
            try
            {
                //Open Connection
                MyConfig.SqlCon.Open();

                //Create SqlCommand
                SqlCommand cmd = MyConfig.SqlCon.CreateCommand();
                cmd.CommandText = "UPDATE [User] SET" +
                    " [Avata]=null WHERE [ID]=@id";

                cmd.Parameters.AddWithValue("id", id);

                // cmd.ExecuteNonQuery() will return a number of affected records.
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                // Display error message to user
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Close active connection
                if (MyConfig.SqlCon.State == ConnectionState.Open)
                    MyConfig.SqlCon.Close();
            }
        }
    }
}
