using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorBlog.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorBlog.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
