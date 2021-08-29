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
    public partial class TakimKaptaniForm : Form
    {
        public TakimKaptaniForm()
        {
            InitializeComponent();
        }

        private void TakimKaptaniForm_Load(object sender, EventArgs e)
        {
            MissionCBText();
        }

        //Database'e bağlanabilmek ve kullanabilmek için tanımlamış olduğum bağlantıyı çağırıyorum.
        SqlConnect Connect = new SqlConnect();
        SqlCommand komut = new SqlCommand();

        //Görünürlük Düzenlemeri
        void Visibility()
        {
            NewUserGroupBox.Visible = false;
            TakimKaptaniDataGrid.Visible = true;
            NewProjectGroupBox.Visible = false;
        }

        //Takım Bilgilerini Görüntülemek İçin SQL Üzerinde Yazılmış Olan Prosedürü Kullanarak Veriyi Tabloya Aktarıyoruz.
        void TeamInfoShow()
        {
            Visibility();
            komut = new SqlCommand("TeamInfo", Connect.Connect());
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@EkipID", LoginForm.EkipID);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TakimKaptaniDataGrid.DataSource = dt;
            komut.ExecuteNonQuery();
            Connect.Connect().Close();
        }
        //Proje Bilgilerini Görüntülemek İçin SQL Üzerinde Yazılmış OlanProsedürü Kullanarak Veriyi Tabloya Aktarıyoruz.
        void ProjectInformationShow()
        {
            Visibility();
            komut = new SqlCommand("ShowProjectInfo", Connect.Connect());
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@EkipID", LoginForm.EkipID);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TakimKaptaniDataGrid.DataSource = dt;
            komut.ExecuteNonQuery();
            Connect.Connect().Close();
        }

        //Görev ComboBox'ının Doldurulması
        void MissionCBText()
        {
            komut = new SqlCommand("Select * From tblGorev", Connect.Connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CBMission.ValueMember = "GorevID";
            CBMission.DataSource = dt;
        }
        //GörevID'lerin Açıklaması
        private void MissionInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GörevID/Açıklama\n" + "1-Yazılım\n"+"2-Mekanik\n"+"3-Elektrik\n"+"4-Kalıp\n"+"5-Test\n"+"6-Planlama\n"+"7-Kaptan\n");
        }

        //Projelerin Genel Puan Bilgilerini SQL üzerinde yadığımız View yardımıyla getiriyoruz.
        private void CaptanProjectInfoFlatButton_Click(object sender, EventArgs e)
        {
            Visibility();
            komut = new SqlCommand("SELECT * FROM ProjectScoreRanking", Connect.Connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TakimKaptaniDataGrid.DataSource = dt;
            Connect.Connect().Close();
        }

        //SQL üzerinde tanımlamış olduğumuz TeamInfo Prosedürü kullanılarak Ekip üyesinin ait olduğu ekibe dair bilgileri getiriyoruz.
        private void CaptainTeamInfoFlatButton_Click(object sender, EventArgs e)
        {
            TeamInfoShow();
        }

        //Kullanici Ekle İlk Görünüm Ayarı
        private void NewUsersAddFalatButton_Click(object sender, EventArgs e)
        {
            NewUserGroupBox.Visible = true;
            TakimKaptaniDataGrid.Visible = false;
            NewProjectGroupBox.Visible = false;
        }
        //Yeni Kullaniciyi Sisteme Ekleme
        private void AddUserFlatButton_Click(object sender, EventArgs e)
        {
            Visibility();
            komut = new SqlCommand("NewUsers", Connect.Connect());
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ekipID", LoginForm.EkipID);
            komut.Parameters.AddWithValue("@gorevID", CBMission.Text);
            komut.Parameters.AddWithValue("@yetkiID", 3);
            komut.Parameters.AddWithValue("@kullaniciAd", NameTextBox.Text);
            komut.Parameters.AddWithValue("@kullaniciSoyad", SurnameTextBox.Text);
            komut.Parameters.AddWithValue("@kullaniciSifre", PasswordTextBox.Text);
            komut.Parameters.AddWithValue("@TCNo", TCNumberTextBox.Text);
            komut.Parameters.AddWithValue("@telefon", PhoneTextBox.Text);
            komut.Parameters.AddWithValue("@il", ProvinceTextBox.Text);
            komut.Parameters.AddWithValue("@ilce", DistrictTextBox.Text);
            if(CBMission.Text=="" || NameTextBox.Text=="" || SurnameTextBox.Text=="" || PasswordTextBox.Text=="" || TCNumberTextBox.Text==""||PhoneTextBox.Text==""||ProvinceTextBox.Text==""||DistrictTextBox.Text=="")
            {
                MessageBox.Show("Boş değer bırakmayınız. Lütfen kontrol ederek yeniden deneyiniz.");
            }
            else
            {
                komut.ExecuteNonQuery();
                Connect.Connect().Close();
                TeamInfoShow();
                MessageBox.Show("Yeni Ekip Üyeniz Sisteme Eklendi. 'OK'a Bastıktan Sonra Güncel Tablo Üzerinde Yeni Ekip Bilgilerinizi İnceleyebilirsiniz.");
            }          
        }

        //Yeni Proje Ekle İlk Görünüm Ayarı
        private void NewProjectFlatButton_Click(object sender, EventArgs e)
        {
            NewUserGroupBox.Visible = false;
            TakimKaptaniDataGrid.Visible = false;
            NewProjectGroupBox.Visible = true;
        }
        //Yeni Projeyi Sisteme Ekleme
        private void NewProjectAddButton_Click(object sender, EventArgs e)
        {
            Visibility();
            komut = new SqlCommand("NewProject", Connect.Connect());
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ekipID", LoginForm.EkipID);
            komut.Parameters.AddWithValue("@kategoriID", ProjectCategoryComboBox.Text);
            komut.Parameters.AddWithValue("@projeAd", ProjectNameTextBox.Text);
            komut.Parameters.AddWithValue("@projeBilgi", ProjectInformationTextBox.Text);
            komut.Parameters.AddWithValue("@katilimtarih",DateTime.Now());
            if (ProjectCategoryComboBox.Text == "" || ProjectNameTextBox.Text == "" || ProjectInformationTextBox.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız. Lütfen kontrol ederek yeniden deneyiniz.");
            }
            else
            {
                komut.ExecuteNonQuery();
                Connect.Connect().Close();
                ProjectInformationShow();
                MessageBox.Show("Yeni Projeniz Sisteme Eklendi. 'OK'a Bastıktan Sonra Güncel Tablo Üzerinde Yeni Proje Bilgilerinizi İnceleyebilirsiniz.");
            }

        }
    }
}
