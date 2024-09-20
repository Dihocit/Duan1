﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.database.Models
{
    [Table ("Authorized")]
    public  class Authorized
    {
        [Key]
        public Guid Id { get; set;  }
        [ForeignKey("GroupId")]
        public Guid? GroupId { get; set; }
        [ForeignKey("RoleId ")]
        public Guid? RoleId { get; set; }
        public Role? Role { get; set; }
        public Group? Group { get; set; }

    }
}
