using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TYT_AYT_Puan_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkce_net, mat_net, fen_net, sosyal_net;
            double edebiyat_net, tarih1_net, coğrafya1_net;
            double tarih2_net, coğrafya2_net, felsefe_net, din_net;
            double mat2_net;
            double fizik_net, kimya_net, biyoloji_net;
            double basari_puani;
            double tyt_puani, sayisal, sözel, esit_agirlik;
            double tyt_yerlestirme, sayisal_yerlestirme, sözel_yerlestirme, esitagirlik_yerlestirme;

            turkce_net = Convert.ToDouble(TurkceNet.Text);
            mat_net = Convert.ToDouble(MatNet.Text);
            fen_net = Convert.ToDouble(FenNet.Text);
            sosyal_net = Convert.ToDouble(SosyalNet.Text);
            basari_puani = Convert.ToDouble(BasariPuanı.Text);

            tyt_puani = 100.000 + turkce_net * 3.3 + mat_net * 3.3 + sosyal_net * 3.4 + fen_net * 3.4;
            tyt_yerlestirme = tyt_puani + basari_puani * 0.6;
            TYT.Text = Convert.ToString(tyt_puani);
            TYTYerlestirme.Text = Convert.ToString(tyt_yerlestirme);

            edebiyat_net = Convert.ToDouble(Edebiyat.Text);
            tarih1_net = Convert.ToDouble(Tarih1.Text);
            coğrafya1_net = Convert.ToDouble(Coğrafya1.Text);
            mat2_net = Convert.ToDouble(Mat2Net.Text);

            esit_agirlik = 100.000 + mat2_net * 3.0 + coğrafya1_net * 3.33 + tarih1_net * 2.88 + edebiyat_net * 3.0 + turkce_net * 1.32 + mat_net * 1.32 + sosyal_net * 1.36 + fen_net * 1.36;
            esitagirlik_yerlestirme = esit_agirlik + basari_puani * 0.6;
            EsitAğırlık.Text = Convert.ToString(esit_agirlik);
            EsitAğırlıkYerleştirme.Text = Convert.ToString(esitagirlik_yerlestirme);

            tarih2_net = Convert.ToDouble(Tarih2.Text);
            coğrafya2_net = Convert.ToDouble(Coğrafya2.Text);
            felsefe_net = Convert.ToDouble(Felsefe.Text);
            din_net = Convert.ToDouble(DinKültürü.Text);
            sözel = 100.000 + coğrafya1_net * 3.33 + tarih1_net * 2.88 + edebiyat_net * 3.0 + tarih2_net * 2.91 + coğrafya2_net * 2.91 + felsefe_net * 3.0 + din_net * 3.33 + turkce_net * 1.32 + mat_net * 1.32 + sosyal_net * 1.36 + fen_net * 1.36;
            sözel_yerlestirme = sözel + basari_puani * 0.6;
            Sözel.Text = Convert.ToString(sözel);
            SözelYerlestirme.Text = Convert.ToString(sözel_yerlestirme);

            fizik_net = Convert.ToDouble(Fizik.Text);
            kimya_net = Convert.ToDouble(Kimya.Text);
            biyoloji_net = Convert.ToDouble(Biyoloji.Text);
            sayisal = 100.000 + mat2_net * 3.0 + fizik_net * 2.8 + kimya_net * 3.07 + biyoloji_net * 3.07 + turkce_net * 1.32 + mat_net * 1.32 + sosyal_net * 1.36 + fen_net * 1.36;
            sayisal_yerlestirme = sayisal + basari_puani * 0.6;
            Sayısal.Text = Convert.ToString(sayisal);
            SayısalYerlestirme.Text = Convert.ToString(sayisal_yerlestirme);
        }
    }
}
