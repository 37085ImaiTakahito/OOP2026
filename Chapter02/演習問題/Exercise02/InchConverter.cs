using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class InchConverter {
        private static readonly double ratio = 0.3048;
        
        public static double FromMeter(double meter) {
            return meter / ratio;
        }
        
        public static double ToMeter(double inch) {
            return inch * ratio;
        }
    }
}
