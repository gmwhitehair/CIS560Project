using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxInsertVotes : Form
    {
        public uxInsertVotes()
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

        private void label4_Click(object sender, EventArgs e)
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
                    sql = "INSERT BarDeals.Votes(D.DealID, U.UserID, Vote) " +
                        "SELECT D.DealID, U.UserID, Vote " +
                        "FROM ( VALUES " +
                        "(N'" + uxEmailText.Text + "', " + uxInsertVotesUpDown.Value + ", N'" + uxBarText.Text + "', N'" + uxDealText.Text + "', N'" + uxDayText.Text + "') " +
                        ") Temp(Email, Vote, BarName, [Description], [DayOfWeek]) " +
                        "INNER JOIN BarDeals.Users AS U ON U.Email = Temp.Email " +
                        "INNER JOIN BarDeals.Deals AS D ON D.[Description] = Temp.[Description] AND D.[DayOfWeek] = Temp.[DayOfWeek] " +
                        "INNER JOIN BarDeals.Bars AS B ON B.CollegeTownID = 45 AND B.BarName = Temp.BarName";

                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    int rows = adapter.InsertCommand.ExecuteNonQuery();


                    if (rows < 1)
                    {
                        MessageBox.Show("Error. Zero rows affected.");
                    }
                    else
                    {
                        MessageBox.Show("Success, row inserted. See top row.");
                        sql = "SELECT U.Email, B.BarName, D.Description, D.DayOfWeek, V.* FROM BarDeals.Votes AS V INNER JOIN BarDeals.Users AS U ON U.UserID = V.UserID INNER JOIN BarDeals.Deals AS D ON D.DealID = V.DealID INNER JOIN BarDeals.Bars AS B ON B.BarID = D.BarID ORDER BY V.VoteID DESC";

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
