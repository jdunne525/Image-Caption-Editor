using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageCaptionEdit
{
    public partial class PrintPreviewMine : Form
    {
        public int PageNumberToPrint = 1;   //1 indexed
        public int NumberOfPagestoPrint = 1;
        public Image pic;

        public PrintPreviewMine()
        {
            InitializeComponent();

            if (!System.IO.File.Exists(TempFileName)) return;

            //Create image object:
            pic = ImageCaption.CreateImageWithMetaData(TempFileName);

            //Load the image object onto the form:
            pictureBox1.Image = pic;

            //"Redraw" the image:
            pictureBox1.Invalidate();
        }

        static public string FileName;
        static public string TempFileName;

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Printing...");

            //PrintPreviewDialog dlg = new PrintPreviewDialog();
            //dlg.Document = ;
            //dlg.ShowDialog();
            //try
            //{
            //    streamToPrint = new System.IO.StreamReader(filePath);
            //    try
            //    {
            //        printFont = new Font("Arial", 10);
            //        PrintDocument pd = new PrintDocument();
            //        pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            //        // Print the document.
            //        pd.Print();
            //    }
            //    finally
            //    {
            //        streamToPrint.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //http://www.devcity.net/Articles/275/5/article.aspx

            //printPreviewDialog1.Document = PrintImageDocument;
            //printPreviewDialog1.ShowDialog();

            //This in turn calls PrintImageDocument_PrintPage() which pulls in the image to print.
            this.PrintImageDocument.Print();
        }

        public void PrintImage()
        {
            //This in turn calls PrintImageDocument_PrintPage() which pulls in the image to print.
            this.PrintImageDocument.Print();
        }

        /// <summary>
        /// This gets called immedately following this.PrintImageDocument.Print().  This method
        /// initializes the page number to print and the number of pages required to print.
        /// Following this method, PrintImageDocument_PrintPage() gets called once per page to actually
        /// add the data to print to each page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintImageDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            PageNumberToPrint = 1;  //1 indexed
            //Determine this value based on what is desired to print:
            NumberOfPagestoPrint = 1;
        }

        /// <summary>
        /// This function is how the printing actually works and how it gets tied to the image object.  
        /// This is the PrintPage method of the PrintImageDocument object that gets called when this.PrintImageDocument.Print() is called.
        /// This function gets called once per page and PageNumberToPrint keeps track of which page is being printed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PrintImageDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Load in the pic image object that was created when this form was loaded:
            Image ImageToPrint = pic;
            
            int height;
            int width;

            //Determine the X, Y coordinate of the top left corner of where to put the image:
            int BorderWidth = 30;
            int BorderHeight = 30;

            //fit to page width and height if necessary..
            height = ImageToPrint.Height;
            if (height > e.PageBounds.Height - BorderHeight * 2) height = e.PageBounds.Height - BorderHeight * 2;

            width = ImageToPrint.Width;
            if (width > e.PageBounds.Width - BorderWidth * 2) width = e.PageBounds.Width - BorderWidth;
            
            // Set the X, Y location for where to put the image: 
            Rectangle R = new Rectangle(BorderWidth, BorderHeight, width - BorderWidth*2, height-BorderHeight*2);

            //Here is where we add the image to print to the PrintPageEventArgs:
            //Use PageNumberToPrint to identify what image to add here:
            e.Graphics.DrawImage(ImageToPrint, R);

            //Check if this is the last page to print:
            if (PageNumberToPrint >= NumberOfPagestoPrint)
            {
                //This is the last page:
                e.HasMorePages = false;
            }
            else
            {
                //Go to the next page:
                PageNumberToPrint++;
                e.HasMorePages = true;
            }
        }

        private void PrintPreviewButton_Click(object sender, EventArgs e)
        {
            //PrintPreviewDialog's Document property is set to the PrintImageDocument object, which actually
            //handles the printing.  Basically when printPreviewDialog1.ShowDialog() is called, the "document"
            //is essentially printed, and PrintImageDocument_BeginPrint() and PrintImageDocument_PrintPage() get
            //called to construct the document to print.
            printPreviewDialog1.Document = PrintImageDocument;
            printPreviewDialog1.ShowDialog();
        }

        /// <summary>
        /// This function doesn't really work in the sense of saving a multiple page document.  This function is pretty
        /// much designed for a single image to be saved.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveImageAsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".jpg";
            saveFileDialog1.Filter = "jpeg Files |*.jpg";
            saveFileDialog1.FileName = FileName;
            saveFileDialog1.ShowDialog();

            //Recreate the image (we could just use the pic object, which already exists):
            Image tempimage = ImageCaption.CreateImageWithMetaData(TempFileName);

            //Save the image with the provided file name:
            tempimage.Save(saveFileDialog1.FileName);
            tempimage.Dispose();
        }
    }
}