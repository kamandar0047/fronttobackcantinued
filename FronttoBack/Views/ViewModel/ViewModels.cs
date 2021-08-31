using FronttoBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FronttoBack.Views.ViewModel
{
    public class ViewModels
    {

        public List<Slide> Slides { get; set; }
        public  List<Introduction> Introductions { get; set; }

        public List<Catagory> Catagories { get; set; }
        public List<Product> Products { get; set; }
    }
}
