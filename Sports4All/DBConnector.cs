using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    static class DBConnector
    {
        private static QxP1IZ6nAWEntities context { get; set; }

        public static QxP1IZ6nAWEntities getContext()
        {
            if (context == null)
                context = new QxP1IZ6nAWEntities();

            return context;
        }

    }
}
