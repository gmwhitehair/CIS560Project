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

namespace ProjectApplication
{
    public partial class uxInsertUser : Form
    {
        public uxInsertUser()
        {
            InitializeComponent();
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(localdb)\\GabeLocal";
                builder.InitialCatalog = "CIS560";
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql;
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    sql = "SELECT * FROM BarDeals.Users AS U ORDER BY U.Email";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        uxInsertGrid.DataSource = dt;
                        uxInsertGrid.ReadOnly = true;
                    }
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void uxInsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "(localdb)\\GabeLocal";
                builder.InitialCatalog = "CIS560";

                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql;

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    // Insert stuff
                    sql = "INSERT BarDeals.Users(Email) VALUES (N'" + uxEmailText.Text + "')";

                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    int rows = adapter.InsertCommand.ExecuteNonQuery();

                    if (rows < 1)
                    {
                        MessageBox.Show("Error. Zero rows affected.");
                    }
                    else
                    {
                        MessageBox.Show("Success, row inserted. See top row.");
                        sql = "SELECT * FROM BarDeals.Users AS U ORDER BY U.UserID DESC";

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            uxInsertGrid.DataSource = dt;
                            uxInsertGrid.ReadOnly = true;
                        }
                        connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
