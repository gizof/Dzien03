using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.KlasaStatyczna
{
   static class Utils
    {
        public static string hostname = "localhost";
        public static int portNumber = 3306;

        public static int GetMaxValue(params int[] args) //metoda przyjmująca wiele argumentów typu int
        {
            return args.Max();
        }
    }
}
