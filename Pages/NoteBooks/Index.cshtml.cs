﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly MyNoteBook.Data.MyNoteBookContext _context;

        public IndexModel(MyNoteBook.Data.MyNoteBookContext context)
        {
            _context = context;
        }

        public IList<Notebook> Notebook { get;set; }

        public async Task OnGetAsync()
        {
            Notebook = await _context.Notebook.ToListAsync();
        }
    }
}
