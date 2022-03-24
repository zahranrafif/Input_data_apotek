using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Insert_data_apotek
{
    class Program {
        static void Main(string[] args) {
            new Program().InsertData();
        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-8VLH0CG;database=apotek;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into test (NIM, Nama, Alamat, Jenis_Kelamin) values('2019010092','Uung','Cilegon','L')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();

            } catch(Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
