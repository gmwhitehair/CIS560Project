using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxInsertComment : Form
    {
        public uxInsertComment()
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
                    sql = "INSERT BarDeals.Comments(U.UserID, [Text], TimeSent) " +
                    "SELECT U.UserID, V.[Text], V.TimeSent " +
                    "FROM ( " +
                    "VALUES (N'" + uxEmailText.Text + "', N'" + uxText.Text + "', '" + uxTimeText.Text + "') " +
                    ") V(Email, [Text], TimeSent) " +
                    "INNER JOIN BarDeals.Users U ON U.Email = V.Email";

                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    int rows = adapter.InsertCommand.ExecuteNonQuery();


                    if (rows < 1)
                    {
                        MessageBox.Show("Error. Zero rows affected.");
                    }
                    else
                    {
                        MessageBox.Show("Success, row inserted. See top row.");
                        sql = "SELECT U.Email, C.* FROM BarDeals.Comments AS C INNER JOIN BarDeals.Users AS U ON U.UserID = C.UserID ORDER BY C.CommentID DESC";

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

        private void uxInsertComment_Load(object sender, EventArgs e)
        {

        }
    }
}
