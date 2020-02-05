using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mobile.DL.Interface;
using Mobile.DL.Entity;
using Mobile.DL.Enity;
using Microsoft.EntityFrameworkCore;

namespace Mobile.DL.Repository
{
    public class MobileRepository:IMobileRepository
    {
        private readonly MobileContext _context;

        public MobileRepository(MobileContext context)
        {
            _context = context;
        }

        public IEnumerable<MobileItems> GetMobileDL()
        {
            return _context.MobileItems.Include(a=>a.AccessoryItems).ToList();
        }
    }
}
