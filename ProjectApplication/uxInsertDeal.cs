using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxInsertDeal : Form
    {
        public uxInsertDeal()
        {
            InitializeComponent();
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

                    sql = "SELECT * FROM BarDeals.Deals";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            String s = "";
                            while (reader.Read())
                            {
                                s += reader.GetInt32(0) + " ";
                                s += reader.GetInt32(1) + " ";
                                s += reader.GetString(2) + " ";
                                s += reader.GetString(4) + " ";
                                s += reader.GetString(5) + " ";
                                s += reader.GetString(6) + " ";
                                s += "\n";
                            }
                           // MessageBox mb;
                            MessageBox.Show(s);
                        }
                    }

                    // Insert stuff
                    sql = "INSERT BarDeals.Deals(B.BarID, [Description], HappyHour, [DayOfWeek], StartTime, EndTime) " +
                        "SELECT B.BarID, Temp.[Description], Temp.HappyHour, Temp.[DayOfWeek], Temp.StartTime, Temp.EndTime " +
                        "FROM ( " +
                        "VALUES " +
                        "(N'" + uxNameText.Text + "', N'" + uxDescriptionText.Text + "', " + Int32.Parse(uxHappyHourText.Text) + ", N'" + uxDayOfWeekText.Text + "', N'" + uxStartTimeText.Text + "', N'" + uxEndTimeText.Text + "') " +
                        ") Temp(BarName, [Description], HappyHour, [DayOfWeek], StartTime, EndTime) " +
                        "INNER JOIN BarDeals.Bars AS B ON B.BarName = Temp.BarName AND B.CollegeTownID = 45";

                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    adapter.InsertCommand.ExecuteNonQuery();


                    // MSGBOX that shows after insert
                    sql = "SELECT * FROM BarDeals.Deals AS D ORDER BY D.DealID DESC";
                    
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            String s = "";
                            while (reader.Read())
                            {
                                s += reader.GetInt32(0) + " ";
                                s += reader.GetInt32(1) + " ";
                                s += reader.GetString(2) + " ";
                                s += reader.GetString(4) + " ";
                                s += reader.GetString(5) + " ";
                                s += reader.GetString(6) + " ";
                                s += "\n";
                            }
                            MessageBox.Show(s);
                        }
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
