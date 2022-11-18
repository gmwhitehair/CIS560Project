using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxUpdateBar : Form
    {
        public uxUpdateBar()
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
                    sql = "SELECT B.*, CT.University FROM BarDeals.Bars AS B INNER JOIN BarDeals.CollegeTowns AS CT ON CT.CollegeTownID = B.CollegeTownID ORDER BY B.City DESC";
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
                    int rows2 = 0;
                    int rows3 = 0;
                    if (uxChangeBar.Text != "")
                    {
                        sql = "UPDATE BarDeals.Bars " +
                            "SET BarName = N'" + uxChangeBar.Text + "'" +
                            " WHERE BarID = " +
                            "( " +
                                "Select B.BarID " +
                                "FROM BarDeals.Bars B " +
                                "INNER JOIN BarDeals.CollegeTowns C ON C.CollegeTownID = B.CollegeTownID " +
                                "WHERE C.University = N'" + uxUniversity.Text + "' AND B.BarName = N'" + uxBar.Text + "' " +
                            ")";
                        adapter.UpdateCommand = new SqlCommand(sql, connection);
                        rows2 = adapter.UpdateCommand.ExecuteNonQuery();
                    }

                    if (uxChangeAddress.Text != "")
                    {

                        sql = "UPDATE BarDeals.Bars " +
                            "SET Address = N'" + uxChangeAddress.Text + "'" +
                            " WHERE BarID = " +
                            "( " +
                                "Select B.BarID " +
                                "FROM BarDeals.Bars B " +
                                "INNER JOIN BarDeals.CollegeTowns C ON C.CollegeTownID = B.CollegeTownID " +
                                "WHERE C.University = N'" + uxUniversity.Text + "' AND B.BarName = N'" + (uxChangeBar.Text != "" ? uxChangeBar.Text : uxBar.Text) + "' " +
                            ")";
                        adapter.UpdateCommand = new SqlCommand(sql, connection);
                        rows3 = adapter.UpdateCommand.ExecuteNonQuery();
                    }

                    if (uxRatingUpDown.Value > 0)
                    {
                        sql = "UPDATE BarDeals.Bars " +
                            "SET GoogleRating = " + uxRatingUpDown.Value +
                            " WHERE BarID = " +
                            "( " +
                                "Select B.BarID " +
                                "FROM BarDeals.Bars B " +
                                "INNER JOIN BarDeals.CollegeTowns C ON C.CollegeTownID = B.CollegeTownID " +
                                "WHERE C.University = N'" + uxUniversity.Text + "' AND B.BarName = N'" + (uxChangeBar.Text != "" ? uxChangeBar.Text : uxBar.Text) + "' " +
                            ")";
                        adapter.UpdateCommand = new SqlCommand(sql, connection);
                        rows1 = adapter.UpdateCommand.ExecuteNonQuery();
                    }



                    if (rows1 < 1 && rows2 < 1 && rows3 < 1)
                    {
                        MessageBox.Show("Error. Zero rows affected.");
                    }
                    else
                    {
                        MessageBox.Show("Success, row updated!");
                        sql = "SELECT B.*, CT.University FROM BarDeals.Bars AS B INNER JOIN BarDeals.CollegeTowns AS CT ON CT.CollegeTownID = B.CollegeTownID WHERE B.BarName = N'" + (uxChangeBar.Text != "" ? uxChangeBar.Text : uxBar.Text) + "' AND CT.University = N'" + uxUniversity.Text + "'";

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uxUpdateBar_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
