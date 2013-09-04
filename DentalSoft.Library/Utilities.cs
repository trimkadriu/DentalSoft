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

        public DateTime convertDateFromDb(string dateTime)
        {
            if (string.IsNullOrEmpty(dateTime))
                return DateTime.Now;
            else
                return DateTime.Parse(dateTime);
        }

        public string convertProfilePicForDB(byte[] profilePic)
        {
            if (profilePic == null)
                return "null";
            else
                return "'" + Convert.ToBase64String(profilePic) + "'";
        }

        public byte[] convertProfilePicFromDB(string base64)
        {
            if (string.IsNullOrEmpty(base64))
                return null;
            else
                return Convert.FromBase64String(base64);
        }

        public Image convertByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes);
            Image image = Image.FromStream(ms);
            ms.Dispose();
            return image;
        }

        public byte[] convertImageToByte(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            ms.Dispose();
            return ms.ToArray();
        }

        public string toUpperFirstLetter(string source)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;
            char[] letters = source.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters).Replace("_", " e ");
        }
    }
}