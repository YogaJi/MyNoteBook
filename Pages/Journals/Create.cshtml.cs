using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyNoteBook.Data;
using MyNoteBook.Models;

namespace MyNoteBook.Pages.Journals
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
            ViewData["NoteBooks"] = new SelectList(_context.Notebook, "NotebookId", "Name");
            ViewData["Moods"] = new SelectList(_context.Mood, "MoodId", "MoodPic");
            ViewData["Weathers"] = new SelectList(_context.Weather, "WeatherId", "WeatherPic");
            return Page();
        }

        [BindProperty]
        public Journal Journal { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Journal.Add(Journal);
            await _context.SaveChangesAsync();
            ViewData["NoteBooks"] = new SelectList(_context.Notebook, "NotebookId", "Name");
            ViewData["Moods"] = new SelectList(_context.Mood, "MoodId", "MoodPic");
            ViewData["Weathers"] = new SelectList(_context.Weather, "WeatherId", "WeatherPic");
            return RedirectToPage("./Index");
        }
    }
}
