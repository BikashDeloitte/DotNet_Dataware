using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SystemManagementService.Models;

namespace SystemManagementService.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Product> products { get; set; }
    }
}