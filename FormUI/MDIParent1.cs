using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class MDIParent1 : Form
    {
        

        public MDIParent1(string role)
        {
            InitializeComponent();
            Status_label.Text = role;
        }


        private void biodataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard ss = new Dashboard();
            ss.MdiParent = this;
            ss.Show();



        }




        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void Status_label_Click(object sender, EventArgs e)
        {

        }
    }
}
