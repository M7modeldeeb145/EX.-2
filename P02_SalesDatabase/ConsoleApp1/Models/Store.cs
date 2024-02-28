using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Store
    {
        public int StoreId { get; set; }
        [MaxLength(80)]
        public string Name { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
