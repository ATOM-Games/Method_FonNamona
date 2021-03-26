using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FonaNama
{
    class Randome
    {
        public double[] rand = { 
                                   0.958524931202887,
                                   0.419451157757757,
                                   0.064834817342889,
                                   0.926384182612591,
                                   0.507446259496476,
                                   0.799762028641888
                               };
        int i = 0;
        public double NextDouble() {
            if (i >= rand.Length-1) i = 0; else i++;
            return rand[i];
        }
    }
}
