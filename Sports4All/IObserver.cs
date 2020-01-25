using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    interface IObserver
    {
        void Update(ISubject subject);
    }
}
