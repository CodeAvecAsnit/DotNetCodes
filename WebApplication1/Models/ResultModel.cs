namespace WebApplication1.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


public class ResultModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public decimal Principal { get; set; }

    [BindProperty(SupportsGet = true)]
    public decimal Rate { get; set; }

    [BindProperty(SupportsGet = true)]
    public int Time { get; set; }
    public decimal Interest => (Principal * Rate * Time) / 100;
    public void OnGet()
    {
    }
    public void OnPost()
    {
    }
}
