using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyNoteBook.Data;
using MyNoteBook.Models;

namespace MyNoteBook.Pages.NoteBooks
{
    public class CreateModel : PageModel
    {
        private readonly MyNoteBook.Data.MyNoteBookContext _context;

        public CreateModel(MyNoteBook.Data.MyNoteBookContext context)
        {
            _context = context;
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Notebook Notebook { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Notebook.Add(Notebook);
            await _context.SaveChangesAsync();

            return RedirectToPage("success");
        }
    }
}
