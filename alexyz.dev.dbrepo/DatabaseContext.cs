using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Design;
using alexyz.dev.dbrepo.Helpers;
using alexyz.dev.dbrepo.Models;
using Microsoft.Extensions.Configuration;

namespace alexyz.dev.dbrepo
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Tweet> Tweets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationHelper.config.GetConnectionString("DevDatabase"));
        }
    }
}