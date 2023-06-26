using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using WatchList.Data;

public class MyUser : Microsoft.AspNetCore.Identity.IdentityUser
{
    public MyUser() : base()
    {
        this.FilmList = new HashSet<FilmUser>();
    }
    public string FirstName { get; set; } = string.Empty; // Non-nullable with default value
    public virtual ICollection<FilmUser> FilmList { get; set; }

}

