using SafesWebMvc.Data;
using SafesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafesWebMvc.Services {
    public class DepartamentService {
        private readonly SafesWebMvcContext _context;
        public DepartamentService(SafesWebMvcContext context) {
            _context = context;
        }
        public List<Departament> FindAll() {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }
    }
}
