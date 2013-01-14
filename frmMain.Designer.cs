namespace ImageCaptionEdit
{
    partial class frmMain
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
            this.FNameTxtBox = new System.Windows.Forms.TextBox();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.HeaderTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideTextBox = new System.Windows.Forms.TextBox();
            this.CaptionTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsJpegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteAllFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintPreviewButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.CopyAllFieldsButton = new System.Windows.Forms.Button();
            this.PasteAllFieldsButton = new System.Windows.Forms.Button();
            this.FileTypeCombobox = new System.Windows.Forms.ComboBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FNameTxtBox
            // 
            this.FNameTxtBox.Location = new System.Drawing.Point(2, 72);
            this.FNameTxtBox.Name = "FNameTxtBox";
            this.FNameTxtBox.Size = new System.Drawing.Size(213, 20);
            this.FNameTxtBox.TabIndex = 1;
            this.FNameTxtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FNameTxtBox_KeyDown);
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrevButton.Location = new System.Drawing.Point(634, 27);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(52, 38);
            this.PrevButton.TabIndex = 12;
            this.PrevButton.Text = "Prev";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Location = new System.Drawing.Point(692, 27);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(51, 38);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FileListBox
            // 
            this.FileListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.Location = new System.Drawing.Point(2, 124);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.FileListBox.Size = new System.Drawing.Size(213, 511);
            this.FileListBox.TabIndex = 14;
            this.FileListBox.SelectedIndexChanged += new System.EventHandler(this.FileListBox_SelectedIndexChanged);
            // 
            // HeaderTextBox
            // 
            this.HeaderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderTextBox.Location = new System.Drawing.Point(221, 72);
            this.HeaderTextBox.Name = "HeaderTextBox";
            this.HeaderTextBox.Size = new System.Drawing.Size(532, 20);
            this.HeaderTextBox.TabIndex = 3;
            this.HeaderTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(221, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SideTextBox
            // 
            this.SideTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SideTextBox.Location = new System.Drawing.Point(609, 98);
            this.SideTextBox.Multiline = true;
            this.SideTextBox.Name = "SideTextBox";
            this.SideTextBox.Size = new System.Drawing.Size(144, 379);
            this.SideTextBox.TabIndex = 4;
            this.SideTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // CaptionTextBox
            // 
            this.CaptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptionTextBox.Location = new System.Drawing.Point(221, 483);
            this.CaptionTextBox.Multiline = true;
            this.CaptionTextBox.Name = "CaptionTextBox";
            this.CaptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CaptionTextBox.Size = new System.Drawing.Size(532, 150);
            this.CaptionTextBox.TabIndex = 5;
            this.CaptionTextBox.Validated += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.OpenFileButton.Location = new System.Drawing.Point(2, 27);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(46, 39);
            this.OpenFileButton.TabIndex = 6;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(54, 27);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(52, 41);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save as Jpeg";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveAsJpegToolStripMenuItem,
            this.toolStripSeparator2,
            this.PrintPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // saveAsJpegToolStripMenuItem
            // 
            this.saveAsJpegToolStripMenuItem.Name = "saveAsJpegToolStripMenuItem";
            this.saveAsJpegToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsJpegToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveAsJpegToolStripMenuItem.Text = "Save As Jpeg";
            this.saveAsJpegToolStripMenuItem.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // PrintPreviewToolStripMenuItem
            // 
            this.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem";
            this.PrintPreviewToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.PrintPreviewToolStripMenuItem.Text = "Image Preview";
            this.PrintPreviewToolStripMenuItem.Click += new System.EventHandler(this.PrintPreviewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAllFieldsToolStripMenuItem,
            this.pasteAllFieldsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.optionsToolStripMenuItem.Text = "Edit";
            // 
            // copyAllFieldsToolStripMenuItem
            // 
            this.copyAllFieldsToolStripMenuItem.Name = "copyAllFieldsToolStripMenuItem";
            this.copyAllFieldsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.C)));
            this.copyAllFieldsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.copyAllFieldsToolStripMenuItem.Text = "Copy all fields";
            this.copyAllFieldsToolStripMenuItem.Click += new System.EventHandler(this.CopyAllFieldsButton_Click);
            // 
            // pasteAllFieldsToolStripMenuItem
            // 
            this.pasteAllFieldsToolStripMenuItem.Name = "pasteAllFieldsToolStripMenuItem";
            this.pasteAllFieldsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.V)));
            this.pasteAllFieldsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.pasteAllFieldsToolStripMenuItem.Text = "Paste all fields";
            this.pasteAllFieldsToolStripMenuItem.Click += new System.EventHandler(this.PasteAllFieldsButton_Click);
            // 
            // PrintPreviewButton
            // 
            this.PrintPreviewButton.Location = new System.Drawing.Point(112, 27);
            this.PrintPreviewButton.Name = "PrintPreviewButton";
            this.PrintPreviewButton.Size = new System.Drawing.Size(54, 41);
            this.PrintPreviewButton.TabIndex = 8;
            this.PrintPreviewButton.Text = "Image Preview";
            this.PrintPreviewButton.UseVisualStyleBackColor = true;
            this.PrintPreviewButton.Click += new System.EventHandler(this.PrintPreviewToolStripMenuItem_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(172, 27);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(52, 41);
            this.PrintButton.TabIndex = 9;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // CopyAllFieldsButton
            // 
            this.CopyAllFieldsButton.Location = new System.Drawing.Point(354, 27);
            this.CopyAllFieldsButton.Name = "CopyAllFieldsButton";
            this.CopyAllFieldsButton.Size = new System.Drawing.Size(57, 41);
            this.CopyAllFieldsButton.TabIndex = 10;
            this.CopyAllFieldsButton.Text = "Copy All Fields";
            this.CopyAllFieldsButton.UseVisualStyleBackColor = true;
            this.CopyAllFieldsButton.Click += new System.EventHandler(this.CopyAllFieldsButton_Click);
            // 
            // PasteAllFieldsButton
            // 
            this.PasteAllFieldsButton.Location = new System.Drawing.Point(417, 27);
            this.PasteAllFieldsButton.Name = "PasteAllFieldsButton";
            this.PasteAllFieldsButton.Size = new System.Drawing.Size(58, 41);
            this.PasteAllFieldsButton.TabIndex = 11;
            this.PasteAllFieldsButton.Text = "Paste All Fields";
            this.PasteAllFieldsButton.UseVisualStyleBackColor = true;
            this.PasteAllFieldsButton.Click += new System.EventHandler(this.PasteAllFieldsButton_Click);
            // 
            // FileTypeCombobox
            // 
            this.FileTypeCombobox.FormattingEnabled = true;
            this.FileTypeCombobox.Items.AddRange(new object[] {
            "Image Files |*.png;*.jpg;*.tif;*.bmp;*.pcx",
            "Jpeg Files |*.jpg"});
            this.FileTypeCombobox.Location = new System.Drawing.Point(2, 97);
            this.FileTypeCombobox.Name = "FileTypeCombobox";
            this.FileTypeCombobox.Size = new System.Drawing.Size(213, 21);
            this.FileTypeCombobox.TabIndex = 2;
            this.FileTypeCombobox.Text = "Image Files |*.png;*.jpg;*.tif;*.bmp;*.pcx";
            this.FileTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.FileTypeCombobox_SelectedIndexChanged);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Print Selected";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 637);
            this.Controls.Add(this.FileTypeCombobox);
            this.Controls.Add(this.PasteAllFieldsButton);
            this.Controls.Add(this.CopyAllFieldsButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.PrintPreviewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FNameTxtBox);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.HeaderTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SideTextBox);
            this.Controls.Add(this.CaptionTextBox);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Image Caption Edit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FNameTxtBox;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ListBox FileListBox;
        private System.Windows.Forms.TextBox HeaderTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SideTextBox;
        private System.Windows.Forms.TextBox CaptionTextBox;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsJpegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.Button PrintPreviewButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copyAllFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteAllFieldsToolStripMenuItem;
        private System.Windows.Forms.Button CopyAllFieldsButton;
        private System.Windows.Forms.Button PasteAllFieldsButton;
        private System.Windows.Forms.ComboBox FileTypeCombobox;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
    }
}

