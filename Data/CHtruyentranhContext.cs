using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CHtruyentranh.Models;

namespace CHtruyentranh.Data
{
    public class CHtruyentranhContext : DbContext
    {
        public CHtruyentranhContext (DbContextOptions<CHtruyentranhContext> options)
            : base(options)
        {
        }

        public DbSet<CHtruyentranh.Models.Book> Book { get; set; }
    }
}
