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

namespace MyNoteBook.Pages.Templates
{
    public class EditModel : PageModel
    {
        private readonly MyNoteBook.Data.MyNoteBookContext _context;

        public EditModel(MyNoteBook.Data.MyNoteBookContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Template Template { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Template = await _context.Template.FirstOrDefaultAsync(m => m.TemplateId == id);

            if (Template == null)
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

            _context.Attach(Template).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TemplateExists(Template.TemplateId))
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

        private bool TemplateExists(int id)
        {
            return _context.Template.Any(e => e.TemplateId == id);
        }
    }
}
