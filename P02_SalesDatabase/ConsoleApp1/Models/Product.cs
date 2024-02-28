using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public List<Sale> Sales { get; set; }

    }
}
