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


        //----------------------------------------------------------------------------------------------------------------------------
        //Projeleri Görüntüle Ve Puanını DÜzenle
        private void AllProjectInfoFlatButton_Click(object sender, EventArgs e)
        {
            JuriUyesiDataGrid.Visible = true;
            PointUpdateGroupBox.Visible = true;
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
    }
}
