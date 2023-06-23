using WatchList.Data;


namespace WatchList.Data
{
    public class FilmUser
    {
        public int IdMyUser { get; set; }
        public int IdFilm { get; set; }
        public bool Seen { get; set; }
        public int Note { get; set; }
public virtual MyUser User { get; set; }
public virtual Film Film { get; set; }

    }
}
