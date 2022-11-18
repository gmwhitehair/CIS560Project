using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxUpdateUser : Form
    {
        public uxUpdateUser()
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
                    sql = "SELECT * FROM BarDeals.Users AS U ORDER BY U.UserID";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void uxUpdateButton_Click(object sender, EventArgs e)
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

                    int rows1 = 0;
                    if (uxChangeEmail.Text != "")
                    {
                        sql = "UPDATE BarDeals.Users " +
                            "SET Email = N'" + uxChangeEmail.Text + "'" +
                            " WHERE UserID = " +
                            "( " +
                                "Select U.UserID " +
                                "FROM BarDeals.Users U " +
                                "WHERE U.Email = N'" + uxEmail.Text + "'" +
                            ")";
                        adapter.UpdateCommand = new SqlCommand(sql, connection);
                        rows1 = adapter.UpdateCommand.ExecuteNonQuery();
                    }

                    if (rows1 < 1)
                    {
                        MessageBox.Show("Error. Zero rows affected.");
                    }
                    else
                    {
                        MessageBox.Show("Success, row updated!");
                        sql = "SELECT * FROM BarDeals.Users AS U WHERE U.Email = N'" + (uxChangeEmail.Text != "" ? uxChangeEmail.Text : uxEmail.Text) + "'";

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
