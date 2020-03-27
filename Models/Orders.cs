using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore.Models
{
    class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int NumberOfItem { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }
        public int PromocodeId { get; set; }
        public int ToyId { get; set; }
        public int CustomerId { get; set; }
    }
}
