using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FronttoBack.Models
{
    public class Introduction
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }

        public static implicit operator Introduction(List<Introduction> v)
        {
            throw new NotImplementedException();
        }
    }
}
