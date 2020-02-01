using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public class Observable : IObservable
    {
        public event UpdateHandler OnUpdate;

        public void Notify(object aData = null)
        {
            OnUpdate?.Invoke(this, aData);
        }
    }
}
