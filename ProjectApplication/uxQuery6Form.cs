using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxQuery6Form : Form
    {
        public uxQuery6Form()
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

                    sql = "SELECT B.BarName, D.* FROM BarDeals.Deals AS D INNER JOIN BarDeals.Bars AS B ON B.BarID = D.BarId ORDER BY D.DealID DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        uxInsertGrid.DataSource = dt;
                        uxInsertGrid.ReadOnly = true;
                    }
                    connection.Close();
                    MessageBox.Show("Success, query executed.");
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
