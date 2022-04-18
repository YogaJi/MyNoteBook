using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyNoteBook.Data;
using MyNoteBook.Models;

namespace MyNoteBook.Pages.BGColors
{
    public class DeleteModel : PageModel
    {
        private readonly MyNoteBook.Data.MyNoteBookContext _context;

        public DeleteModel(MyNoteBook.Data.MyNoteBookContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BGColor BGColor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BGColor = await _context.BGColor.FirstOrDefaultAsync(m => m.BGId == id);

            if (BGColor == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BGColor = await _context.BGColor.FindAsync(id);

            if (BGColor != null)
            {
                _context.BGColor.Remove(BGColor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
