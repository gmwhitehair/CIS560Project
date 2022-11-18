using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxQuery1Form : Form
    {
        public uxQuery1Form()
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

                    sql = "SELECT B.BarName, B.City, B.State, CT.University, COUNT(DISTINCT D.DealID) AS DealCount FROM BarDeals.Bars AS B INNER JOIN BarDeals.CollegeTowns AS CT ON CT.CollegeTownID = B.CollegeTownID INNER JOIN BarDeals.Deals AS D ON D.BarID = B.BarID GROUP BY B.BarID, B.BarName, B.City, B.State, CT.University ORDER BY DealCount DESC";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
