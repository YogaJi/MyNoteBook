using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyNoteBook.Models
{
    public class Journal
    {
        [Key]
        public int JournalId { get; set; }

        [ForeignKey("Notebook")]
        public Notebook notebook { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [ForeignKey("Weather")]
        public Weather weather { get; set; }

        [ForeignKey("Mood")]
        public Mood mood { get; set; }
        public string BackgroundColor { get; set; }
        public string Content { get; set; }
        
    }
}
