using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApplication
{
    public partial class uxInsert : Form
    {
        public uxInsert()
        {
            InitializeComponent();
        }

        private void uxDeal_Click(object sender, EventArgs e)
        {
            uxDeal deal = new uxDeal();
            deal.Show();
        }
    }
}
