using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore.Models
{
    class Toys
    {
        [Key]
        public int ToyId { get; set; }
        public string ToyName { get; set; }
        public string ToyPrice { get; set; }
      
    }
}
