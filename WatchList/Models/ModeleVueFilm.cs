using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WatchList.Models
{
   
    public class ModeleVueFilm
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime releaseDate { get; set; }
        public string Director { get; set; }
        public string MainActors { get; set; }
        public enum Genre { Horror, Drama, Humour, Youth, Action, Documentary }
        public string Description { get; set; }
        public string Poster { get; set; } 
        public bool InList { get; set; }
        public bool Seen { get; set; }
        public int? Note { get; set; }

    }
}
