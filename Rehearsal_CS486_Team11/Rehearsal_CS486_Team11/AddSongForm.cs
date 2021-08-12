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
    public partial class AddSongForm : Form
    {
        SqlConnection connect = new SqlConnection();
        public AddSongForm(SqlConnection Connect)
        {
            connect = Connect;
            InitializeComponent();
        }

        private void AddSongButton_Click(object sender, EventArgs e)
        {
            string sql = $"EXEC addSong {songId.Text}, '{songName.Text}', {songViews.Text}, {songOfficial.Text}, '{songQuality.Text}', '{songRelease.Text}'";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.ExecuteNonQuery();
            this.Close();
        }
    }
}
