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

namespace remakeMusic___
{
    public partial class FormAddSong : Form
    {
        string connectionString = @"Data Source=LAPTOP-HSGL6DT0\SQLEXPRESS;Initial Catalog=CS486_Team11_DB;Integrated Security=True";
        public FormAddSong()
        {
            InitializeComponent();
        }

        private void FormAddSong_Load(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textViews_TextChanged(object sender, EventArgs e)
        {

        }

        private void textOfficial_TextChanged(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            SqlCommand cmd = new SqlCommand("addSong", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = textID.Text;
            cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = textName.Text;
            cmd.Parameters.AddWithValue("@views", SqlDbType.Int).Value = textViews.Text;
            cmd.Parameters.AddWithValue("@official", SqlDbType.Int).Value = textOfficial.Text;
            cmd.Parameters.AddWithValue("@quality", SqlDbType.VarChar).Value = textQuality.Text;
            cmd.Parameters.AddWithValue("@releaseDate", SqlDbType.Date).Value = textDate.Text;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("SUCCESS!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
