using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SystemManagementService.Models;

namespace SystemManagementService.Context
{
    public class LPNContext : DbContext
    {
        public LPNContext(DbContextOptions<LPNContext> options) : base(options)
        { }

        public DbSet<LPN> LPNs { get; set; }
    }
}