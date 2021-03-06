using System;
using System.Collections.Generic;
using System.Linq;

namespace SafesWebMvc.Models {
    public class Departament {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departament() { }

        public Departament(int id, string name) {
            Id = id;
            Name = name;
        }

        public void addSeller(Seller seller) {
            Sellers.Add(seller);
        }
        public double totalSales(DateTime initial, DateTime final) {
            return Sellers
                .Sum(seller => seller.totalSales(initial, final));
        }
    }
}
