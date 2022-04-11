using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyNoteBook.Data;
using MyNoteBook.Models;

namespace MyNoteBook.Pages.NoteBooks
{
    public class DeleteModel : PageModel
    {
        private readonly MyNoteBook.Data.MyNoteBookContext _context;

        public DeleteModel(MyNoteBook.Data.MyNoteBookContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Notebook Notebook { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Notebook = await _context.Notebook.FirstOrDefaultAsync(m => m.NotebookId == id);

            if (Notebook == null)
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

            Notebook = await _context.Notebook.FindAsync(id);

            if (Notebook != null)
            {
                _context.Notebook.Remove(Notebook);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
