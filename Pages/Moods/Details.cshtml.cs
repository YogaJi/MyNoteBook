﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyNoteBook.Data;
using MyNoteBook.Models;

namespace MyNoteBook.Pages.Moods
{
    public class DetailsModel : PageModel
    {
        private readonly MyNoteBook.Data.MyNoteBookContext _context;

        public DetailsModel(MyNoteBook.Data.MyNoteBookContext context)
        {
            _context = context;
        }

        public Mood Mood { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Mood = await _context.Mood.FirstOrDefaultAsync(m => m.MoodId == id);

            if (Mood == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
