using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehearsal_CS486_Team11
{
    public partial class AddAuthorForm : Form
    {
        SqlConnection connect = new SqlConnection();
        public AddAuthorForm(SqlConnection Connect)
        {
            connect = Connect;
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string sql = $"EXEC addAuthor {txtAuthorId.Text}, '{txtAuthorName.Text}'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            this.Close();
        }
    }
}
