using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SystemManagementService.Models;

namespace SystemManagementService.Context
{
    public class PalletsContext : DbContext
    {
        public PalletsContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Pallets> pallets { get; set; }
    }
}