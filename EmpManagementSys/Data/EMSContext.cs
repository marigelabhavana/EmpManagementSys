using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmpManagementSys.DAL;

namespace EmpManagementSys.Data
{
    public class EMSContext : DbContext
    {
        public EMSContext (DbContextOptions<EMSContext> options)
            : base(options)
        {
        }

        public DbSet<EmpManagementSys.DAL.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
