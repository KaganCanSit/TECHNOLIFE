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

        private void LoginImageButton_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("Select TCNo, KullaniciSifre, YetkiID From tblKullanici where TCNo=@p3 and KullaniciSifre=@p4", Connect.Connect());
            komut.Parameters.AddWithValue("@p3", TCNoTextBox.Text);
            komut.Parameters.AddWithValue("@p4", PasswordTextBox.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                //Tablodaki YetkiID Bilgisini Değişkene Atayarak Kullanıcıları Ayırıyoruz.
                int YetkiID = int.Parse(dr[2].ToString());
                //Kullanıcı Girişi Yetkisine Göre İşlem Yapacağı Forma İletiyoruz. 
                if (YetkiID == 1)
                {
                    MessageBox.Show("Jüri Üyesi");
                }
                else if (YetkiID == 2)
                {
                    MessageBox.Show("Takım Kaptanı");
                }
                else if (YetkiID == 3)
                {
                    MessageBox.Show("Ekip Üyesi");
                }
            }
            else
                MessageBox.Show("Hatalı TC. Kimlik Numarası veya Şifre Girdiniz. Lütfen Yeniden Deneyiniz.");

            Connect.Connect().Close();
        }
    }
}
