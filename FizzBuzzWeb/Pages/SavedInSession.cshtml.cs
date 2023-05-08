using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace FizzBuzzWeb.Pages
{
    public class SavedInSessionModel : PageModel
    {
        public List<FizzBuzzForm> FizzBuzzList { get; set; }
        public void OnGet()
        {
            var data = HttpContext.Session.GetString("FizzBuzz");
            if (!string.IsNullOrEmpty(data))
            {
                FizzBuzzList = JsonConvert.DeserializeObject<List<FizzBuzzForm>>(data);
            }
        }
    }
}
