using System;
using System.IO;
using System.Drawing;

namespace DentalSoft.Library
{
    public class Utilities
    {
        public string convertDateForDB(DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        public DateTime convertDateFromDb(string dateTime)
        {
            DateTime result = DateTime.Now;
            if (string.IsNullOrEmpty(dateTime))
                return result;
            else
                DateTime.TryParseExact(dateTime, "dd/MM/yyyy hh:mm:ss tt", null, System.Globalization.DateTimeStyles.None, out result);
            return result;
        }

        public string convertDateForBindingSource(DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        public string convertProfilePicForDB(byte[] profilePic)
        {
            if (profilePic == null)
                return null;
            else
                return Convert.ToBase64String(profilePic);
        }

        public byte[] convertProfilePicFromDB(string base64)
        {
            if (string.IsNullOrEmpty(base64) || base64.ToLower() == "null")
                return null;
            else
            {
                try 
	            {	        
                    return Convert.FromBase64String(base64);
	            }
	            catch (Exception)
	            {
                    return null;
	            }
            }
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
            return new string(letters).Replace("_", " ");
        }
    }
}