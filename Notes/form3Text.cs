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
    public partial class form3Text : Form
    {
        public TextBox textBox12;
        
       

        public form3Text()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(150,50);
            textBox12.Text = form1Main.textboxtxt;
           

            FontDialog fontdlg = new FontDialog();

            fontdlg.ShowDialog();
            fontdlg.ShowColor = true;
            fontdlg.ShowEffects = true;
            fontdlg.ShowApply = true;
            fontdlg.ShowHelp = true;

            if(fontdlg.ShowDialog() != DialogResult.Cancel)
            {
                textBox12.Font = fontdlg.Font;
                textBox12.BackColor = fontdlg.Color;
            }

        }

        
    }
}
