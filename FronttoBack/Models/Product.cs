using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FronttoBack.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public  double  Price { get; set; }
        public int Count { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public int CatagoryId { get; set; }
        public Catagory Catagory  { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<DateTime> Deleted { get; set; }
    }
    }

