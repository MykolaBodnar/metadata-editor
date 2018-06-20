using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Metadata_Editor_2
{
    class MetadataStream{
        public static Metadata read(String filePath)
        {
            Metadata metadata = new Metadata();
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            fileStream.Seek(FrameInfo.frameDescriptionSize, SeekOrigin.Begin);
            while (true)
            {
                byte[] bufer = new byte[4];
                fileStream.Read(bufer, 0, bufer.Length);
                string frameName = FrameInfo.getFrameName(bufer);
                if (frameName == "") break;
                fileStream.Read(bufer, 0, bufer.Length);
                long frameSize = FrameInfo.getFrameSize(bufer);
                fileStream.Seek(2, SeekOrigin.Current);
                bufer = new byte[frameSize];
                fileStream.Read(bufer, 0, bufer.Length);
                setMetadataValue(bufer, frameName, metadata);
            }
            metadata.byteSize = fileStream.Position - FrameInfo.frameDescriptionSize;
            fileStream.Close();
            return metadata;
        }
        public static void setMetadataValue(byte[] frameValue, string farameName, Metadata metadata) {
            switch(farameName){
                case "Назва": metadata.name = FrameInfo.getTextFromFrame(frameValue); break;
                case "Альбом": metadata.album = FrameInfo.getTextFromFrame(frameValue); break;
                case "Виконавець": metadata.artist = FrameInfo.getTextFromFrame(frameValue); break;
                case "Жанр": metadata.genre = FrameInfo.getTextFromFrame(frameValue); break;
                case "Номер трека": metadata.number = FrameInfo.getTextFromFrame(frameValue); break;
                case "Рік": metadata.year = FrameInfo.getTextFromFrame(frameValue); break;
                case "Picture": setImage(frameValue, metadata); break;
                
            }
        }
        static void setImage(byte[] imageFrameValue, Metadata metadata) {
            metadata.imageFormat = FrameInfo.getImageFormat(imageFrameValue);
            if (metadata.imageFormat == "jpg")
            {
                metadata.byteImage = FrameInfo.getByteImageFromFrame(imageFrameValue);
            }
            else 
            {
                MemoryStream memoryStream = new MemoryStream();
                FrameInfo.getImageFromFrame(imageFrameValue).Save(memoryStream, ImageFormat.Jpeg);
                metadata.byteImage = memoryStream.ToArray();
            }
            
        }
        public static void write(string filePath, Metadata metadata) {
            FileStream fileStream = new FileStream(filePath,FileMode.Open);
            long notFrameDataLength = fileStream.Length - (metadata.byteSize+FrameInfo.frameDescriptionSize);
            fileStream.Seek(metadata.byteSize + FrameInfo.frameDescriptionSize, SeekOrigin.Begin);
            byte[] notFrameData = new byte[notFrameDataLength];
            fileStream.Read(notFrameData, 0, notFrameData.Length);
            fileStream.Seek(FrameInfo.frameDescriptionSize, SeekOrigin.Begin);
            writeTextFrame(fileStream, metadata.album, "TALB");
            writeTextFrame(fileStream, metadata.artist, "TPE1");
            writeTextFrame(fileStream, metadata.artist, "TPE2");
            writeTextFrame(fileStream, metadata.genre, "TCON");
            writeTextFrame(fileStream, metadata.name, "TIT2");
            writeTextFrame(fileStream, metadata.number, "TRCK");
            writeTextFrame(fileStream, metadata.year, "TYER");
            writeImageFrame(fileStream, metadata.byteImage, metadata.imageFormat);
            byte[] byteTagSize = FrameInfo.getByteTagSize(fileStream.Position);
            metadata.byteSize = fileStream.Position - FrameInfo.frameDescriptionSize;
            fileStream.Write(notFrameData, 0, notFrameData.Length);
            fileStream.SetLength(fileStream.Position);
            fileStream.Seek(FrameInfo.tagSizePosition, SeekOrigin.Begin);
            fileStream.Write(byteTagSize, 0, byteTagSize.Length);
            fileStream.Close();
        }

        static void writeTextFrame(FileStream fileStream, String data, String FrameId) {
            if (data != null) {
                //ID
                byte[] buffer = new byte[4];
                Encoding.Default.GetBytes(FrameId).CopyTo(buffer, 0);
                fileStream.Write(buffer, 0, buffer.Length);
                //Size
                int frameSize = data.Length * 2 + 3;
                buffer = FrameInfo.getByteFrameSize(frameSize);
                fileStream.Write(buffer, 0, buffer.Length);
                //flag
                fileStream.WriteByte(0);
                fileStream.WriteByte(0);
                //data
                buffer = FrameInfo.getByteTextFrameData(data, frameSize);
                fileStream.Write(buffer, 0, buffer.Length);

            }
        }

        static void writeImageFrame(FileStream fileStream, byte[] byteImage, String imageFormat)
        {
            if (byteImage != null)
            {
                //ID
                byte[] buffer = new byte[4];
                Encoding.Default.GetBytes("APIC").CopyTo(buffer, 0);
                fileStream.Write(buffer, 0, buffer.Length);
                //Size
                int frameSize = byteImage.Length;
                buffer = FrameInfo.getByteFrameSize(frameSize);
                fileStream.Write(buffer, 0, buffer.Length);
                //flag
                fileStream.WriteByte(0);
                fileStream.WriteByte(0);
                //data
                buffer = new byte[frameSize + 13];
                FrameInfo.setImageTag(buffer, imageFormat);
                for (int i = 0; i < byteImage.Length; i++) {
                    buffer[i + 13] = byteImage[i];
                }
                fileStream.Write(buffer, 0, buffer.Length);

            }
        }
    }
}
