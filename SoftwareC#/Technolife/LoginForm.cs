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
        SqlConnection Connect = new SqlConnection();

        //Üye Olmayanların Yarışma Sıralamalarını Görebilmeleri İçin Başka Bir Form Oluşturup Genel Proje-Puan Tablosunu View Yardımıyla Gösteriyoruz.
        private void ShowOrderImageButton_Click(object sender, EventArgs e)
        {
            TeamScoreForm TeamScore = new TeamScoreForm();
            TeamScore.Show();
            this.Hide();
        }
    }
}
