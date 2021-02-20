using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class form2Settings : Form
    {
        public form2Settings()
        {
            InitializeComponent();

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            VScrollBar vscroll = new VScrollBar();
            //vscroll.Scroll += new System.Windows.Forms.ScrollEventHandler(vscroll_Scroll);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form3Text form2 = new form3Text();
            form2.TopLevel = false;
            form2.MdiParent = this;
            form2.Show();
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
