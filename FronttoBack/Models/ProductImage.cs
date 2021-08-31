using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FronttoBack.Models
{
    public class ProductImage
    {

        public int Id { get; set; }
        public string Image { get; set; }
        public int PoductId { get; set; }
        public Product Product { get; set; }
    }
}
