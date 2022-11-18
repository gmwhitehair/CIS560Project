using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxQuery2Form : Form
    {
        public uxQuery2Form()
        {
            InitializeComponent();
        }

        private void uxRunQueryButton_Click(object sender, EventArgs e)
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

                    sql = "SELECT COUNT(V.Vote) AS VoteCount, B.BarName, D.[Description], D.[DayOfWeek], D.StartTime, D.EndTime, C.University, C.City, C.[State]" +
                        " FROM BarDeals.Votes V " +
                        "INNER JOIN BarDeals.Deals D ON D.DealID = V.DealID " +
                        "INNER JOIN BarDeals.Bars B ON B.BarId = D.BarID " +
                        "INNER JOIN BarDeals.CollegeTowns C ON C.CollegeTownID = B.CollegeTownID " +
                        "GROUP BY C.University, C.City, C.[State], B.BarName, D.[Description], D.[DayOfWeek], D.StartTime, D.EndTime ORDER BY VoteCount DESC";
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

        private void uxInsertGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
