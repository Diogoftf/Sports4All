﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
   public class Ground
    {
        public int GroundId { get; set; }
        public virtual ICollection<Sport> Sports { get; set; }
        public virtual Park Park { get; set; }
        public int ParkId { get; set; }
        public virtual Picture Picture { get; set; }
        public  ICollection<Reserve> Reserves { get; set; }

    }
}
