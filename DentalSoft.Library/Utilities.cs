using System;
using System.IO;
using System.Drawing;

namespace DentalSoft.Library
{
    public class Utilities
    {
        public string convertDateForDB(DateTime dateTime)
        {
            return dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day + " " + dateTime.Hour + "-" + dateTime.Minute + "-" + dateTime.Second;
        }

        public string convertProfilePicForDB(byte[] profilePic)
        {
            if (profilePic == null)
                return "null";
            else
                return "'" + profilePic + "'";
        }

        public Bitmap convertByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, Convert.ToInt32(imageBytes.Length));
            Bitmap bm = new Bitmap(ms, false);
            ms.Dispose();
            return bm;
        }

        public byte[] convertImageToByte(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            ms.Dispose();
            return ms.ToArray();
        }
    }
}