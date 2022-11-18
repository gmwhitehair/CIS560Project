using System;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxQuery1 : Form
    {
        public uxQuery1()
        {
            InitializeComponent();
        }

        private void uxInsertButton_Click(object sender, EventArgs e)
        {
            uxInsertDeal n1 = new uxInsertDeal();
            n1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uxMain_Load(object sender, EventArgs e)
        {

        }

        private void uxInsertBarButton_Click(object sender, EventArgs e)
        {
            uxInsertBar n1 = new uxInsertBar();
            n1.Show();
        }

        private void uxInsertUsersButton_Click(object sender, EventArgs e)
        {
            uxInsertUser n1 = new uxInsertUser();
            n1.Show();
        }

        private void uxInsertCommentButton_Click(object sender, EventArgs e)
        {
            uxInsertComment n1 = new uxInsertComment();
            n1.Show();
        }

        private void uxInsertVotesButton_Click(object sender, EventArgs e)
        {
            uxInsertVotes n1 = new uxInsertVotes();
            n1.Show();
        }

        private void uxInsertCollegeTownButton_Click(object sender, EventArgs e)
        {
            uxInsertCollegeTown n1 = new uxInsertCollegeTown();
            n1.Show();
        }

        private void uxUpdateBarButton_Click(object sender, EventArgs e)
        {
            uxUpdateBar n1 = new uxUpdateBar();
            n1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uxUpdateDeal n1 = new uxUpdateDeal();
            n1.Show();
        }

        private void uxUpdateUser_Click(object sender, EventArgs e)
        {
            uxUpdateUser n1 = new uxUpdateUser();
            n1.Show();
        }

        private void uxDeleteUniversityButton_Click(object sender, EventArgs e)
        {
            uxDeleteCollegeTown n1 = new uxDeleteCollegeTown();
            n1.Show();
        }

        private void uxDeleteCommentButton_Click(object sender, EventArgs e)
        {
            uxDeleteComments n1 = new uxDeleteComments();
            n1.Show();
        }

        private void uxDeleteVotesButton_Click(object sender, EventArgs e)
        {
            uxDeleteVotes n1 = new uxDeleteVotes();
            n1.Show();
        }

        //named button6 for Query1. Oops. 
        private void button6_Click(object sender, EventArgs e)
        {
            uxQuery1Form n1 = new uxQuery1Form();
            n1.Show();
        }

        private void uxQuery2_Click(object sender, EventArgs e)
        {
            uxQuery2Form n1 = new uxQuery2Form();
            n1.Show();
        }

        private void uxQuery3_Click(object sender, EventArgs e)
        {
            uxQuery3Form n1 = new uxQuery3Form();
            n1.Show();
        }

        private void uxQuery4_Click(object sender, EventArgs e)
        {
            uxQuery4Form n1 = new uxQuery4Form();
            n1.Show();
        }

        private void uxQuery5_Click(object sender, EventArgs e)
        {
            uxQuery5Form n1 = new uxQuery5Form();
            n1.Show();
        }

        private void uxQuery6_Click(object sender, EventArgs e)
        {
            uxQuery6Form n1 = new uxQuery6Form();
            n1.Show();
        }

        private void uxQuery7_Click(object sender, EventArgs e)
        {
            uxQuery7Form n1 = new uxQuery7Form();
            n1.Show();
        }

        private void uxQuery8_Click(object sender, EventArgs e)
        {
            uxQuery8Form n1 = new uxQuery8Form();
            n1.Show();
        }

        private void uxCustomQueryButton_Click(object sender, EventArgs e)
        {
            uxCustomQuery n1 = new uxCustomQuery();
            n1.Show();
        }

        private void uxRestart_Click(object sender, EventArgs e)
        {
            ReinitializeTable.RemakeTable();
            ReinitializeTable.RepopulateTables();
        }

        private void uxPhysicalDatabaseModelButton_Click(object sender, EventArgs e)
        {
            uxPhysicalDatabaseImage n1 = new uxPhysicalDatabaseImage();
            n1.Show();
        }
    }
}
