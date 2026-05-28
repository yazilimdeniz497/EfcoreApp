using System.ComponentModel.DataAnnotations;

namespace EfcoreApp.Models
{
    public class BootcampKayit
    {
        [Key]
        public int KayıtId { get; set; }
        public int BootcampId { get; set; }
        public int OgrenciId { get; set; }
        public DateTime kayıtTarihi { get; set; }
    }
}
