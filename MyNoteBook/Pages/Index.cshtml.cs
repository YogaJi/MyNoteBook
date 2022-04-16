using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyNoteBook.Data;
using MyNoteBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNoteBook.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly MyNoteBookContext db;

        [FromForm]
        public Notebook Notebook { get; set; }

        public List<Notebook> NotebookList { get; set; }
        public IndexModel(ILogger<IndexModel> logger, MyNoteBookContext dbContext)
        {
            _logger = logger;
            db = dbContext;
        }

        public void OnGet()
        {
            var query = db.Notebook;
            NotebookList = query.ToList();
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Notebook.Add(Notebook);
                db.SaveChanges();
            }

            NotebookList = db.Notebook.ToList();
        }
    }
}
