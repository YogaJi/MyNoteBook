using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyNoteBook.Models
{
    public class Mood
    {
        [Key]
        public int MoodId { get; set; }
        public string MoodPic { get; set; }
    }
}
