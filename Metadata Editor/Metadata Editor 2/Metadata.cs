using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Metadata_Editor_2
{
    class Metadata{
        public Metadata()
        {
            name = "";
            artist = "";
            album = "";
            genre = "";
            number = "";
            year = "";
            fileName = "";
        }
        public String name;
        public String artist;
        public String album ;
        public String genre ;
        public String number;
        public String year;
        public String fileName;
        public long byteSize;
        public byte[] byteImage;
        public String imageFormat;

        public Image image {
            get
            {
                if (byteImage == null) return null;
                return Image.FromStream(new MemoryStream(byteImage));
            }
            set {
                
                byte[] byteValue = (byte[])new ImageConverter().ConvertTo(value, typeof(byte[]));
                if (FrameInfo.getImageFormat(byteValue) == "jpg")
                {
                    byteImage = byteValue;
                }
                else
                {
                    var memoryStream = new MemoryStream();
                    value.Save(memoryStream, ImageFormat.Jpeg);
                    byteImage = memoryStream.ToArray();
                    imageFormat = "jpg";
                }
               
            }


        }

    }
}
