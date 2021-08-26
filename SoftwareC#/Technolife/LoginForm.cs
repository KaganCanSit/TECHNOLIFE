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

        private void ShowOrderImageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
