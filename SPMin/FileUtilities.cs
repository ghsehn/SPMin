﻿using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SPMin
{
    public class FileUtilities
    {
        public static string RemoveDuplicatedSlashesFromPath(string path)
        {
            return Regex.Replace(path, "/{2,}", "/");
        }

        public static string GetDirectoryPathFromFilePath(string filePath)
        {
            string[] parts = filePath.Split('/');
            return String.Join("/", parts.Take(parts.Length - 1).ToArray());
        }

        public static SPFile GetFile(SPFolder folder, string fileName)
        {
            return folder.Files.OfType<SPFile>().FirstOrDefault(f => f.Name == fileName);
        }
    }
}