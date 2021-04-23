using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    class DierSoort:Dier
    {
        public string dierSoortZegt { get; set; }
        public string dierSoort { get; set; }
        public override void Zegt()
        {
            Console.WriteLine(dierSoortZegt);
        }
        public override string ToString()
        {
            string _ToString = $" diersoort:\t{dierSoort}\n";
            _ToString += $" {dierSoort} zegt:\t{dierSoortZegt}\n";
            _ToString += $" gewicht:\t{Gewicht}\n";

            return _ToString;
        }
    }
}
