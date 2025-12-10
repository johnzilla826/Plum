using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Plum.Data;
using Plum.Models;

namespace Plum.Pages.Accounts;

public class Create(PlumDbContext context) : PageModel
{   

    [BindProperty]
    public Account Account { get; set;}
    
    public void OnGet()
    {
    }
    
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        context.Accounts.Add(Account);
        context.SaveChanges();
        return RedirectToPage("./Index");
    }
}