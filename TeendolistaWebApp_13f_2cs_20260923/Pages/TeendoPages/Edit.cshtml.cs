using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeendolistaWebApp_13f_2cs_20260923.Models;
using TeendolistaWebApp_13f_2cs_20260923.Data;

namespace TeendolistaWebApp_13f_2cs_20260923.Pages.TeendoPages;

public class EditModel : PageModel
{
    private readonly TeendoDbContext _context;

    public EditModel(TeendoDbContext context)
    {
        _context = context;
    }

    [BindProperty]
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
        Teendo = teendo;
        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Teendo).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TeendoExists(Teendo.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool TeendoExists(int id)
    {
        return _context.Teendok.Any(e => e.Id == id);
    }
}
