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
    public partial class TeamScoreForm : Form
    {
        public TeamScoreForm()
        {
            InitializeComponent();
        }

        //Database'e bağlanabilmek ve kullanabilmek için tanımlamış olduğum bağlantıyı çağırıyorum.
        SqlConnect Connect = new SqlConnect();

        //DataGrid İçerisine Database Üzerinde Kayıtlı Projelere Dair Bilgileri Vıew Yardımıyla Çekiyoruz.
        private void TeamScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM ProjectScoreRanking", Connect.Connect()); //View
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ScoreDataGrid.DataSource = dt;
            Connect.Connect().Close();
        }
    }
}
