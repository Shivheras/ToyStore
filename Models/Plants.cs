using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore.Models
{
    class Plants
    {
        [Key]
        public int PlantId { get; set; }
        public string PlantName { get; set; }
       
    }
}
