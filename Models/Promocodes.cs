using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore.Models
{
    class Promocodes
    {
        [Key]
        public int PromocodeId { get; set; }
        public string PromocodeName { get; set; }
        public string Detail { get; set; }
    }
}
