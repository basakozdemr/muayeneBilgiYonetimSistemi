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
    public partial class Frm_HastaGoster : Form
    {
        public Frm_HastaGoster()
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
        private void Frm_HastaGoster_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from hastabilgi", dgv_KayitliHastalar);

        }
    }
}
