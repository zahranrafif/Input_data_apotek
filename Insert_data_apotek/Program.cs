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
                
                //Insert Data

                SqlCommand cm = new SqlCommand("insert into Customer (Id_customer, Nama, Alamat, Jenis_Kelamin, Pekerjaan) values" +
                    "(77886,'Zahran','Jl.Muncang','L','Mahasiswa')," +
                    "(77887,'Gugung','Jl.Utara','L','Buruh')," +
                    "(77888,'Rijal','Jl.Selatan','L','Buruh')" +
                    
                    "insert into Karyawan (Id_karyawan, Nama, Alamat, Agama, Telpon) values" +
                    "(1196,'Zidhan','Jl.Cisait','Islam',896515976)," +
                    "(1197,'Bagas','Jl.Tempel','Islam',896515977)" +
                    
                    "insert into Obat (Id_obat, Nama_obat, Jenis, Harga, Stock, Id_supplier) values" +
                    "(22336,'Kombatrin','Cair',60000,6,11996)," +
                    "(22337,'Antangin','Cair',20000,2,11997)", con);


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
