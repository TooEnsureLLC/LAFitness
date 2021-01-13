using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TooEnsure.Lib;
using TooEnsure.Lib.Backend;
using TooEnsure.Lib.Client.Models.Article;

namespace LAFitnessWeb.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<TextedPost> Articles { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Page> Pages { get; set; }

    }
}
