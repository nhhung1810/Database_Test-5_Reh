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

namespace Rehearsal_CS486_Team11
{
    public partial class FormListMusic : Form
    {
        public string musicCategory = null;
        public FormListMusic()
        {
            InitializeComponent();
        }

        private void FormListMusic_Load(object sender, EventArgs e)
        {
            lblMusic.Text = musicCategory;
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "";
            cnn.Open();
            string tmp = "select s.Name as MusicName from Song s join CatSong cs on s.ID = CatSong.SongID join Cat c on cs.CatID = Cat.ID where c.Name like " + lblMusic.Text.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(tmp, cnn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet.Tables.Count > 0)
            {
                cbxMusic.DataSource = dataSet.Tables[0];
                cbxMusic.DisplayMember = "MusicName";
            }
            cnn.Close();
        }
    }
}
