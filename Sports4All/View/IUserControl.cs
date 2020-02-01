using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public interface IUserControl
    {
        string Id { get; set; }

        void Populate();
    }
}
