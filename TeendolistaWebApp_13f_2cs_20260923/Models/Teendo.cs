using System.ComponentModel.DataAnnotations;

namespace TeendolistaWebApp_13f_2cs_20260923.Models
{
    public class Teendo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A cím megadása kötelező!")]
        [StringLength(150, ErrorMessage = "A cím maximum 150 karakter hosszú lehet!")]
        public string Cim { get; set; }
        public DateTime Hatarido { get; set; }
        public bool Kesz { get; set; } = false;
    }
}
