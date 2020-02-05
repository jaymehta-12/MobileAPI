using Microsoft.EntityFrameworkCore;
using Mobile.DL.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile.DL.Entity
{
    public class MobileContext: DbContext
    {
        public MobileContext(DbContextOptions<MobileContext> options) : base(options)
        {

        }
        public DbSet<MobileItems> MobileItems { get; set; }
        public DbSet<AccessoryItems> AccessoryItems { get; set; }

    }
}
