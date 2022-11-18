using System;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxMain : Form
    {
        public uxMain()
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
    }
}
