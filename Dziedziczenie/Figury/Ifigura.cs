using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    interface Ifigura //dodajemy duze I przed nazwą interfejsów. W interfejsach piszemy tylko i wylacznie metody które beda wykorzystywane w klasach wykoryzstujacych interfejs
    {
        double obliczPole();
        double obliczObwod();
    }
}
