using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    public class LineCounterService : ITextFileService {
        private int _count = 0;

        public void Initialize(string fname) => _count = 0;

        public bool Execute(string line) {
            _count++;
            return true;
        }

        public void Terminate() => Console.WriteLine("{0}行", _count);
    }
}
