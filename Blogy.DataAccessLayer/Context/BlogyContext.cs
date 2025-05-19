using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogy.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Blogy.DataAccessLayer.Context
{
    public class BlogyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=DESKTOP-JQG1QG1\\SQLEXPRESS;Database=Blogy;Integrated Security=true;TrustServerCertificate=True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
