using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ClassLibrary.Data
{
    public class ValamiContext : DbContext
    {
        public ValamiContext() { }

        public DbSet<Nyilvantartas> Nyilvantartas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connMsSQL = "Server=(localdb)\\mssqllocaldb;Database=API.Data;MultipleActiveResultSets=true";
            string connMySQL = "Server=127.0.0.1;uid=root;passwd=;Database=nyilvantartas;";
            optionsBuilder.UseMySql(connMySQL, ServerVersion.AutoDetect(connMySQL));

            //optionsBuilder.UseMySql(connMsSQL);
        }
    }
}
