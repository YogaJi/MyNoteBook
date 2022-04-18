using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyNoteBook.Models;

namespace MyNoteBook.Data
{
    public class MyNoteBookContext : DbContext
    {
        public MyNoteBookContext (DbContextOptions<MyNoteBookContext> options)
            : base(options)
        {
        }

        public DbSet<MyNoteBook.Models.Journal> Journal { get; set; }

        public DbSet<MyNoteBook.Models.Mood> Mood { get; set; }

        public DbSet<MyNoteBook.Models.Notebook> Notebook { get; set; }

        public DbSet<MyNoteBook.Models.PhotoDiary> PhotoDiary { get; set; }

        public DbSet<MyNoteBook.Models.Template> Template { get; set; }

        public DbSet<MyNoteBook.Models.Weather> Weather { get; set; }

        public DbSet<MyNoteBook.Models.BGColor> BGColor { get; set; }
    }
}
