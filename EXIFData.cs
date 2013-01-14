using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageCaptionEdit
{
    class EXIFData
    {
        enum ExifDataTypes
        {
            UnsignedByte = 1,
            AsciiString = 2,
            UnsignedShort = 3,
            UnsignedLong = 4,
            UnsignedRational = 5,
            SignedByte = 6,
            Undefined = 7,
            SignedShort = 8,
            SignedLong = 9,
            SignedRational = 10,
            SingleFloat = 11,
            DoubleFloat = 12,
        }

        public static string header;     //stored under id=0x9c9b (title)
        public static string sideinfo;    //stored under id=0x9286 (description)
        public static string description;//stored under id=0x9c9c (comment)

        public static void GetData(string filename)
        {
            //try
            //{
                //Open the file to look at its properties..
                Image theImage = new Bitmap(filename);

                PropertyItem[] propItems = theImage.PropertyItems;

                // For each PropertyItem in the array, display the id, 
                // type, and length.
                Encoding _Encoding;

                //clear these out initially
                header = "";
                sideinfo = "";
                description = "";

                //default encoding
                _Encoding = Encoding.UTF8;

                foreach (PropertyItem propItem in propItems)
                {
                    if (propItem.Value != null)
                    {
                        _Encoding = setEncoding(propItem.Value);
                    }
                    switch (propItem.Id)
                    {
                        case 0x9c9b:    //Title (40091)
                            if (propItem.Value == null) break;
                            header = _Encoding.GetString(propItem.Value);
                            break;
                        //case 0x9286:    //Description (37510)
                        //    if (propItem.Value == null) break;
                        //    sideinfo = _Encoding.GetString(propItem.Value);
                        //    break;
                        case 0x9c9f:    //Subject (40095)
                            if (propItem.Value == null) break;
                            sideinfo = _Encoding.GetString(propItem.Value);
                            break;
                        case 0x9c9c:    //Comment (40092)
                            if (propItem.Value == null) break;
                            description = _Encoding.GetString(propItem.Value);
                            break;
                        default:
                            break;
                    }
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error in GetData: " + ex.Message);
            //}
        }

        private static Encoding setEncoding(byte[] str)
        {
            Encoding enc;
            if (str == null)
            {
                return null;
            }
            if (str[1] == 0) enc = Encoding.Unicode;
            else enc = Encoding.UTF8;
            return enc;
        }

        public static void SaveData(string infilename, string outfilename)
        {
            //try
            //{
                string TempFile;

                TempFile = System.IO.Path.GetTempPath() + "__ImageCaptionEdit__" + System.IO.Path.GetRandomFileName();
                System.IO.File.Copy(infilename, TempFile);

                Encoding _Encoding = Encoding.UTF8;
                Image theImage = new Bitmap(TempFile);


                //figure out how to create an EXIF propertyitem...
                //PropertyItem BaseProperty = new PropertyItem();
                PropertyItem BaseProperty;

                BaseProperty = CreatePropertyItem();

                theImage.SetPropertyItem(SetupProperty(BaseProperty, header, 0x9c9b));
                theImage.SetPropertyItem(SetupProperty(BaseProperty, sideinfo, 0x9c9f));
                theImage.SetPropertyItem(SetupProperty(BaseProperty, description, 0x9c9c));

                theImage.Save(outfilename,ImageFormat.Jpeg);

            //}
            //catch (Exception excp)
            //{
            //    MessageBox.Show("Error in SaveData: " + excp.Message);
            //}
        }

        //Since there is no way to instantiate a new PropertyItem, we simply include a .jpg file in the exe and get
        //a base property item from that.
        static private PropertyItem CreatePropertyItem()
        {
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream file =
                thisExe.GetManifestResourceStream("ImageCaptionEdit.meta.jpg");

            Image theImage = new Bitmap(file);
            PropertyItem BaseProperty;
            BaseProperty = theImage.PropertyItems[0];
            BaseProperty = SetupProperty(BaseProperty, "", 270);
            return BaseProperty;
        }


        static private PropertyItem SetupProperty(PropertyItem BaseProperty, string Text, int Id)
        {
            Encoding _Encoding = Encoding.UTF8;

            BaseProperty.Value = _Encoding.GetBytes(Text + '\0');
            BaseProperty.Id = Id;
            BaseProperty.Type = (short)ExifDataTypes.AsciiString;
            BaseProperty.Len = (int)Text.Length;
            return BaseProperty;
        }

    }
}
