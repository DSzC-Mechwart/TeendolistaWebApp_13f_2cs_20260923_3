using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeendolistaWebApp_13f_2cs_20260923.Models;
using TeendolistaWebApp_13f_2cs_20260923.Data;

namespace TeendolistaWebApp_13f_2cs_20260923.Pages.TeendoPages;

public class DetailsModel : PageModel
{
    private readonly TeendoDbContext _context;
    public DetailsModel(TeendoDbContext context)
    {
        _context = context;
    }

    public Teendo Teendo { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var teendo = await _context.Teendok.FirstOrDefaultAsync(m => m.Id == id);
        if (teendo is null)
        {
            return NotFound();
        }
        else
        {
            Teendo = teendo;
        }

        return Page();
    }
}
