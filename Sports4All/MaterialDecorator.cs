using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
  public abstract class MaterialDecorator
  {
      protected CreateEvent _createEvent;

      public MaterialDecorator(CreateEvent createEvent)
      {
          this._createEvent = createEvent;
      }

      public void SetComponent(CreateEvent createEvent)
      {

          this._createEvent = createEvent;

      }


  }
}
