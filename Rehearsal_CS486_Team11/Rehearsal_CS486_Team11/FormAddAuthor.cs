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
using System.Configuration;

namespace Rehearsal_CS486_Team11
{
    public partial class FormAddAuthor : Form
    {
        public FormAddAuthor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings[name].ConnectionString; ;
            SqlCommand cmd = new SqlCommand("addAuthor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = txtAuthorId.Text;
            cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = txtAuthorId.Text;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("SUCCESS!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
