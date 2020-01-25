using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    static class Points
    {
        public static readonly double _eventPerformed_Weight = 3;
        public static readonly double _reservePerformed_Weight = 2;
        public static readonly double _fairplay_Weight = 4;
        public static readonly double _skill_Weight = 3;
        public static readonly double _racio_Weight = 2;
        public static readonly double _levelChange = 100; // variavel somente usada para determinar a quantidade de pontos necessaria para transitar de nivel

        public static readonly double _ParkPrice_Weight = 3;
        public static readonly double _ParkQuality_Weight = 4;
    }
}
