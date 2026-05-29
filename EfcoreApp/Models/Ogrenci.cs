using System.ComponentModel.DataAnnotations;

namespace EfcoreApp.Models
{
    public class Ogrenci
    {
        [Key]
        public int Id { get; set; }
        public string Ogrenciad { get; set; }
        public string OgrenciSoyad { get; set; }
        public string? ImageFıle { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
}
