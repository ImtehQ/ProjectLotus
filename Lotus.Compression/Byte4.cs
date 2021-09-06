using System;
using System.Collections.Generic;
using System.Text;

namespace Lotus.Compression
{
    public struct Byte4
    {
        public Byte A, B, C, D;
        public Byte4(byte a, byte b, byte c, byte d)
        {
            A = a;
            B = b;
            C = c;
            D = c;
        }
    }
}
