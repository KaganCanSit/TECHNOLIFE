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
    public partial class JuriUyesiForm : Form
    {
        public JuriUyesiForm()
        {
            InitializeComponent();
        }

        private void JuriUyesiForm_Load(object sender, EventArgs e)
        {
            PUComboBox();
            UserID();
            CategoryID();
            TeamID();
        }
        
        // ProjeID'leri Seçim İçin ComboBox İçerisine Atıyoruz.
        void PUComboBox()
        {
            komut = new SqlCommand("Select * From tblProje", Connect.Connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PointUpdateComboBox.ValueMember = "ProjeID";
            PointUpdateComboBox.DataSource = dt;
        }
        // KullanıcıID'lerin Seçim İle ComboBox İçerisine Atılması
        void UserID()
        {
            komut = new SqlCommand("Select * From tblKullanici", Connect.Connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DelUserComboBox.ValueMember = "kullaniciID";
            DelUserComboBox.DataSource = dt;
        }

        // KategoriID'lerin Seçim İle ComboBox İçerisine Atılması
        void CategoryID()
        {
            komut = new SqlCommand("Select * From tblKategori", Connect.Connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DelCategoryComboBox.ValueMember = "kategoriID";
            DelCategoryComboBox.DataSource = dt;
        }

        // EkipID'lerin Seçim İle ComboBox İçerisine Atılması
        void TeamID()
        {
            komut = new SqlCommand("Select * From tblEkip", Connect.Connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DelTeamComboBox.ValueMember = "ekipID";
            DelTeamComboBox.DataSource = dt;
        }
        //----------------------------------------------------------------------------------------------------------------------------

        //Genel Bileşenlerin Görünümünü Her Seferinde Yazmamak İçin Bir Fonksiyon Tanımlayarak Değerleri Parametre Olarak Alıp Form Görünümünü Ayarlama
        void VisibleJuri(bool datagrid, bool pointUpdate, bool delUser, bool delCategory, bool delTeam )
        {
            JuriUyesiDataGrid.Visible = datagrid;
            PointUpdateGroupBox.Visible = pointUpdate;          
            DelUserGroupBox.Visible = delUser;
            DelCategoryGroupBox.Visible = delCategory;
            DelTeamGroupBox.Visible = delTeam;
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //Database'e bağlanabilmek ve kullanabilmek için tanımlamış olduğum bağlantıyı çağırıyorum.
        SqlConnect Connect = new SqlConnect();
        SqlCommand komut = new SqlCommand();

        //Proje Bilgilerini Görüntülenmesi - View
        void ProjectShow()
        {
            komut = new SqlCommand("SELECT * FROM ProjectScoreRanking", Connect.Connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            JuriUyesiDataGrid.DataSource = dt;
            Connect.Connect().Close();
        }
        //Kullanıcılara Dair Tüm Bilgileri SQL View Yardımıyla Tabloya Çekiyoruz
        void ShowUserInfo()
        {
            komut = new SqlCommand("SELECT * FROM ShowUserInfo", Connect.Connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            JuriUyesiDataGrid.DataSource = dt;
            Connect.Connect().Close();
        }
        //Kategorilere Dair Bilgileri Tabloya Çekiyoruz
        void CategoryInfo()
        {
            komut = new SqlCommand("SELECT * FROM tblKategori", Connect.Connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            JuriUyesiDataGrid.DataSource = dt;
            Connect.Connect().Close();
        }
        //Ekiplere Dair Bilgileri Tabloya Çekiyoruz
        void TeamInfo()
        {
            komut = new SqlCommand("SELECT * FROM tblEkip", Connect.Connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            JuriUyesiDataGrid.DataSource = dt;
            Connect.Connect().Close();
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //Projeleri Görüntüle Ve Puanını DÜzenle
        private void AllProjectInfoFlatButton_Click(object sender, EventArgs e)
        {
            VisibleJuri(true,true,false,false,false);
            ProjectShow();
        }
        //Değerlerin  Girilmesini Ardından SQL Procedur Yardımıyla Puan Değerinin Güncellenmesi
        private void PointUpdateButton_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("UpdProjectPoint", Connect.Connect());
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@projeID", PointUpdateComboBox.Text);
            komut.Parameters.AddWithValue("@projePuan", PointUpdateValueTextBox.Text);
            int value = Convert.ToInt32(PointUpdateValueTextBox.Text);
            if (PointUpdateComboBox.Text == "" || PointUpdateValueTextBox.Text == "" || value<0 || value>10)
            {
                MessageBox.Show("Boş değer bırakmayınız. Puan değeriniz 10'dan büyük ve 0'dan küçük olamaz. Lütfen kontrol ederek yeniden deneyiniz.");
            }
            else
            {
                komut.ExecuteNonQuery();
                Connect.Connect().Close();
                ProjectShow();
                MessageBox.Show("Proje Bilginiz Sistem Üzerinde Güncellenmiştir. 'OK'a Bastıktan Sonra Güncel Tablo Üzerinden Kontrol Edebilirsiniz.");
            }
        }

        //Tüm Kullanıcılara Ait Bilgileri SQL İçerisinde Tanımladığımız VIEW ile kolaylıkla gerçekleştiriyoruz.
        private void AllUsersInfoFlatButton_Click(object sender, EventArgs e)
        {
            ShowUserInfo();
            VisibleJuri(true, false, true, false, false);
        }
        //Yarışmacıyı Sistem Üzerinde Silme İşlemini Gerçekleştirmek İçin SQL üzerinde PROC (DelUser)'ı kullanıyoruz.
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("DelUser", Connect.Connect());
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@kullaniciID", DelUserComboBox.Text);
            if (DelUserComboBox.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız. Lütfen Kullanıcı ID numarası giriniz. Lütfen kontrol ederek yeniden deneyiniz.");
            }
            else
            {
                komut.ExecuteNonQuery();
                Connect.Connect().Close();
                ShowUserInfo();
                MessageBox.Show("Kullanıcı Sistem Üzerinden Silinmiştir. 'OK'a Bastıktan Sonra Güncel Tablo Üzerinden Kontrol Edebilirsiniz.");
            }
        }

        //Kategori Silme İşlemi Öncesi Görünürlük Ayarlaması ve Verilerin Getirilmesi
        private void RedCategoryFlatButton_Click(object sender, EventArgs e)
        {
            VisibleJuri(true, false, false, true, false);
            CategoryInfo();
        }
        //Kategoriyi Sistem Üzerinde Silme İşlemini Gerçekleştirmek İçin SQL üzerinde PROC (DelCategory)'i kullanıyoruz.
        private void DelCategoryButton_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("DelCategory", Connect.Connect());
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@kategoriID", DelCategoryComboBox.Text);
            if (DelCategoryComboBox.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız. Lütfen Kategori ID numarası giriniz. Lütfen kontrol ederek yeniden deneyiniz.");
            }
            else
            {
                komut.ExecuteNonQuery();
                Connect.Connect().Close();
                CategoryInfo();
                MessageBox.Show("Kategori Sistem Üzerinden Silinmiştir. 'OK'a Bastıktan Sonra Güncel Tablo Üzerinden Kontrol Edebilirsiniz.");
            }
        }

        //Takım Silme İşlemi Öncesi Görünürlük Ayarlaması ve Verilerin Getirilmesi
        private void RedTheTeamFlatButton_Click(object sender, EventArgs e)
        {
            VisibleJuri(true, false, false, false, true);
            TeamInfo();
        }
        //Takımı Sistem Üzerinde Silme İşlemini Gerçekleştirmek İçin SQL üzerinde PROC (DelTeam)'i kullanıyoruz.
        private void DelTeamButton_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("DelTeam", Connect.Connect());
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ekipID", DelTeamComboBox.Text);
            if (DelTeamComboBox.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız. Lütfen Ekip ID numarası giriniz. Lütfen kontrol ederek yeniden deneyiniz.");
            }
            else
            {
                komut.ExecuteNonQuery();
                Connect.Connect().Close();
                TeamInfo();
                MessageBox.Show("Ekip Sistem Üzerinden Silinmiştir. 'OK'a Bastıktan Sonra Güncel Tablo Üzerinden Kontrol Edebilirsiniz.");
            }
        }
    }
}
