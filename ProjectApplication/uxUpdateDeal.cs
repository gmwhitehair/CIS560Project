using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxUpdateDeal : Form
    {
        public uxUpdateDeal()
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
                    sql = "SELECT B.BarName, CT.University, D.* FROM BarDeals.Deals AS D INNER JOIN BarDeals.Bars AS B ON B.BarID = D.BarId INNER JOIN BarDeals.CollegeTowns AS CT ON CT.CollegeTownID = B.CollegeTownID ORDER BY B.BarID DESC";
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

        private void uxUpdateButton_Click(object sender, EventArgs e)
        {
            String sql = "";
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "(localdb)\\GabeLocal";
                builder.InitialCatalog = "CIS560";

                SqlDataAdapter adapter = new SqlDataAdapter();

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    int rows1 = 0;
                    int rows2 = 0;
                    int rows3 = 0;
                    int rows4 = 0;

                    if (uxChangeStart.Text != "")
                    {
                        sql = "UPDATE BarDeals.Deals" +
                            " SET StartTime = N'" + uxChangeStart.Text + "'" +
                            " WHERE DealID = " +
                                "(" +
                                "SELECT D.DealID FROM BarDeals.Deals D " +
                                "INNER JOIN BarDeals.Bars AS B ON B.BarID = D.BarID " +
                                "INNER JOIN BarDeals.CollegeTowns AS CT ON CT.CollegeTownID = B.CollegeTownID " +
                                "WHERE CT.University = N'" + uxUniversity.Text + "' AND B.BarName = N'" + uxBar.Text + "'" +
                                " AND D.Description = N'" + uxDescription.Text + "' AND D.[DayOfWeek] = N'" + uxDay.Text + "'" +
                                ")";
                        adapter.UpdateCommand = new SqlCommand(sql, connection);
                        rows4 = adapter.UpdateCommand.ExecuteNonQuery();
                    }

                    if (uxChangeEnd.Text != "")
                    {
                        sql = "UPDATE BarDeals.Deals" +
                            " SET EndTime = N'" + uxChangeEnd.Text + "'" +
                            " WHERE DealID = " +
                                "(" +
                                "SELECT D.DealID FROM BarDeals.Deals D " +
                                "INNER JOIN BarDeals.Bars AS B ON B.BarID = D.BarID " +
                                "INNER JOIN BarDeals.CollegeTowns AS CT ON CT.CollegeTownID = B.CollegeTownID " +
                                "WHERE CT.University = N'" + uxUniversity.Text + "' AND B.BarName = N'" + uxBar.Text + "'" +
                                " AND D.Description = N'" + uxDescription.Text + "' AND D.[DayOfWeek] = N'" + uxDay.Text + "'" +
                                ")";
                        adapter.UpdateCommand = new SqlCommand(sql, connection);
                        rows3 = adapter.UpdateCommand.ExecuteNonQuery();
                    }

                    if (uxChangeDescription.Text != "")
                    {
                        sql = "UPDATE BarDeals.Deals" +
                            " SET Description = N'" + uxChangeDescription.Text + "'" +
                            " WHERE DealID = " +
                                "(" +
                                "SELECT D.DealID FROM BarDeals.Deals D " +
                                "INNER JOIN BarDeals.Bars AS B ON B.BarID = D.BarID " +
                                "INNER JOIN BarDeals.CollegeTowns AS CT ON CT.CollegeTownID = B.CollegeTownID " +
                                "WHERE CT.University = N'" + uxUniversity.Text + "' AND B.BarName = N'" + uxBar.Text + "'" +
                                " AND D.Description = N'" + uxDescription.Text + "' AND D.[DayOfWeek] = N'" + uxDay.Text + "'" +
                                ")";
                        adapter.UpdateCommand = new SqlCommand(sql, connection);
                        rows1 = adapter.UpdateCommand.ExecuteNonQuery();
                    }

                    if (uxChangeDay.Text != "")
                    {
                        sql = "UPDATE BarDeals.Deals" +
                            " SET DayOfWeek = N'" + uxChangeDay.Text + "'" +
                            " WHERE DealID = " +
                                "(" +
                                "SELECT D.DealID FROM BarDeals.Deals D " +
                                "INNER JOIN BarDeals.Bars AS B ON B.BarID = D.BarID " +
                                "INNER JOIN BarDeals.CollegeTowns AS CT ON CT.CollegeTownID = B.CollegeTownID " +
                                "WHERE CT.University = N'" + uxUniversity.Text + "' AND B.BarName = N'" + uxBar.Text + "'" +
                                " AND D.Description = N'" + (uxChangeDescription.Text != "" ? uxChangeDescription.Text : uxDescription.Text) + "' AND D.[DayOfWeek] = N'" + uxDay.Text + "'" +
                                ")";
                        adapter.UpdateCommand = new SqlCommand(sql, connection);
                        rows2 = adapter.UpdateCommand.ExecuteNonQuery();
                    }


                    if (rows1 < 1 && rows2 < 1 && rows3 < 1 && rows4 < 1)
                    {
                        MessageBox.Show("Error. Zero rows affected.");
                    }
                    else
                    {
                        MessageBox.Show("Success, row updated!");

                        sql = "SELECT B.BarName, CT.University, D.* FROM BarDeals.Deals AS D" +
                            " INNER JOIN BarDeals.Bars AS B ON B.BarID = D.BarId" +
                            " INNER JOIN BarDeals.CollegeTowns AS CT ON CT.CollegeTownID = B.CollegeTownID" +
                            " WHERE CT.University = N'" + uxUniversity.Text + "' AND B.BarName = N'" + uxBar.Text + "'" +
                                " AND D.Description = N'" + (uxChangeDescription.Text != "" ? uxChangeDescription.Text : uxDescription.Text) + "' AND D.[DayOfWeek] = N'" + (uxChangeDay.Text != "" ? uxChangeDay.Text : uxDay.Text) + "'";


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

                MessageBox.Show(sql);
            }
        }
    }
}
