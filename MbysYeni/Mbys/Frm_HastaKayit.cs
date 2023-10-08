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
    public partial class Frm_HastaKayit : Form
    {
        public Frm_HastaKayit()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=MBYS;User Id=postgres;Password=1234");

        private void btn_hastaEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand hasta_ekle = new NpgsqlCommand();
            hasta_ekle.Connection = conn;

            hasta_ekle.Parameters.AddWithValue("@ad", msk_hastaAdi.Text);
            hasta_ekle.Parameters.AddWithValue("@soyad", msk_hastaSoyad.Text);
            hasta_ekle.Parameters.AddWithValue("@adres", msk_hastaAdres.Text);
            hasta_ekle.Parameters.AddWithValue("@dgmyeri", msk_hastaDogumYeri.Text);
            hasta_ekle.Parameters.AddWithValue("@dgmtrhi", Convert.ToDateTime(msk_hastaDogumTarihi.Text));
            hasta_ekle.Parameters.AddWithValue("@medenihal", msk_hastaMedeniHal.Text);
            hasta_ekle.Parameters.AddWithValue("@tc", Convert.ToInt32(msk_HastaTc.Text));
            hasta_ekle.Parameters.AddWithValue("@tel", Convert.ToInt32(msk_hastaTelno.Text));
            hasta_ekle.CommandType = CommandType.Text;
            hasta_ekle.CommandText = "insert into hastabilgi (ad,soyad,adres,dogum_yeri,dogum_tarihi,medeni_durum,tcno,ceptel) values (@ad, @soyad, @adres, @dgmyeri, @dgmtrhi,@medenihal,@tc,@tel)";
            NpgsqlDataReader dr = hasta_ekle.ExecuteReader();

            conn.Close();
            hasta_ekle.Dispose();



            MessageBox.Show("Hasta bilgileri başarıyla kaydedildi");
        }
    }
}
