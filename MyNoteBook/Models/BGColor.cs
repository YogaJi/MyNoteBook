using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyNoteBook.Models
{
    public class BGColor
    {
        [Key]
        public int BGId { get; set; }
        public string BGString { get; set; }

        public ICollection<Journal> Journals { get; set; }
    }
}
