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
            var abc= _context.MobileItems.Include(a => a.AccessoryItems).ToList();
            return abc;
        }

        public MobileItems GetMobileIDDL(int id)
        {
            var mobileitems = _context.MobileItems.Include(a => a.AccessoryItems).SingleOrDefault(m => m.MobileItemsId == id);
            return mobileitems;
        }

        public MobileItems AddMobileDL(MobileItems mobile)
        {
             _context.Add(mobile);
            _context.SaveChanges();
            return mobile;

        }

        public MobileItems PutMobileDL(int id, MobileItems mobile)
        {
            var abc = _context.MobileItems.FirstOrDefault(a => a.MobileItemsId == id);

            if (abc == null)
            {
                return null;
            }
            else
            {
                abc.MobileName = mobile.MobileName;
                abc.MobilePrice = mobile.MobilePrice;

                _context.SaveChanges();
            }


            return abc;

               





            //_context.Entry(mobile).State = EntityState.Modified;
            //_context.AccessoryItems.UpdateRange(mobile.AccessoryItems);

            //_context.SaveChanges();


            //return (mobile);
        }

        public MobileItems DeleteMobileDL(int id)
        {
            var mobile = _context.MobileItems.Find(id);
            _context.MobileItems.Remove(mobile);
            _context.SaveChanges();

            return mobile;
        }
    }
}
