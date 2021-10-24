
namespace Superweb
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.jSObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(658, 33);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(197, 406);
            this.propertyGrid1.TabIndex = 1;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.objectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // objectsToolStripMenuItem
            // 
            this.objectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPageToolStripMenuItem,
            this.addTextToolStripMenuItem,
            this.jSObjectsToolStripMenuItem});
            this.objectsToolStripMenuItem.Name = "objectsToolStripMenuItem";
            this.objectsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.objectsToolStripMenuItem.Text = "Objects";
            // 
            // addPageToolStripMenuItem
            // 
            this.addPageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPageToolStripMenuItem,
            this.htmlTagToolStripMenuItem,
            this.htmlEndToolStripMenuItem,
            this.bodyToolStripMenuItem});
            this.addPageToolStripMenuItem.Name = "addPageToolStripMenuItem";
            this.addPageToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addPageToolStripMenuItem.Text = "Page Objects";
            // 
            // newPageToolStripMenuItem
            // 
            this.newPageToolStripMenuItem.Name = "newPageToolStripMenuItem";
            this.newPageToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.newPageToolStripMenuItem.Text = "New Page";
            // 
            // htmlTagToolStripMenuItem
            // 
            this.htmlTagToolStripMenuItem.Name = "htmlTagToolStripMenuItem";
            this.htmlTagToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.htmlTagToolStripMenuItem.Text = "html tag";
            this.htmlTagToolStripMenuItem.Click += new System.EventHandler(this.htmlTagToolStripMenuItem_Click);
            // 
            // htmlEndToolStripMenuItem
            // 
            this.htmlEndToolStripMenuItem.Name = "htmlEndToolStripMenuItem";
            this.htmlEndToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.htmlEndToolStripMenuItem.Text = "html end";
            this.htmlEndToolStripMenuItem.Click += new System.EventHandler(this.htmlEndToolStripMenuItem_Click);
            // 
            // bodyToolStripMenuItem
            // 
            this.bodyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endToolStripMenuItem});
            this.bodyToolStripMenuItem.Name = "bodyToolStripMenuItem";
            this.bodyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.bodyToolStripMenuItem.Text = "body";
            this.bodyToolStripMenuItem.Click += new System.EventHandler(this.bodyToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.endToolStripMenuItem.Text = "End";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // addTextToolStripMenuItem
            // 
            this.addTextToolStripMenuItem.Name = "addTextToolStripMenuItem";
            this.addTextToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addTextToolStripMenuItem.Text = "Text Objects";
            this.addTextToolStripMenuItem.Click += new System.EventHandler(this.addTextToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 406);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(629, 367);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(643, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(643, 380);
            this.webBrowser1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jSObjectsToolStripMenuItem
            // 
            this.jSObjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alertToolStripMenuItem});
            this.jSObjectsToolStripMenuItem.Name = "jSObjectsToolStripMenuItem";
            this.jSObjectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jSObjectsToolStripMenuItem.Text = "JS Objects";
            this.jSObjectsToolStripMenuItem.Click += new System.EventHandler(this.jSObjectsToolStripMenuItem_Click);
            // 
            // alertToolStripMenuItem
            // 
            this.alertToolStripMenuItem.Name = "alertToolStripMenuItem";
            this.alertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alertToolStripMenuItem.Text = "alert";
            this.alertToolStripMenuItem.Click += new System.EventHandler(this.alertToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Superweb framework (build 3)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTextToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem newPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlEndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alertToolStripMenuItem;
    }
}

