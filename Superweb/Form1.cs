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
            txtobj.Name = "txt";
            txtobj.Text = "Hello World";
            txtobj.Color = "black";
            checkprop = "txt";
            
        }

        class Textobj
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public string Color { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtobj.Name == "txt") 
            {
                richTextBox1.AppendText("<p style='color:" + txtobj.Color + "'>" + txtobj.Text + "</p>");
            } 
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (checkprop == "txt") 
            {
                if (txtobj.Name != "txt") 
                {
                    MessageBox.Show("You cant change the name, or the compiler will not work");
                    txtobj.Name = "txt";
                    propertyGrid1.Refresh();
                }
            }   
        }
    }

    
}
