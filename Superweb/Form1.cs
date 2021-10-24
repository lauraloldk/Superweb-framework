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

namespace Superweb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Textobj txtobj = new Textobj();
        Pageobj pgobj = new Pageobj();
        String checkprop;
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
            webBrowser1.Navigate(sfd.FileName);
        }

        private void addTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            propertyGrid1.SelectedObject = txtobj;
            txtobj.Type = "txt";
            txtobj.Text = "Hello World";
            txtobj.Color = "black";
            checkprop = "txt";
            
        }

        class Textobj
        {
            public string Type { get; set; }
            public string Text { get; set; }
            public string Color { get; set; }

            public string p_or_h1 { get; set; }
        }

        class Pageobj
        {
            public string Type { get; set; }
            
            public string Color { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkprop == "txt") 
            {
                richTextBox1.AppendText("<" +txtobj.p_or_h1 + " style='color:" + txtobj.Color + "'>" + txtobj.Text + "</p>");
            } 
            if(checkprop == "Page")
            {
                richTextBox1.AppendText("<body style='background-color:" + pgobj.Color + "'>");
            }
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (checkprop == "txt") 
            {
                if (txtobj.Type != "txt") 
                {
                    MessageBox.Show("You cant change the type, or the compiler will not work");
                    txtobj.Type = "txt";
                    propertyGrid1.Refresh();
                }
            }
            if (checkprop == "Page")
            {
                if (pgobj.Type != "Page")
                {
                    MessageBox.Show("You cant change the type, or the compiler will not work");
                    pgobj.Type = "Page";
                    propertyGrid1.Refresh();
                }
            }
        }

        private void htmlTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("<html>");
        }

        private void htmlEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("</html>");
        }

        private void bodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = pgobj;
            pgobj.Type = "Page";
            pgobj.Color = "white";
            checkprop = "Page";
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("</body>");
        }
    }

    
}
