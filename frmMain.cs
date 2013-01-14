using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageCaptionEdit
{
    public partial class frmMain : Form
    {
        public frmMain(string[] Args)
        {
            InitializeComponent();
            FileListBox.ContextMenu = contextMenu1;

            this.Text = "Image Caption Edit - v" + Application.ProductVersion;

            if (Args.Length != 0)
            {
                SelectFile(Args[0]);
            }
        }

        public System.Collections.ArrayList FileNameList = new System.Collections.ArrayList();
        public string CurrentFileName;
        string CurrentTempFile;
        public int FileIndex;
        private bool dirty;

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files |*.png;*.jpg;*.tif;*.bmp;*.pcx";
            openFileDialog1.ShowDialog();
            //MessageBox.Show(openFileDialog1.FileName);
            if (!System.IO.File.Exists(openFileDialog1.FileName)) return;
            SelectFile(openFileDialog1.FileName);
        }

        public void FileListViewPopulate()
        {
            System.IO.FileInfo f = new System.IO.FileInfo(CurrentFileName);
            System.IO.DirectoryInfo dir;
            if (System.IO.File.Exists(CurrentFileName))
            {
                //file exists, so select containing directory
                dir = new System.IO.DirectoryInfo(f.Directory.FullName);
            }
            else
            {
                //check if we're entering a directory..
                if (!System.IO.Directory.Exists(CurrentFileName))
                {
                    return;
                }
                dir = new System.IO.DirectoryInfo(CurrentFileName);
            }

            string[] FileTypes = new string[5] { "*.jpg", "*.png", "*.tif", "*.bmp", "*.pcx" };

            foreach (string type in FileTypes)
            {
                if (FileTypeCombobox.SelectedIndex != 1 || type == "*.jpg")
                {
                    foreach (System.IO.FileInfo fi in dir.GetFiles(type))
                    {
                        FileListBox.Items.Add(fi.Name + " " + fi.CreationTime);
                        FileNameList.Add(fi.FullName);
                        //FileListBox.Items.
                    }
                }
            }

            for (int i = 0; i < FileNameList.Count; i++)
            {
                if (FileNameList[i].ToString() == CurrentFileName)
                {
                    FileIndex = i;
                    FileListBox.SelectedIndex = i;
                }
            }
        }

        public void SelectFile(string filename)
        {
            if (dirty == true)
            {
                DialogResult result;
                result = MessageBox.Show("Do you want to save changes to \"" + CurrentFileName + "\"?","Image Caption Edit",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes) 
                {
                    SaveButton_Click(this,EventArgs.Empty);
                }
                else if (result == DialogResult.Cancel) return;
            }
            if (filename == "") return;
            System.IO.FileInfo f = new System.IO.FileInfo(filename);

            if (f.Exists)
            {
                CurrentTempFile = System.IO.Path.GetTempPath() + "__ImageCaptionEdit__" + System.IO.Path.GetRandomFileName();

                //load the image
                Image theImage = new Bitmap(filename);
                //save it as a .jpg
                theImage.Save(CurrentTempFile, System.Drawing.Imaging.ImageFormat.Jpeg);
                //close it
                theImage.Dispose();
                
                //System.IO.File.Copy(filename, CurrentTempFile,true);

                pictureBox1.Load(CurrentTempFile);
                EXIFData.GetData(CurrentTempFile);
                DisplayData();
                FNameTxtBox.Text = f.Directory.FullName;
            }
            else
            {
                //check if we're entering a directory..
                if (!System.IO.Directory.Exists(filename))
                {
                    return;
                }
                FNameTxtBox.Text = filename;
            }

            dirty = false;

            FileListBox.Items.Clear();
            FileNameList.Clear();
            CurrentFileName = filename;

            SetTitle();
            FileListViewPopulate();
        }

        private void DisplayData()
        {
            HeaderTextBox.Text = EXIFData.header;
            SideTextBox.Text = EXIFData.sideinfo;
            CaptionTextBox.Text = EXIFData.description;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (!System.IO.File.Exists(CurrentFileName)) return;

            EXIFData.header = HeaderTextBox.Text;
            EXIFData.sideinfo = SideTextBox.Text;
            EXIFData.description = CaptionTextBox.Text;

            string filename = CurrentFileName;
            System.IO.FileInfo f = new System.IO.FileInfo(CurrentFileName);

            if (f.Extension.ToUpper() != ".jpg".ToUpper())
            {
                filename = f.FullName.TrimEnd(f.Extension.ToCharArray());
                filename = filename + ".jpg";
                if (System.IO.File.Exists(filename))
                {
                    if (MessageBox.Show("File: " + filename + " already exists.  Overwite?", "Overwite?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    {
                        return;
                    }
                }
            }

            EXIFData.SaveData(CurrentTempFile,filename);
            dirty = false;
            SetTitle();
            FileListViewPopulate();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FileNameList.Count; i++)
            {
                if (FileNameList[i].ToString() == CurrentFileName)
                {
                    if (i >= FileNameList.Count - 1) i = -1;
                    SelectFile(FileNameList[i + 1].ToString());
                    return;
                }
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FileNameList.Count; i++)
            {
                if (FileNameList[i].ToString() == CurrentFileName)
                {
                    if (i == 0) i = FileNameList.Count;
                    SelectFile(FileNameList[i - 1].ToString());
                    return;
                }
            }
        }

        private void FileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileIndex == FileListBox.SelectedIndex) return;
            int SelIndex;
            SelIndex = FileListBox.SelectedIndex;
            if (FileListBox.SelectedIndex >= FileListBox.Items.Count ||
                FileListBox.SelectedIndex < 0)
            {
                SelIndex = FileListBox.Items.Count - 1;
            }
            //MessageBox.Show(FileListBox.SelectedIndex.ToString());
            SelectFile(FileNameList[SelIndex].ToString());
        }

        private void FNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            SelectFile(FNameTxtBox.Text);
        }

        private void PrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string TempFile;
            //MessageBox.Show("Print Preview..");
            TempFile = System.IO.Path.GetTempPath() + "__ImageCaptionEdit__" + System.IO.Path.GetRandomFileName();
            System.IO.File.Copy(CurrentFileName, TempFile);

            if (!System.IO.File.Exists(CurrentFileName)) return;

            EXIFData.header = HeaderTextBox.Text;
            EXIFData.sideinfo = SideTextBox.Text;
            EXIFData.description = CaptionTextBox.Text;

            EXIFData.SaveData(CurrentTempFile, TempFile);     //save current file to the temp file
            PrintPreviewMine.TempFileName = TempFile;
            PrintPreviewMine.FileName = CurrentFileName;
            PrintPreviewMine preview = new PrintPreviewMine();
            preview.Show();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintPreviewMine.TempFileName = CurrentTempFile;
            PrintPreviewMine.FileName = CurrentFileName;
            PrintPreviewMine preview = new PrintPreviewMine();
            preview.PrintImage();
        }

        string backupHeader;
        string backupSide;
        string backupCaption;

        private void CopyAllFieldsButton_Click(object sender, EventArgs e)
        {
            backupHeader = HeaderTextBox.Text;
            backupSide = SideTextBox.Text;
            backupCaption = CaptionTextBox.Text;
        }

        private void PasteAllFieldsButton_Click(object sender, EventArgs e)
        {
            HeaderTextBox.Text = backupHeader;
            SideTextBox.Text = backupSide;
            CaptionTextBox.Text = backupCaption;
            HeaderTextBox.Focus();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            dirty = true;
            SetTitle();
        }

        private void SetTitle()
        {
            string displayname;

            if (CurrentFileName == null) return;
            System.IO.FileInfo fi = new System.IO.FileInfo(CurrentFileName);
            displayname = fi.Name;
            if (displayname.Length > 40)
            {
                displayname = displayname.Remove(40);
                displayname += "...";
            }

            if (dirty) displayname += "*";
            this.Text = "Image Caption Edit - " + displayname;
        }

        private void FileTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectFile(FNameTxtBox.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Print all selected files?", "Print selection", MessageBoxButtons.YesNo) == DialogResult.No) return;
            //foreach (int index in FileListBox.SelectedItems.IndexOf(FileListBox))
            //{
            //    MessageBox.Show(FileListBox.Items[index].ToString);
            //}

            //ListBox.SelectedObjectCollection SelectedItems = FileListBox.SelectedItems;

            for (int i = 0; i < FileListBox.Items.Count; i++)
            {
                if (FileListBox.SelectedItems.Contains(FileListBox.Items[i]))
                {
                    //MessageBox.Show(FileListBox.Items[i].ToString());
                    //MessageBox.Show(FileNameList[i].ToString());
                    
                    PrintPreviewMine.TempFileName = System.IO.Path.GetTempPath() + "__ImageCaptionEdit__" + System.IO.Path.GetRandomFileName();
                    
                    //load the image
                    Image theImage = new Bitmap(FileNameList[i].ToString());
                    //save it as a .jpg in a temporary file
                    theImage.Save(PrintPreviewMine.TempFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //close it
                    theImage.Dispose();

                    PrintPreviewMine.FileName = FileNameList[i].ToString();     //save filename if needed...
                    PrintPreviewMine preview = new PrintPreviewMine();
                    preview.PrintImage();
                }
            }

            //foreach (string item in FileListBox.SelectedItems)
            //{
            //    MessageBox.Show(item);
            //}
        }
    }
}