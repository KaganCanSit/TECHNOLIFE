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

namespace Technolife
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Database'e bağlanabilmek ve kullanabilmek için tanımlamış olduğum bağlantıyı çağırıyorum.
        SqlConnect Connect = new SqlConnect();
        SqlCommand komut;

        //Üye Olmayanların Yarışma Sıralamalarını Görebilmeleri İçin Başka Bir Form Oluşturup Genel Proje-Puan Tablosunu View Yardımıyla Gösteriyoruz.
        private void ShowOrderImageButton_Click(object sender, EventArgs e)
        {
            TeamScoreForm TeamScore = new TeamScoreForm();
            TeamScore.Show();
            this.Hide();
        }

        public static int YetkiID;
        public static int KullaniciID;
        public static int EkipID;

        private void LoginImageButton_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("SELECT TCNo, KullaniciSifre, YetkiID, EkipID, KullaniciID FROM tblKullanici WHERE TCNo=@p3 and KullaniciSifre=@p4", Connect.Connect());
            komut.Parameters.AddWithValue("@p3", TCNoTextBox.Text);
            komut.Parameters.AddWithValue("@p4", PasswordTextBox.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                //Tablodaki Mevcut Kullanıcıya Ait Bilgileri Değişkene Atayarak Programı Kişiye Uygun Hale Getiriyoruz.
                YetkiID = int.Parse(dr[2].ToString());
                EkipID = int.Parse(dr[3].ToString());
                KullaniciID = int.Parse(dr[4].ToString());

                //Kullanıcı Girişi Yetkisine Göre İşlem Yapacağı Forma İletiyoruz. 
                if (YetkiID == 1)
                {
                    JuriUyesiForm JuriUyesi = new JuriUyesiForm();
                    JuriUyesi.Show();
                    this.Hide();
                }
                else if (YetkiID == 2)
                {
                    TakimKaptaniForm TakimKaptani = new TakimKaptaniForm();
                    TakimKaptani.Show();
                    this.Hide();
                }
                else if (YetkiID == 3)
                {
                    EkipUyesiForm EkipUyesi = new EkipUyesiForm();
                    EkipUyesi.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Hatalı TC. Kimlik Numarası veya Şifre Girdiniz. Lütfen Yeniden Deneyiniz.");

            Connect.Connect().Close();
        }
    }
}
