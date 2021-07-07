using System;
using SafesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SafesWebMvc.Data;

namespace SafesWebMvc.Services {
    public class SellerService {
        private readonly SafesWebMvcContext _context;

        public SellerService(SafesWebMvcContext context) {
            _context = context;
        }

        public List<Seller> FindAll() {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj) {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
