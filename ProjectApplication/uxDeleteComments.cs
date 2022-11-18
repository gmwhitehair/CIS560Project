using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxDeleteComments : Form
    {
        public uxDeleteComments()
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
                    sql = "SELECT U.Email, C.* FROM BarDeals.Comments AS C INNER JOIN BarDeals.Users AS U ON U.UserID = C.UserID ORDER BY C.UserID DESC";
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
                    sql = "DELETE C " +
                    "FROM BarDeals.Comments C " +
                    "INNER JOIN BarDeals.Users U ON U.UserID = C.UserID " +
                    "WHERE U.Email = N'" + uxEmailText.Text + "' AND C.CommentID = '" + uxCommentIDText.Text + "'";

                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    int rows = adapter.InsertCommand.ExecuteNonQuery();


                    if (rows < 1)
                    {
                        MessageBox.Show("Error. Zero rows affected.");
                    }
                    else
                    {
                        MessageBox.Show("Success, row deleted.");
                        sql = "SELECT U.Email, C.* FROM BarDeals.Comments AS C INNER JOIN BarDeals.Users AS U ON U.UserID = C.UserID ORDER BY C.UserID DESC";

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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
