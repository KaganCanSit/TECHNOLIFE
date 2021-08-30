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
            ProjectCategoryText();
            ProjectIDText();
        }

        //Database'e bağlanabilmek ve kullanabilmek için tanımlamış olduğum bağlantıyı çağırıyorum.
        SqlConnect Connect = new SqlConnect();
        SqlCommand komut = new SqlCommand();

        //Görünürlük Düzenlemeri
        void Visibility(bool datagrid, bool newUser, bool newProject, bool projectUpdate)
        {
            TakimKaptaniDataGrid.Visible = datagrid;
            NewUserGroupBox.Visible = newUser;
            NewProjectGroupBox.Visible = newProject;
            ProjectUpdateGroupBox.Visible = projectUpdate;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        //Takım Bilgilerini Görüntülemek İçin SQL Üzerinde Yazılmış Olan Prosedürü Kullanarak Veriyi Tabloya Aktarıyoruz.
        void TeamInfoShow()
        {
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
        //Proje Bilgilerini Görüntülemek İçin SQL Üzerinde Yazılmış Olan Prosedürü Kullanarak Veriyi Tabloya Aktarıyoruz.
        void ProjectInformationShow()
        {
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

        //--------------------------------------------------------------------------------------------------------------------------------------
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
        //Proje Kategori ComboBox'ının Doldurulması
        void ProjectCategoryText()
        {
            komut = new SqlCommand("SELECT * FROM tblKategori", Connect.Connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ProjectCategoryComboBox.ValueMember = "kategoriID";
            ProjectCategoryComboBox.DataSource = dt;
            UpdatePCategoryTextBox.ValueMember = "kategoriID";
            UpdatePCategoryTextBox.DataSource = dt;
        }
        //ProjectID ComboBox'ının Doldurulması
        void ProjectIDText()
        {
            komut = new SqlCommand("SELECT * FROM tblProje WHERE ekipID=@p1", Connect.Connect());
            komut.Parameters.AddWithValue("@p1", LoginForm.EkipID);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            UpdateProjectIDComboBox.ValueMember = "projeID";
            UpdateProjectIDComboBox.DataSource = dt;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------
        void CategoryInfo()
        {
            MessageBox.Show("KategoriID/Açıklama\n" + "1-Üretim (Tarım-Fabrika Otomasyon)\n" + "2-Doğal Afet\n" + "3-Ulaşım\n" +
                            "4-Hava Sistemleri\n" + "5-Su Altı Sistemler\n" + "6-Ev Sistemleri\n" + "7-Eğitim\n" + "8-Sağlık\n" + "9-Yapay Zeka\n" +
                            "10-Enerji\n" + "11-Haberleşme");
        }      
        //GörevID'lerin Açıklaması
        private void MissionInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GörevID/Açıklama\n" + "1-Yazılım\n"+"2-Mekanik\n"+"3-Elektrik\n"+"4-Kalıp\n"+"5-Test\n"+"6-Planlama\n"+"7-Kaptan\n");
        }
        //KategoriID'lerinin Açıklanması
        private void CategoryInformationFlatButton_Click(object sender, EventArgs e)
        {
            CategoryInfo();
        }
        //KategoriID'lerinin Açıklanması - Update
        private void UpdateCategoryInfoButton_Click(object sender, EventArgs e)
        {
            CategoryInfo();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------


        //Projelerin Genel Puan Bilgilerini SQL üzerinde yadığımız View yardımıyla getiriyoruz.
        private void CaptanProjectInfoFlatButton_Click(object sender, EventArgs e)
        {
            Visibility(true, false, false, false);
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
            Visibility(false,true,false,false);
        }
        //Yeni Kullaniciyi Sisteme Ekleme
        private void AddUserFlatButton_Click(object sender, EventArgs e)
        {
            Visibility(true,false,false,false);
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
            Visibility(false,false,true,false);
        }
        //Yeni Projeyi Sisteme Ekleme
        private void NewProjectAddButton_Click(object sender, EventArgs e)
        {
            Visibility(true, false, false, false);
            komut = new SqlCommand("NewProject", Connect.Connect());
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ekipID", LoginForm.EkipID);
            komut.Parameters.AddWithValue("@kategoriID", ProjectCategoryComboBox.Text);
            komut.Parameters.AddWithValue("@projeAd", ProjectNameTextBox.Text);
            komut.Parameters.AddWithValue("@projeBilgi", ProjectInformationTextBox.Text);
            komut.Parameters.AddWithValue("@katilimtarihi",DateTime.Now.ToLocalTime());
            komut.Parameters.AddWithValue("@projePuan", 0);
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

        //Projeleri Görüntüleme Ve Düzenleme
        private void ProjectAlterFlatButton_Click(object sender, EventArgs e)
        {
            Visibility(false, false, false, true);
            ProjectInformationShow();
        }
        //Proje Bilgilerini Güncelleme İşlemleri
        private void UpdateProjectButton_Click(object sender, EventArgs e)
        {
            Visibility(true, false, false, false);
            komut = new SqlCommand("ProjectUpdate", Connect.Connect());
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@projeID", UpdateProjectIDComboBox.Text);
            komut.Parameters.AddWithValue("@ekipID", LoginForm.EkipID);
            komut.Parameters.AddWithValue("@kategoriID", UpdatePCategoryTextBox.Text);
            komut.Parameters.AddWithValue("@projeAd", UpdatePNameTextBox.Text);
            komut.Parameters.AddWithValue("@projeBilgi", UpdatePInfoTextBox.Text);
            komut.Parameters.AddWithValue("@katilimtarihi", DateTime.Now.ToLocalTime());
            komut.Parameters.AddWithValue("@projePuan", 0);
            if (UpdatePCategoryTextBox.Text == "" || UpdatePNameTextBox.Text == "" || UpdatePInfoTextBox.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız. Lütfen kontrol ederek yeniden deneyiniz.");
            }
            else
            {
                komut.ExecuteNonQuery();
                Connect.Connect().Close();
                ProjectInformationShow();
                MessageBox.Show("Proje Bilginiz Sistem Üzerinde Güncellenmiştir. 'OK'a Bastıktan Sonra Güncel Tablo Üzerinden Kontrol Edebilirsiniz.");
            }
        }


    }
}
