using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Note.Model;

namespace Note.DAL.DataContext
{
    public class NoteDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public NoteDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_configuration.GetConnectionString("MySqlDbConnectionString"));
            //optionsBuilder.UseMySQL(@"server = 192.168.80.1; port = 3306; database = Note; uid = WebAdmin; password = 1234;");
        }
        public DbSet<Notice> Notices { get; set; }

    }
}
