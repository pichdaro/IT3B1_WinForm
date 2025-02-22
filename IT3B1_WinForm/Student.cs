using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT3B1_WinForm
{
    internal class Student
    {
        //Creating Properties represent all fields in table
        public int ID { get; set; }
        public string SID { get; set; }
        public string SName { get; set; }
        public Sex Gender { get; set; }
        public Shift StudyShift { get; set; }
        public Address PoB { get; set; }
        public static void FetchData(ListView lv)
        {
            try
            {
                //2nd - Open connection
                MyConfig.AccCon.Open();

                //3rd - Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tblStudent";

                //4th - Create DataReader and execute command
                OleDbDataReader reader = cmd.ExecuteReader();

                //Check if reader is records and loop through record
                lv.Items.Clear();
                lv.Columns.Clear();
                lv.Columns.Add("អត្តលេខ", 200);
                lv.Columns.Add("ឈ្មោះ", 300);
                lv.Columns.Add("ភេទ", 150);
                lv.Columns.Add("វេនសិក្សា", 200);
                lv.Columns.Add("ទីកន្លែងកំណើត", 250);
                lv.View = View.Details;
                lv.FullRowSelect = true;
                lv.MultiSelect = true;

                while (reader.Read())
                {
                    //Creating object student to store data
                    Student objStu = new Student();
                    objStu.ID = (int)reader[0];
                    objStu.SID = (string)reader[1];
                    objStu.SName = (string)reader[2];
                    objStu.Gender = (Sex)reader[3];
                    objStu.StudyShift = (Shift)reader[4];
                    objStu.PoB = (Address)reader[5];

                    //Create string array to store student info
                    string[] stuData = new string[5];
                    stuData[0] = objStu.SID;
                    stuData[1] = objStu.SName;
                    if (objStu.Gender == Sex.Male)
                        stuData[2] = "ប្រុស";
                    else
                        stuData[2] = "ស្រី";

                    if (objStu.StudyShift == Shift.Morning)
                        stuData[3] = "ព្រឹក";
                    else if (objStu.StudyShift == Shift.Afernoon)
                        stuData[3] = "ថ្ងៃ";
                    else
                        stuData[3] = "យប់";

                    if (objStu.PoB == Address.Phnom_Penh)
                        stuData[4] = "ភ្នំពេញ";
                    else
                        stuData[4] = "ខេត្ត";

                    //Create ListViewItem from array
                    ListViewItem stuItem = new ListViewItem(stuData);
                    stuItem.Tag = objStu;
                    lv.Items.Add(stuItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }
        public bool AddStudent()
        {
            try
            {
                //2nd - Open connection
                MyConfig.AccCon.Open();

                //3rd - Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "INSERT INTO tblStudent([SID], " +
                    "[SName], [Gender], [StudyShift], [PoB]) " +
                    "VALUES(@sid, @sname, @gender, @shift, @pob)";
                cmd.Parameters.AddWithValue("sid", SID);
                cmd.Parameters.AddWithValue("sname", SName);
                cmd.Parameters.AddWithValue("gender", Gender);
                cmd.Parameters.AddWithValue("shift", StudyShift);
                cmd.Parameters.AddWithValue("pob", PoB);

                //4th - Execute command
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }

        public bool DeleteStudent()
        {
            try
            {
                //2nd - Open connection
                MyConfig.AccCon.Open();

                //3rd - Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "DELETE FROM tblStudent WHERE [ID]=@id";
                cmd.Parameters.AddWithValue("id", ID);
                
                //4th - Execute command
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }

        public static bool DeleteAll()
        {
            try
            {
                //2nd - Open connection
                MyConfig.AccCon.Open();

                //3rd - Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "DELETE FROM tblStudent";

                //4th - Execute command
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }

        public bool UpdateStudent()
        {
            try
            {
                //2nd - Open connection
                MyConfig.AccCon.Open();

                //3rd - Create command
                OleDbCommand cmd = MyConfig.AccCon.CreateCommand();
                cmd.CommandText = "UPDATE tblStudent SET [SID]=@sid, " +
                    "[SName]=@sname, [Gender]=@gender, [StudyShift]=@shift, " +
                    "[PoB]=@pob WHERE [ID]=@id";
                cmd.Parameters.AddWithValue("sid", SID);
                cmd.Parameters.AddWithValue("sname", SName);
                cmd.Parameters.AddWithValue("gender", Gender);
                cmd.Parameters.AddWithValue("shift", StudyShift);
                cmd.Parameters.AddWithValue("pob", PoB);
                cmd.Parameters.AddWithValue("id", ID);

                //4th - Execute command
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (MyConfig.AccCon.State == ConnectionState.Open)
                    MyConfig.AccCon.Close();
            }
        }
    }
}
