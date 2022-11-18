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
    public partial class uxInsertComment : Form
    {
        public uxInsertComment()
        {
            InitializeComponent();
        }

        private void uxInsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "(localdb)\\MSSQLLocalDb";
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
                    adapter.InsertCommand.ExecuteNonQuery();

                    /*
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
                            uxDisplay.Text = s;
                        }
                    }
                    */
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
