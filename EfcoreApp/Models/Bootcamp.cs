using System.ComponentModel.DataAnnotations;

namespace EfcoreApp.Models
{
    public class Bootcamp
    {
        [Key]
        public int Id { get; set; }
        public string BootcampName { get; set; }
    }
}
