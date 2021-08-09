using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NoteAppDemo.Class
{
    class Connection
    {
        public static SqlConnection Con;     

        public static void Connect()
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\thieu\source\repos\NoteAppDemo\Database\Database.mdf; Integrated Security = True";
            
            Con.Open();

        }

        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
                Con.Dispose();
                Con = null;
            }
        }
    }
}
