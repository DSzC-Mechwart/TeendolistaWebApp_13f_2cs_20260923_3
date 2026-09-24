using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeendolistaWebApp_13f_2cs_20260923.Data;
using TeendolistaWebApp_13f_2cs_20260923.Models;

namespace TeendolistaWebApp_13f_2cs_20260923.Pages
{
    public class IndexModel : PageModel
    {
        private readonly TeendoDbContext _context;

        public IndexModel(TeendoDbContext context)
        {
            _context = context;
        }

        //A tábla tartalma a listázáshoz
        public IList<Teendo> Teendok { get; set; } = default!;

        //Teendo objektum új teendő felvételéhez
        [BindProperty]
        public Teendo UjTeendo { get; set; }

        public async Task OnGetAsync()
        {
            Teendok = await _context.Teendok.ToListAsync();
        }

        public async Task<ActionResult> OnPostAsync()
        {
            _context.Teendok.Add(UjTeendo);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }

    }
}
