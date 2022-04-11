using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyNoteBook.Data;
using MyNoteBook.Models;

namespace MyNoteBook.Pages.Journals
{
    public class DetailsModel : PageModel
    {
        private readonly MyNoteBook.Data.MyNoteBookContext _context;

        public DetailsModel(MyNoteBook.Data.MyNoteBookContext context)
        {
            _context = context;
        }

        public Journal Journal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Journal = await _context.Journal.Include(p => p.weather).Include(p => p.mood).Include(p => p.notebook).FirstOrDefaultAsync(m => m.JournalId == id);

            if (Journal == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
