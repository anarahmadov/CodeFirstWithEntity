﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithEntity.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Student> Students { get; set; }
    }
}
