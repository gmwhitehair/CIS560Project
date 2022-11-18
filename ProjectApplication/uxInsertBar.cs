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
    public partial class uxInsertBar : Form
    {
        public uxInsertBar()
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
                    sql = "INSERT BarDeals.Bars(CollegeTownID, BarName, [Address], GoogleRating, City, [State]) " +
                        "SELECT CT.CollegeTownID, Temp.BarName, Temp.[Address], Temp.GoogleRating, Temp.City, Temp.[State] " +
                        "FROM ( " +
                        "VALUES (N'" + uxNameText.Text + "', N'" + uxAddressText.Text + "', N'" + uxCityText.Text + "', N'" + uxStateText.Text + "', N'" + uxUniversityText.Text + "', " + uxRatingUpDown.Value + ") " +
                        ") Temp(BarName, [Address], City, [State], University, GoogleRating) " +
                        "INNER JOIN BarDeals.CollegeTowns AS CT ON CT.University = Temp.University AND CT.[State] = Temp.[State] AND CT.[City] = Temp.[City]";

                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    int rows = adapter.InsertCommand.ExecuteNonQuery();


                    if (rows < 1)
                    {
                        MessageBox.Show("Error. Zero rows affected.");
                    }
                    else
                    {
                        MessageBox.Show("Success, row inserted. See top row.");
                        sql = "SELECT B.*, CT.University FROM BarDeals.Bars AS B INNER JOIN BarDeals.CollegeTowns AS CT ON CT.CollegeTownID = B.CollegeTownID ORDER BY B.BarID DESC";

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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
