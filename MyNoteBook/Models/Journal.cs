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

        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        /*public string BackgroundColor { get; set; }*/
        public int BGId { get; set; }
        public BGColor BGColor { get; set; }
        public string Content { get; set; }

        public int NotebookId { get; set; }
        
        public Notebook notebook { get; set; }


        public int WeatherId { get; set; }
        public Weather weather { get; set; }

        public int MoodId { get; set; }
        public Mood mood { get; set; }


    }
}
