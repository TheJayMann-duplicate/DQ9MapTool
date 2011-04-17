using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DQ9MapTool {
    static class Random {
        public static IEnumerable<uint> GetRandom(uint seed) {
            for(;;){
                seed = seed * 0x41c64e6dU + 0x3039U;
                yield return seed >> 0x10 &0x7FFFU;
            }
        }
    }
}
