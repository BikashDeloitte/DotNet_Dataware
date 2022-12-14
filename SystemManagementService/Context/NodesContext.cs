using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SystemManagementService.Models;

namespace SystemManagementService.Context
{
    public class NodesContext : DbContext
    {
        public NodesContext(DbContextOptions<NodesContext> options) : base(options)
        { }

        public DbSet<Nodes> nodes { get; set; }
    }
}