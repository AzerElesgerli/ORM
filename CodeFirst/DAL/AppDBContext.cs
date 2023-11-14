using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DAL
{
    internal class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=WINDOWS-JUPQ502;database=FirstCodeEF;trusted_connection=true;integrated security=true;encrypt=false;");
        }


        public DbSet<Student> Students { get; set; }    

    }

}