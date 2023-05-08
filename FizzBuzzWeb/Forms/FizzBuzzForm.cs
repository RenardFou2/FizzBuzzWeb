using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FizzBuzzWeb.Forms
{
    public class FizzBuzzForm
    {
        [Display(Name = "Rok urodzenia")]
        [Required(ErrorMessage = "Pole {0} jest wymagane")]
        [Range(1850, 2022, ErrorMessage = "{0} musi znajdować się w przedziale od {1} do {2}")]
        public int Year { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Pole {0} jest wymagane")]
        [StringLength(64, ErrorMessage = "{0} przekroczyło maksymalną wartość {1} znaków.")]
        public string Name { get; set; }

    }
}
