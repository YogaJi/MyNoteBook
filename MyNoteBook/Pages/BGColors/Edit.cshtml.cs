using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyNoteBook.Data;
using MyNoteBook.Models;

namespace MyNoteBook.Pages.BGColors
{
    public class EditModel : PageModel
    {
        private readonly MyNoteBook.Data.MyNoteBookContext _context;

        public EditModel(MyNoteBook.Data.MyNoteBookContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BGColor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BGColorExists(BGColor.BGId))
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

        private bool BGColorExists(int id)
        {
            return _context.BGColor.Any(e => e.BGId == id);
        }
    }
}
