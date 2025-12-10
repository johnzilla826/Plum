using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Plum.Data;
using Plum.Models;

namespace Plum.Pages.Accounts;

public class Index(PlumDbContext context) : PageModel
{
    public IList<Account> Accounts { get; set; }

    public async Task OnGetAsync()
    {
        Accounts = await context.Accounts.ToListAsync();
    }
}