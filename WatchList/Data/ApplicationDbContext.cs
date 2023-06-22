using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WatchList.Models;

namespace WatchList.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
public DbSet<Film> Films { get;set; }
public DbSet<FilmUser> FilmUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FilmUser>()
            .HasKey(t => new { t.IdMyUser, t.IdFilm });
        }


        public DbSet<WatchList.Models.ModeleVueFilm>? ModeleVueFilm { get; set; }
    }
}