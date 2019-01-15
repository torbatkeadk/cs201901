using System;
using System.Collections.Generic;
using System.Text;

namespace mineStructs
{
    public enum Kulør : byte { Hjerter = 1, Ruder = 2, Spar = 4, Klør = 4 }
    public struct SpilleKort
    {
        public int Værdi;
        public Kulør Kulør;
    }
}
