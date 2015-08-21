using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreMvcWeb.Domain.Entities;

namespace BookStoreMvcWeb.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}
