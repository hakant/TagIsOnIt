using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using EtiketiUstunde.Data.Model;

namespace EtiketiUstunde.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class EtiketiUstundeCatalog
    {
        private readonly EtiketiUstundeDbContext _context;

        public EtiketiUstundeCatalog()
        {
            _context = new EtiketiUstundeDbContext();
        }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Product> Products
        {
            get
            {
                var list = new List<Product>(_context.Products);
                var rnd = new Random();
                for (var i = list.Count - 1; i > 0; --i)
                {
                    var j = rnd.Next(i + 1);
                    var tmp = list[i];
                    list[i] = list[j];
                    list[j] = tmp;
                }
                return list;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Division>  Divisions
        {
            get { return _context.Divisions.Include(x => x.Categories); }
        }

        /// <summary>
        /// 
        /// </summary>
        public IQueryable<UserProfile> UserProfiles
        {
            get { return _context.UserProfiles; }
        } 
    }
}
