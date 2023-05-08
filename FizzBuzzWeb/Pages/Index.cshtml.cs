using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzzWeb.Forms;
using System.Xml.Linq;


namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public FizzBuzzForm Input { get; set; }

        [TempData]
        public string Result { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Input.Year % 4 == 0 && (Input.Year % 100 != 0 || Input.Year % 400 == 0))
                {
                    Result = $"{Input.Year} jest rokiem przestępnym.";
                }
                else
                {
                    Result = $"{Input.Year} NIE jest rokiem przestępnym";
                }

                var fizzBuzzList = new List<FizzBuzzForm>();
                var data = HttpContext.Session.GetString("FizzBuzz");
                if (!string.IsNullOrEmpty(data))
                {
                    fizzBuzzList = JsonConvert.DeserializeObject<List<FizzBuzzForm>>(data);
                }
                fizzBuzzList.Add(Input);
                HttpContext.Session.SetString("FizzBuzz", JsonConvert.SerializeObject(fizzBuzzList));
            }
        }
    }
}