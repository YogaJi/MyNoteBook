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
    public class DetailsModel : PageModel
    {
        private readonly MyNoteBook.Data.MyNoteBookContext _context;

        public DetailsModel(MyNoteBook.Data.MyNoteBookContext context)
        {
            _context = context;
        }

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
    }
}
