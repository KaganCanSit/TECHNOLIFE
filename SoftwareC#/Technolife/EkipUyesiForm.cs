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
    public partial class EkipUyesiForm : Form
    {
        public EkipUyesiForm()
        {
            InitializeComponent();
        }

        //Database'e bağlanabilmek ve kullanabilmek için tanımlamış olduğum bağlantıyı çağırıyorum.
        SqlConnect Connect = new SqlConnect();
        SqlCommand komut = new SqlCommand();

        //Görünebilirlik Ayarı
        void UyeVisible(bool datagrid)
        {
            EkipUyeDataGrid.Visible = datagrid;
        }

        //SQL üzerinde tanımlamış olduğumuz TeamInfo Prosedürü kullanılarak Ekip üyesinin ait olduğu ekibe dair bilgileri getiriyoruz.
        private void TeamInfoFlatButton_Click(object sender, EventArgs e)
        {
            UyeVisible(true);
            komut = new SqlCommand("TeamInfo",Connect.Connect());
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@EkipID", LoginForm.EkipID);          
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            EkipUyeDataGrid.DataSource = dt;
            komut.ExecuteNonQuery();
            Connect.Connect().Close();
        }

        //Projelerin Genel Puan Bilgilerini SQL üzerinde yadığımız View yardımıyla getiriyoruz.
        private void ProjectInfoFlatButton_Click_1(object sender, EventArgs e)
        {
            UyeVisible(true);
            komut = new SqlCommand("SELECT * FROM ProjectScoreRanking", Connect.Connect());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            EkipUyeDataGrid.DataSource = dt;
            Connect.Connect().Close();
        }
    }
}
