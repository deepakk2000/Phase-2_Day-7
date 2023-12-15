using System;
using System.Data;
using System.Data.SqlClient;

namespace A_7
{
    internal class Program
    {
        public static void Display()
        {
            SqlConnection con = new SqlConnection("Data Source =DESKTOP-CTG4A6O; Initial Catalog = LibraryDB; Integrated Security = True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Books", con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4]);
            }
        }
        
        static void Main(string[] args)
        {
            Display();
           
        
        }

    }
}
