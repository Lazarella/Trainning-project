using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using WatchList.Data;

public class MyUser : Microsoft.AspNetCore.Identity.IdentityUser
{
    public MyUser() : base()
    {
        this.ListeFilms = new HashSet<FilmUser>();
    }
    public string FirstName { get; set; }
    public virtual ICollection<FilmUser> ListeFilms { get; set; }

}

