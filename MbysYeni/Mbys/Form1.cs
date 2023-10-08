namespace Mbys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_HastaKaydet_Click(object sender, EventArgs e)
        {

           Frm_HastaKayit frm_HastaKayit = new Frm_HastaKayit();
            frm_HastaKayit.ShowDialog();
        }

        private void btn_MuayeneKaydet_Click(object sender, EventArgs e)
        {
            Frm_MuayeneKayit frm_MuayeneKayit = new Frm_MuayeneKayit();
            frm_MuayeneKayit.ShowDialog();
        }

        private void btn_IlacKaydet_Click(object sender, EventArgs e)
        {
            Frm_IlacKayit frm_IlacKayit = new Frm_IlacKayit();
             frm_IlacKayit.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_IlacaGoreHastalar frm_IlacaGoreHastalar = new Frm_IlacaGoreHastalar();
            frm_IlacaGoreHastalar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_HastayaGoreIlacGoster frm_HastayaGoreIlacGoster = new Frm_HastayaGoreIlacGoster();
            frm_HastayaGoreIlacGoster.ShowDialog();
        }

        private void btn_KayitliHastalar_Click(object sender, EventArgs e)
        {
           Frm_HastaGoster frm_HastaGoster = new Frm_HastaGoster();
            frm_HastaGoster.ShowDialog();
        }

        private void btn_KayitliIlaclar_Click(object sender, EventArgs e)
        {
            Frm_IlacGoster frm_IlacGoster = new Frm_IlacGoster();
            frm_IlacGoster.ShowDialog();
        }

        private void btn_receteler_Click(object sender, EventArgs e)
        {
            Frm_Recete_goster frm_Recete_Goster = new Frm_Recete_goster();
            frm_Recete_Goster.ShowDialog();
        }
    }
}