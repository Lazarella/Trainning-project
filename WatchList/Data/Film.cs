namespace WatchList.Data
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime releaseDate { get;set;}
        public string Director { get;set;}
        public string MainActors { get;set;}
        public enum Genre { Horror, Drama, Humour, Youth, Action, Documentary} 
        public string Description { get;set;}
        public string Poster { get;set;}
        /*public string UserNote { get;set;}
        public string averageNote { get;set;}*/
    }
}
