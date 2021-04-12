using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helper
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {

            var result = createNewPath(file);
            var sourcePath = Path.GetTempFileName();

            using (var stream = new FileStream(sourcePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            File.Move(sourcePath, result.createNewPath);
            return result.path2;

        }

        public static string Update(string sourcePath, IFormFile file)
        {
            var result = createNewPath(file);

            using (var stream = new FileStream(sourcePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            File.Delete(sourcePath);
            return result.createNewPath;
        }

        public static IResult Delete(string path)
        {
            path = Environment.CurrentDirectory + @"\wwwroot\Images\" + path;
            File.Delete(path);
            return new SuccessResult();
        }

        public static (string createNewPath, string path2) createNewPath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;           
            string path2 = Environment.CurrentDirectory + @"\wwwroot\Images\";
            string newFilePath = Guid.NewGuid().ToString("") + fileExtension;
            string result = $@"{path2}\{newFilePath}";
            return(result, $"\\Images\\{newFilePath}");
        }
    }
}

