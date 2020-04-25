using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//zmiana z poziomu githuba
namespace Dziedziczenie.Figury
{
    class okrag
    {
        private double srednica;
        
        public double ObliczPole()
        {
            return 3.14159 * (0.5 *srednica) * (0.5 *srednica);
        }
    }
}
