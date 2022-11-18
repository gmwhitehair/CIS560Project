using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxDeleteVotes : Form
    {
        public uxDeleteVotes()
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
                    sql = "SELECT U.Email, B.BarName, D.Description, D.DayOfWeek, V.* FROM BarDeals.Votes AS V INNER JOIN BarDeals.Users AS U ON U.UserID = V.UserID INNER JOIN BarDeals.Deals AS D ON D.DealID = V.DealID INNER JOIN BarDeals.Bars AS B ON B.BarID = D.BarID ORDER BY V.UserID DESC";
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                    sql = "DELETE V " +
                        "FROM BarDeals.Votes V " +
                        "INNER JOIN BarDeals.Users U ON U.UserID = V.UserID " +
                        "INNER JOIN BarDeals.Deals D ON D.DealID = V.DealID " +
                        "INNER JOIN BarDeals.Bars B ON B.BarID = D.BarID " +
                        "WHERE U.Email = N'" + uxEmailText.Text + "' AND B.BarName = N'" + uxBarText.Text + "' AND D.Description = N'" + uxDealText.Text + "' AND D.DayOfWeek = N'" + uxDayText.Text + "'";

                    adapter.DeleteCommand = new SqlCommand(sql, connection);
                    int rows = adapter.DeleteCommand.ExecuteNonQuery();


                    if (rows < 1)
                    {
                        MessageBox.Show("Error. Zero rows affected.");
                    }
                    else
                    {
                        MessageBox.Show("Success, row deleted.");
                        sql = "SELECT U.Email, B.BarName, D.Description, D.DayOfWeek, V.* FROM BarDeals.Votes AS V INNER JOIN BarDeals.Users AS U ON U.UserID = V.UserID INNER JOIN BarDeals.Deals AS D ON D.DealID = V.DealID INNER JOIN BarDeals.Bars AS B ON B.BarID = D.BarID ORDER BY V.UserID DESC";

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
