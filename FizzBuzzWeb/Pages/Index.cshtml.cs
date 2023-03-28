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
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (FizzBuzz.Number % 3 == 0)
            {
                Fizzy += "Fizz";
            }
            if (FizzBuzz.Number % 5 == 0)
            {
                Fizzy += "Buzz";
            }
            if (FizzBuzz.Number % 3 != 0 && FizzBuzz.Number % 5 != 0)
            {
                Fizzy = $"Liczba {FizzBuzz.Number} nie zgadza się.";
            }

            return Page();
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
