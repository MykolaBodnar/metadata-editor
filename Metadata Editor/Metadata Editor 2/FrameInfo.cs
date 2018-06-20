using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Metadata_Editor_2
{
    abstract class FrameInfo
    {
        public const int frameDescriptionSize = 10;
        public const int tagSizePosition = 6;

        public static string getTextFromFrame(byte[] frameValue) {
            int iterStart = (hasPrefix(frameValue)) ? 3 : 0;
            List<Byte> bytes = new List<byte>();
            for (int i = iterStart; i < frameValue.Length; i++) {
                if (frameValue[i] != 0) bytes.Add(frameValue[i]);
            }
            frameValue = listToArray(bytes);
            return Encoding.Default.GetString(frameValue);
        }

        public static bool hasPrefix(byte[] frameValue){
            return ((frameValue[0] == 1) 
                && (frameValue[1] == 255) 
                && (frameValue[2] == 254));
        }

        public static byte[] listToArray(List<Byte> list) {
            byte[] array = new byte[list.Count];
            for (int i = 0; i < array.Length; i++) {
                array[i] = list[i];
            }
            return array;   
        }

        public static Image getImageFromFrame(byte[] frameValue){
            int tagLength = getImageTagLength(frameValue);
            byte[] image = new byte[frameValue.Length - tagLength];
            for (int i = 0; i < image.Length; i++)
                image[i] = frameValue[i + tagLength];
            MemoryStream memoryStream = new MemoryStream(image);
            return Image.FromStream(memoryStream);
        }


        public static byte[] getByteImageFromFrame(byte[] frameValue)
        {
            int tagLength = getImageTagLength(frameValue);
            byte[] image = new byte[frameValue.Length - tagLength];
            for (int i = 0; i < image.Length; i++)
            {
                image[i] = frameValue[i + tagLength];
            }
            return image;
        }

        public static int getImageTagLength(byte[] frameValue) {
            for (int i = 0; i < frameValue.Length - 3; i++) {
                if ((frameValue[i] == (byte)255) && (frameValue[i + 1] == (byte)216) && (frameValue[i + 2] == (byte)255))
                    return i;
                if ((frameValue[i] == (byte)66) && (frameValue[i + 1] == (byte)77))
                    return i;
                if ((frameValue[i] == (byte)137) && (frameValue[i + 1] == (byte)80) && (frameValue[i + 2] == (byte)78))
                    return i;

            }
            return 0;
        }

        public static string getImageFormat(byte[] imageFrameData) {
            for (int i = 0; i < imageFrameData.Length - 3; i++)
            {
                if ((imageFrameData[i] == (byte)255) && (imageFrameData[i + 1] == (byte)216) && (imageFrameData[i + 2] == (byte)255))
                    return "jpg";
                if ((imageFrameData[i] == (byte)66) && (imageFrameData[i + 1] == (byte)77))
                    return "bmp";
                if ((imageFrameData[i] == (byte)137) && (imageFrameData[i + 1] == (byte)80) && (imageFrameData[i + 2] == (byte)78))
                    return "png";

            }
            return "raw";
        }

        public static void setImageTag(byte[] imageFrameData, string format) {
            byte[] jpg = { 0, 105, 109, 97, 103, 101, 47, 106, 112, 103, 0, 3, 0 };
            byte[] bmp = { 0, 105, 109, 97, 103, 101, 47, 98, 109, 112, 0, 3, 0 };
            byte[] png = { 0, 105, 109, 97, 103, 101, 47, 112, 110, 103, 0, 3, 0 };
           
            switch (format)
            {
                case "jpg":
                    for (int i = 0; i < jpg.Length;i++ )
                    {
                        imageFrameData[i] = jpg[i];
                    }
                    return;
                
                case "jpeg":
                        for (int i = 0; i < jpg.Length;i++  )
                        {
                            imageFrameData[i] = jpg[i];
                        }
                        return;
                case "raw": {
                        for (int i = 0; i < jpg.Length;i++  )
                        {
                            imageFrameData[i] = jpg[i];
                        }
                        return;
                }

                case "bmp":
                    for (int i = 0; i < bmp.Length;i++  )
                        {
                            imageFrameData[i] = bmp[i];
                        }
                    return;
                    
                case "png":
                        for (int i = 0; i < png.Length;i++  )
                        {
                            imageFrameData[i] = png[i];
                        }
                        return;
                default: 
                    for (int i = 0; i < jpg.Length;i++  )
                        {
                            imageFrameData[i] = jpg[i];
                        }
                        return;

                    
            }
        
        }

        public static string getFrameName(byte[] byteFrameId)
        {
            string FrameId = Encoding.Default.GetString(byteFrameId);
            string[,] AllFrames ={   

	{  "TIT2", "TT2", "Назва"},
	{  "TALB", "TAL", "Альбом"},
	{  "TPE1", "TP1", "Виконавець"},
	{  "TPE2", "TP2", "Виконавець альбому"},
	{  "TCON", "TCO", "Жанр"},
	{  "TRCK", "TRK", "Номер трека"},
	{  "TYER", "TYE", "Рік"},
	{  "COMM", "COM", "Коментар"},
	{  "TPUB", "TPB", "Видавець альбому"},
	{  "TPOS", "TPA", "Номер диска"},
	{  "APIC", "PIC", "Picture"},
    {  "TCMP", "PIC", "NEW!"},
   {  "AENC", "CRA", "Audio Encryption"},         
   {  "ASPI", null, "Audio Seek Point Index"},  
   {  "COMR", null, "Commercial Frame"},
   {  "ENCR", null, "Encryption Method Registration"},
   {  "EQU2", null, "Equalisation (2)"},
   {  "EQUA", "EQU", "Equalisation"},
   {  "ETCO", "ETC", "Event Timing Code"},
   {  "GEOB", "GEO", "General Encapsulated Object"},
   {  "GRID", null, "Group Identification Registration"},
   {  "IPLS", "IPL", "Involved People List"},
   {  "LINK", "LNK", "Linked Information"},
   {  "MCDI", "MCI", "Music CD Identifier"},
   {  "MLLT", "MLL", "Mepg Location Lookup Table"},
   {  "OWNE", null, "Ownership Information"},
   {  "PCNT", "CNT", "Play Counter"},
   {  "POPM", "POP", "Popularimeter"},
   {  "POSS", null, "Position Synchronisation Frame"},
   {  "PRIV", null, "Private Frame"},
   {  "RBUF", "BUF", "Recommended Buffer Size"},
   {  "RVA2", null, "Relative Volume Adjustment (2)"},
   {  "RVAD", "RVA", "Relative Volume Adjustment"},
   {  "RVRB", "REV", "Reverb"},
   {  "SEEK", null, "Seek Frame"},
   {  "SIGN", null, "Signature Frame"},
   {  "SYLT", "SLT", "Synchronized Lyric/Text"},
   {  "SYTC", "STC", "Synced Tempo Codes"}, 
   {  "TBPM", "TBP", "BPM ( Beats Per Minutes)"},
   {  "TCOM", "TCM", "Composer"},   
   {  "TCOP", "TCR", "Copyright Message"},
   {  "TDAT", "TDA", "Date"},
   {  "TDEN", null, "Encoding Time"},
   {  "TDLY", "TDY", "Playlist Delay"},
   {  "TDOR", null, "Orginal Release Time"},
   {  "TDRC", null, "Recording Time"},
   {  "TDRL", null, "Release Time"},
   {  "TDTG", null, "Tagging Time"},
   {  "TENC", "TEN", "Encoded By"},
   {  "TEXT", "TXT", "Lyric/Text Writer"},
   {  "TFLT", "TFT", "File Type"},
   {  "TIME", "TIM", "Time"},
   {  "TIPL", null, "Involved People List"},
   {  "TIT1", "TT1", "Content Group Description"},  
   {  "TIT3", "TT3", "Subtitle/Desripction"},
   {  "TKEY", "TKE", "Initial Key"},
   {  "TLAN", "TLA", "Language"},
   {  "TLEN", "TLE", "Length"},
   {  "TMCL", null, "Musician Credits List"},
   {  "TMED", "TMT", "Media Type"},
   {  "TMOO", null, "Mood"},
   {  "TOAL", "TOT", "Orginal Title"},
   {  "TOFN", "TOF", "Orginal Filename"},
   {  "TOLY", "TOL", "Orginal Lyricist"},
   {  "TOPE", "TOA", "Orginal Artist"},
   {  "TORY", "TOR", "Orginal Release Year"},
   {  "TOWN", null, "File Owner"},   
   {  "TPE3", "TP3", "Conductor"},
   {  "TPE4", "TP4", "Interpreted"},  
   {  "TPRO", null, "Produced Notice"},      
   {  "TRDA", "TRD", "Recording Date"},
   {  "TRSN", null, "Internet Radio Station Name"},
   {  "TRSO", null, "Internet Radio Station Owner"},
   {  "TSIZ", "TSI", "Size"},
   {  "TSOA", null, "Album Sort Order"},
   {  "TSOP", null, "Preformer Sort Order"},
   {  "TSOT", null, "Title Sort Order"},
   {  "TSRC", "TRC", "ISRC"},
   {  "TSSE", "TSS", "Software/Hardware And Setting Used For Encoding"},
   {  "TSST", null, "Set Subtitle"}, 
   {  "TXXX", null, "User defined text information frame"},
   {  "UFID", "UFI", "Unique File Identifier"},
   {  "USER", null, "Term Of Use"},
   {  "USLT", "ULT", "Unsynchronized Lyric"},
   {  "WCOM", "WCM", "Commercial Information"},
   {  "WCOP", "WCP", "Copyright Information"},
   {  "WOAF", "WAF", "Official Audio File web"},
   {  "WOAR", "WAR", "Official Artist web"},
   {  "WOAS", "WAS", "Official Audio Source web"},
   {  "WORS", null, "Official Radio Station Web"},
   {  "WPAY", null, "Payment web"},
   {  "WPUB", "WPB", "Publisher web"},
                         };

            for (int Row = 0; Row < AllFrames.Length / 3; Row++)
            {
                if (FrameId == AllFrames[Row, 0]) return AllFrames[Row, 2];
            }
            return "";

        }

        public static long getFrameSize(byte[] byteFrameSize) {
            return (long)byteFrameSize[0] << 24 |
                        (long)byteFrameSize[1] << 16 |
                        (long)byteFrameSize[2] << 8 |
                        (long)byteFrameSize[3];
        }

        public static byte[] getByteFrameSize(int frameSize)
        {
            byte[] byteFrameSize = new byte[4];
            byteFrameSize[0] = (byte)(frameSize >> 24);
            byteFrameSize[1] = (byte)(frameSize >> 16);
            byteFrameSize[2] = (byte)(frameSize >> 8);
            byteFrameSize[3] = (byte)(frameSize);
            return byteFrameSize;
        }

        public static byte[] getByteTagSize(long position)
        {
            long tagSize = position - frameDescriptionSize;
            byte[] byteTagSize = new byte[4];
            byteTagSize[0] = (byte)(tagSize >> 21);
            byteTagSize[1] = (byte)(tagSize >> 14);
            byteTagSize[2] = (byte)(tagSize >> 7);
            byteTagSize[3] = (byte)(tagSize);
            return byteTagSize;
        }

        public static byte[] getByteTextFrameData(string data,int frameSize) {
            byte[] byteTextFrameData = new byte[frameSize];
            byte[] byteData = new byte[data.Length];
            Encoding.Default.GetBytes(data).CopyTo(byteData, 0);
            byteTextFrameData[0] = 1;
            byteTextFrameData[1] = 255;
            byteTextFrameData[2] = 254;
            for (int i = 3, j = 0; i < byteTextFrameData.Length; i += 2, j++) {
                byteTextFrameData[i] = byteData[j];
            }
            return byteTextFrameData;
        }

    }


}
