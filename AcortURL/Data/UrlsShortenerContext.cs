using AcortURL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AcortURL.Data
{
    public class UrlsShortenerContext : DbContext
    {
        public DbSet<URL> Urls { get; set; }
        public UrlsShortenerContext(DbContextOptions<UrlsShortenerContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            URL karen = new URL()
            {
                Id = 1,
                Nombre = "Karen",
                Url = "https://www.facebook.com/karen.gonzalez.520900"

            };
            URL luis = new URL()
            {
                Id = 2,
                Nombre = "Luis",
                Url = "https://www.facebook.com/luis.gonzalez.520900"
            };

            modelBuilder.Entity<URL>().HasData(karen, luis);

            base.OnModelCreating(modelBuilder);
        }
    }
}

