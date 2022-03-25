using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Input_obat
{
    public partial class button_log : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;

        void koneksi()
        {
            String connstring = @"data source=DESKTOP-8VLH0CG;database=apotek;Integrated Security=TRUE";
            conn = new SqlConnection(connstring);
            conn.Open();
        }


        public button_log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koneksi();
            /*SqlCommand cm = new SqlCommand("insert into test (NIM, Nama, Alamat, Jenis_Kelamin) values('2019010092','Uung','Cilegon','L')", con);
            cm.ExecuteNonQuery();*/

            String sSql = "insert into input_obat(obat, stock, harga, jenis)values('" + obat.Text + "','" + stock.Text + "','" + harga.Text + "','" + jenis.Text +"')";
            cmd = new SqlCommand(sSql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil disimpan bro!");
            conn.Close();
        }
    }
}
