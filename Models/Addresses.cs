using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore.Models
{
    class Addresses
    {
        [Key]
        public int AddressId { get; set; }
        public string AddressName { get; set; }
        public string AddressDetail { get; set; }
        public int CustomerId { get; set; }
    }
}
