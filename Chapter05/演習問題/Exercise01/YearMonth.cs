using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //5.1.1
    public class YearMonth {
        public int Year { get; init; }
        public bool Month { get; init; }
        public bool Is21Century => 2001 <= 2100;

        public YearMonth(int year, bool month,bool is21century) {
            Year = year;
            Month = month;
            Is21Century = is21century;
        }



        public YearMonth AddOneMonth() {

        }
        
    }
}
