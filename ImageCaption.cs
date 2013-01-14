using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageCaptionEdit
{
    class ImageCaption
    {

        public static int HeaderHeight = 20;
        public static int CaptionHeight = 150;
        public static int SideWidth = 230;

        //http://www.codeproject.com/useritems/JoinImages.asp
        public static Image CreateImageWithMetaData(string filename)
        {
            int W, H;
            if (!System.IO.File.Exists(filename)) return null;
            Image theImage = Image.FromFile(filename);

            W = theImage.Width+SideWidth;
            H = theImage.Height+HeaderHeight+CaptionHeight;

            Bitmap NewPic = new Bitmap(W, H);    //Make a new image    
            Graphics g = Graphics.FromImage(NewPic);  //Get a graphics engine from the new image
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;  //Set the quality of the resize

            //paint background white
            g.FillRectangle(Brushes.White, RectangleF.FromLTRB(0, 0, NewPic.Width, NewPic.Height));

            //draw the image onto the new canvas
            g.DrawImage(theImage, 0, HeaderHeight, theImage.Width, theImage.Height);  //Resize

            Font FontToUse = new Font(FontFamily.GenericSansSerif,12);

            //get metadata...
            EXIFData.GetData(filename);

            if (EXIFData.header == "") EXIFData.header = "\0";
            if (EXIFData.sideinfo == "") EXIFData.sideinfo = "\0";
            if (EXIFData.description == "") EXIFData.description = "\0";

            //draw header string...
            g.DrawRectangle(Pens.Black, Rectangle.FromLTRB(0, 0, NewPic.Width-2, HeaderHeight-1));
            g.DrawString(EXIFData.header.Remove(EXIFData.header.Length-1), FontToUse, Brushes.Black, RectangleF.FromLTRB(0, 0, NewPic.Width-3, HeaderHeight));

            //draw side string...
            g.DrawRectangle(Pens.Black, Rectangle.FromLTRB(theImage.Width, HeaderHeight, NewPic.Width-2, NewPic.Height - CaptionHeight));
            g.DrawString(EXIFData.sideinfo.Remove(EXIFData.sideinfo.Length - 1), FontToUse, Brushes.Black, RectangleF.FromLTRB(theImage.Width, HeaderHeight, NewPic.Width-3, NewPic.Height - CaptionHeight));

            //draw caption string...
            g.DrawRectangle(Pens.Black, Rectangle.FromLTRB(0, theImage.Height + HeaderHeight, NewPic.Width-2, NewPic.Height-1));
            g.DrawString(EXIFData.description.Remove(EXIFData.description.Length - 1), FontToUse, Brushes.Black, RectangleF.FromLTRB(0, theImage.Height + HeaderHeight, NewPic.Width-3, NewPic.Height));
            //theImage.SizeMode = PictureBoxSizeMode.AutoSize;  //Resize the picturebox to match it's image  

            theImage.Dispose();

            return NewPic;
        }
    }
}
