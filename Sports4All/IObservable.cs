using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public delegate void UpdateHandler(IObservable source, object data);
    public interface IObservable
    {
        event UpdateHandler OnUpdate;
    }
}
