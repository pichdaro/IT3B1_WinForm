using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT3B1_WinForm
{
    internal class Midterm
    {
        void Answer()
        {
            RadioButton rb1 = new RadioButton();
            rb1.Checked = true;

            CheckBox cb1 = new CheckBox();
            cb1.Checked = true;
        }

        void InsertData()
        {
            OleDbConnection AccCon = new
                OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Application.StartupPath +
            "myDB.accdb;Jet OLEDB:Database Password=adm@123;");
            AccCon.Open();
            OleDbCommand cmd = AccCon.CreateCommand();
            cmd.CommandText = "INSERT INTO tblCourse([Course_Code]," +
                "[Course_Name], [Course_Type],[Availability]," +
                "[Description] VALUES(@cCode,@cName,@cType," +
                "@avail,@desc)";
            cmd.Parameters.AddWithValue("cCode", "C001");
            cmd.Parameters.AddWithValue("cName", "Subject101");
            cmd.Parameters.AddWithValue("cType", 1);
            cmd.Parameters.AddWithValue("avail", 1);
            cmd.Parameters.AddWithValue("desc", "Lorem Ipsum...");
            cmd.ExecuteNonQuery();
        }
        void ReadData(ListView lv1)
        {
            OleDbConnection AccCon = new
                OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Application.StartupPath +
            "myDB.accdb;Jet OLEDB:Database Password=adm@123;");
            AccCon.Open();
            OleDbCommand cmd = AccCon.CreateCommand();
            cmd.CommandText = "SELECT * FROM tblCourse";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] arr = new string[5];
                arr[0] = reader[1].ToString();
                arr[1] = reader[2].ToString();
                arr[2] = reader[3].ToString();
                arr[3] = reader[4].ToString();
                arr[4] = reader[5].ToString();
                ListViewItem li = new ListViewItem(arr);
                lv1.Items.Add(li);
            }
        }
    }
}

