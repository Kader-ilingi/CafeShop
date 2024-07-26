
using Microsoft.AspNetCore.Http;

namespace HotCatCafe.Common.ImageHelpers
{
    public static class ImageHelper
    {
        public static string UploadImageAsync(string imageName)
        {
            string newImageName = "";
            string uniqueName = Guid.NewGuid().ToString();
            var fileArray = imageName.Split('.');
            var extension = fileArray[fileArray.Length - 1];//görselin uzatısını teslim edecek

            if (extension == "png" || extension == "jpg" || extension == "bmp" || extension == "gif" || extension == "jpeg")
            {
                newImageName = uniqueName + "." + extension;
                return newImageName;
            }
            else
            {
                return "0";
            }



            //*****************************

            //// Geçerli dosya uzantılarını tanımlayalım
            //string[] validExtensions = { "png", "jpg", "jpeg", "gif", "bmp" };

            //// Dosya uzantısını alalım
            ////string extension = Path.GetExtension(imageName)?.TrimStart('.');
            //string extension = Path.GetExtension(imageName)?.TrimStart('.');

            //// Uzantıyı küçük harfe çevirelim (eşleşmeyi sağlamak için)
            //string extensionLower = extension?.ToLower();

            //// Geçerli bir uzantı mı kontrol edelim
            //if (extension != null && Array.IndexOf(validExtensions, extensionLower) != -1)
            //{
            //    // Yeni bir dosya adı oluşturalım
            //    string uniqueFileName = $"{Guid.NewGuid()}.{extensionLower}";

            //    try
            //    {
            //        string filePath = Path.Combine(uploadPath, uniqueFileName);
            //        using (var stream = new FileStream(filePath, FileMode.Create))
            //        {
            //            imageName.CopyTo(stream);
            //        }
            //        return uniqueFileName; // Başarılı olarak yeni dosya adını döndür

            //        // Dosyayı uploadPath'e kaydedelim
            //        //string filePath = Path.Combine(uploadPath, uniqueFileName);
            //        //File.Copy(imageName, filePath); // İlgili dosyayı uploadPath'e kopyala
            //        //return uniqueFileName; // Başarılı olarak yeni dosya adını döndür
            //    }
            //    catch (Exception ex)
            //    {
            //        // Hata durumunda buraya düşeriz (loglama veya hata yönetimi burada yapılabilir)
            //        Console.WriteLine($"Dosya yüklenirken bir hata oluştu: {ex.Message}");
            //        return null; // Hata durumunda null döndür
            //    }
            //}
            //else
            //{
            //    // Geçersiz uzantı durumu
            //    Console.WriteLine("Geçersiz dosya uzantısı.");
            //    return null; // Hata durumunda null döndür
            //}
        }















        //private static readonly string _uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

        //public static async Task<string?> UploadImageAs(IFormFile file)
        //{
        //    if (file == null || file.Length == 0)
        //        return null;


        //    // Dosyanın uzantısını kontrol etmek için izin verilen uzantıları burada tanımlayabilirsiniz
        //    var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
        //    var fileExtension = Path.GetExtension(file.FileName).ToLower();

        //    if (!allowedExtensions.Contains(fileExtension))
        //    {
        //        throw new ArgumentException("Dosya uzantısı izin verilen formatlarda değil.");
        //    }

        //    // Yüklenecek dosyanın adını ve yolunu oluştur
        //    var fileName = Guid.NewGuid().ToString() + fileExtension;
        //    var filePath = Path.Combine(_uploadDirectory, fileName);

        //    // Dosyayı disk üzerine kaydet
        //    using (var stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        await file.CopyToAsync(stream);
        //    }

        //    return fileName; // Kaydedilen dosyanın adını geri döndür
        //}
        //public static void DeleteImage(string filePath)
        //{
        //    //var filePath = Path.Combine(_uploadDirectory, fileName);
        //    if (File.Exists(filePath))
        //    {
        //        File.Delete(filePath);
        //    }
        //}
    }
}
