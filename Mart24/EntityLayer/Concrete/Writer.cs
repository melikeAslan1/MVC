﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {//Yazar
        [Key]
        public int? WriterId { get; set; }

        [StringLength(20)]
        public string WriterName { get; set; }

        [StringLength(20)]
        public string WriterSurname { get; set; }

        [StringLength(50)]
        public string WriterEmail { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public ICollection<Content> Contents { get; set; }
        public ICollection<Heading> Headings { get; set; }


    }
}
