﻿using System.Linq;

namespace FreakFightsFan.Api.Features.Images.Extensions
{
    public static class ImageHelpers
    {
        /* -------------------- Validation Helpers -------------------- */

        public static bool HaveValidFileType(string imageBase64, List<string> _allowedFileTypes)
        {
            return _allowedFileTypes.Contains(GetImageContentType(imageBase64));        // "data:image/png;base64,xDGYcSWd..."
        }

        public static bool HaveValidSize(string imageBase64, int maxFileSize)
        {
            return GetImageData(imageBase64).Length <= maxFileSize;
        }

        public static string MakeAllowedFileTypesString(List<string> allowedFileTypes)
        {
            var allowedFileTypesString = "";
            for (int i = 0; i < allowedFileTypes.Count; i++)
            {
                var imageType = allowedFileTypes[i].Substring(6);                       // without 'image/'

                allowedFileTypesString += "." + imageType;
                if (i != allowedFileTypes.Count - 1)
                    allowedFileTypesString += ", ";
            }
            return allowedFileTypesString;
        }

        /* -------------------- Model Helpers -------------------- */

        public static string GetImageContentType(string imageBase64)
        {
            return imageBase64.Split(',')[0].Split(':')[1].Split(';')[0];
        }

        public static byte[] GetImageData(string imageBase64)
        {
            return Convert.FromBase64String(imageBase64.Split(',')[1]);
        }
    }
}
