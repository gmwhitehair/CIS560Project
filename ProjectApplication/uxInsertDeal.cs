using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxInsertDeal : Form
    {
        public uxInsertDeal()
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
                    sql = "SELECT B.BarName, D.* FROM BarDeals.Deals AS D INNER JOIN BarDeals.Bars AS B ON B.BarID = D.BarId ORDER BY B.BarID DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        uxInsertDealsGrid.DataSource = dt;
                        uxInsertDealsGrid.ReadOnly = true;
                    }
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void uxInsert_Click(object sender, EventArgs e)
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
                    // MSGBOX that shows pre insert

                    // Insert stuff
                    sql = "INSERT BarDeals.Deals(B.BarID, [Description], HappyHour, [DayOfWeek], StartTime, EndTime) " +
                        "SELECT B.BarID, Temp.[Description], Temp.HappyHour, Temp.[DayOfWeek], Temp.StartTime, Temp.EndTime " +
                        "FROM ( " +
                        "VALUES " +
                        "(N'" + uxNameText.Text + "', N'" + uxDescriptionText.Text + "', " + Int32.Parse(uxHappyHourText.Text) + ", N'" + uxDayOfWeekText.Text + "', N'" + uxStartTimeText.Text + "', N'" + uxEndTimeText.Text + "') " +
                        ") Temp(BarName, [Description], HappyHour, [DayOfWeek], StartTime, EndTime) " +
                        "INNER JOIN BarDeals.Bars AS B ON B.BarName = Temp.BarName AND B.CollegeTownID = 45";

                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    int rows = adapter.InsertCommand.ExecuteNonQuery();

                    if (rows < 1)
                    {
                        MessageBox.Show("Error. Zero rows affected.");
                    }
                    else
                    {
                        MessageBox.Show("Success, row inserted. See top row.");
                        sql = "SELECT B.BarName, D.* FROM BarDeals.Deals AS D INNER JOIN BarDeals.Bars AS B ON B.BarID = D.BarId ORDER BY D.DealID DESC";

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            uxInsertDealsGrid.DataSource = dt;
                            uxInsertDealsGrid.ReadOnly = true;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
