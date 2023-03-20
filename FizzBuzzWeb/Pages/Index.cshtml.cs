using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Forms;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("./Privacy");
        }

        [BindProperty]
        public FizzBuzzForm FizzBuzz { get; set; }

        [BindProperty(SupportsGet = true)]

        public String Name { get; set; }

        public void valueHandler(object sender, EventArgs e)
        {
            if (FizzBuzz.Number == 2)
            {
                MyAlert.Visible = true;
            }
            else
            {
                MyAlert.Visible = false;
            }
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }
    }
}