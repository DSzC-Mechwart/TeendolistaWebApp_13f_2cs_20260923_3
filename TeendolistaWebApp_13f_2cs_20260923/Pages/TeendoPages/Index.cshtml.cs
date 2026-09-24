using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeendolistaWebApp_13f_2cs_20260923.Models;
using TeendolistaWebApp_13f_2cs_20260923.Data;

namespace TeendolistaWebApp_13f_2cs_20260923.Pages.TeendoPages;

public class IndexModel : PageModel
{
    private readonly TeendoDbContext _context;

    public IndexModel(TeendoDbContext context)
    {
        _context = context;
    }

    public IList<Teendo> Teendo { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Teendo = await _context.Teendok.ToListAsync();
    }
}
