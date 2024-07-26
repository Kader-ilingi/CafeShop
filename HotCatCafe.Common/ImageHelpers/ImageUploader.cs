using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace HotCatCafe.Common.ImageHelpers
{
    public static class ImageUploader
    {
        //public static async Task<string> UploadImageAsync(IFormFile imageFile)
        //{
        //    // Dosya uzantısını al
        //    var extension = Path.GetExtension(imageFile.FileName)?.TrimStart('.').ToLower();
        //    var validExtensions = new[] { "png", "jpg", "jpeg", "gif", "bmp" };

        //    if (!validExtensions.Contains(extension))
        //    {
        //        return "0"; // Geçersiz uzantı
        //    }

        //    // Yeni dosya adı oluştur
        //    var uniqueFileName = $"{Guid.NewGuid()}.{extension}";
        //    var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images\\ProductsImage");
        //    var filePath = Path.Combine(uploadPath, uniqueFileName);

        //    // Dosyayı kaydet
        //    using (var fileStream = new FileStream(filePath, FileMode.Create))
        //    {
        //        await imageFile.CopyToAsync(fileStream);
        //    }

        //    return uniqueFileName;
        //}




        // Geçerli dosya uzantılarını tanımlayalım
        private static readonly string[] ValidExtensions = { "png", "jpg", "jpeg", "gif", "bmp" };

        public static async Task<string> UploadImageAsync(Stream imageStream, string fileName)
        {
            if (imageStream == null || imageStream.Length == 0)
            {
                return "0"; // Geçersiz veya boş dosya akışı
            }
            var extension = Path.GetExtension(fileName)?.TrimStart('.').ToLower();

            if (!ValidExtensions.Contains(extension))
            {
                return "0"; // Geçersiz uzantı
            }
            var uniqueFileName = $"{Guid.NewGuid()}.{extension}";
            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images\\ProductsImage");
            var filePath = Path.Combine(uploadPath, uniqueFileName);

            // Dosyayı kaydet
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await imageStream.CopyToAsync(fileStream);
            }

            return uniqueFileName;
        }
    }
}
