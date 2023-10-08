using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mbys
{
    public partial class Frm_HastayaGoreIlacGoster : Form
    {
        public Frm_HastayaGoreIlacGoster()
        {
            InitializeComponent();
        }


        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=MBYS;User Id=postgres;Password=1234");


        public int verileri_goster(string txt, DataGridView dataGridView)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

                dataGridView.DataSource = dt;

            }
            komut.Dispose();
            conn.Close();
            return 0;
        }



        string receteNo;
        public void receteKontrol(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                receteNo = dr[0].ToString();
            }

            komut.Dispose();
            conn.Close();

        }
        private void btn_IlacAra_Click(object sender, EventArgs e)
        {

            receteKontrol("select recete_no from muayene  where tcno='" + Convert.ToInt32(txt_AranacakTcNo.Text) + "' ");



            verileri_goster("select * from receteilacbilgi where recete_no='" + receteNo + "'", dgv_ilacListele);


        }
    }
}
