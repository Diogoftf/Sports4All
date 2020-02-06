using System.Collections.Generic;

namespace Sports4All
{
   public class Picture
    {
        public int PictureId { get; set; }
        public string Path { get; set; }
        public virtual Sport Sport { get; set; }
        public virtual Park Park { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual Ground Ground { get; set; }
        
    }
}
