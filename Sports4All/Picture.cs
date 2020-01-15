using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
   public class Picture
    {
        public int PictureId { get; set; }
        public string PicdtureBody { get; set; }
        public virtual Sport Sport { get; set; }
        public virtual Park Park { get; set; }
        public virtual User User { get; set; }
        public virtual Ground Ground { get; set; }
    }
}
