using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeendolistaWebApp_13f_2cs_20260923.Models;
using TeendolistaWebApp_13f_2cs_20260923.Data;

namespace TeendolistaWebApp_13f_2cs_20260923.Pages.TeendoPages;

public class CreateModel : PageModel
{
    private readonly TeendoDbContext _context;

    public CreateModel(TeendoDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public Teendo Teendo { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Teendok.Add(Teendo);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
