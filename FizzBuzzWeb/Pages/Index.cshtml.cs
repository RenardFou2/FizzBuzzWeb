using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Forms;
using System.Data;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public String Fizzy { get; set; }

        private readonly ILogger<IndexModel> _logger;
        public void OnPost()
        {
            //int? x = FizzBuzz.Number;
            if (FizzBuzz.Number % 3 == 0)
            {
                Fizzy = "Fizz";
            }
            else if (FizzBuzz.Number % 5 == 0)
            {
                Fizzy = "Buzz";
            }
            else if (FizzBuzz.Number % 3 == 0 && FizzBuzz.Number % 5 == 0)
            {
                Fizzy = "FizzBuzz";
            }
            else
            {
                Fizzy = $"Liczba {FizzBuzz.Number} nie zgadza się.";
            }
        }

        [BindProperty]
        public FizzBuzzForm? FizzBuzz { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Fizzy = "";
        }
    }
}