﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxQuery3Form : Form
    {
        public uxQuery3Form()
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

                    sql = "SELECT U.UserID, U.Email, COUNT(DISTINCT V.VoteID) AS VoteCount, COUNT(DISTINCT C.CommentID) AS CommentCount, (COUNT(DISTINCT V.VoteID) + COUNT(DISTINCT C.CommentID)) AS TotalCount FROM BarDeals.Users AS U INNER JOIN BarDeals.Votes AS V ON V.UserID = U.UserID INNER JOIN BarDeals.Comments AS C ON C.UserID = U.UserID GROUP BY U.Email, U.UserID ORDER BY TotalCount DESC";
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
