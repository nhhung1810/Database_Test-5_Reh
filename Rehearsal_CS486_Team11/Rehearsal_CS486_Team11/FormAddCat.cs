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
    public partial class FormAddCat : Form
    {
        public FormAddCat()
        {
            InitializeComponent();
        }

        private void txtAuthorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings[name].ConnectionString; 
            SqlCommand cmd = new SqlCommand("addCategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = txtID.Text;
            cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = txtName.Text;
            cmd.Parameters.AddWithValue("@parentID", SqlDbType.Int).Value = txtName.Text;
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
