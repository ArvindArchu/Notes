using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;

namespace Notes
{
    public partial class form1Main : Form
    {
        DataTable table;
        public static string textboxtxt;
        

        public form1Main()
        {
            InitializeComponent();
            textBox1.Text = textboxtxt;         
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Message", typeof(string));

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.Filter = "Text files (*.txt)|*.txt";
            sfdlg.Title = "Save an text file";
            sfdlg.FilterIndex = 2;
            sfdlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfdlg.RestoreDirectory = true;
            sfdlg.CheckPathExists = true;


            if (sfdlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfdlg.FileName, textBox1.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            textBox1.Clear();

            OpenFileDialog fdlg = new OpenFileDialog();

            fdlg.InitialDirectory = "c:\\";
            fdlg.Title = "Open a text file";
            fdlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            fdlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fdlg.CheckFileExists = true;
            fdlg.CheckPathExists = true;


            if (fdlg.ShowDialog() == DialogResult.OK)
            {

                filePath = fdlg.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(fdlg.FileName);
                                        
            }            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            form2Settings form1 = new form2Settings();
            form1.IsMdiContainer = true;
            form1.Show();
            textBox1.Text = textboxtxt;
     
        }
    }
}
