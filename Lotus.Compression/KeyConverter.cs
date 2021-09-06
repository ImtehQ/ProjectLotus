using System;
using System.Collections.Generic;
using System.Text;

namespace Lotus.Compression
{
    public static class KeyConverter
    {
        private const int setShift = 24;
        private const int TypeShift = 16;
        private const int firstValueShift = 8;
        private const int secondValueShift = 0;

        public static byte GetType(this uint value)
        {
            return (byte)((value >> TypeShift) & 0xFF);
        }

        public static uint GetKeyValue(this uint value)
        {
            return ((uint)((value >> firstValueShift) & 0xFF) * (uint)((value >> secondValueShift) & 0xFF));
        }

        public static byte GetSet(this uint value)
        {
            return (byte)((value >> setShift) & 0xFF);
        }

        public static Byte4 GetKey(this uint value)
        {
            byte a= (byte)((value >> setShift) & 0xFF);
            byte b= (byte)((value >> TypeShift) & 0xFF);
            byte c= (byte)((value >> firstValueShift) & 0xFF);
            byte d= (byte)((value >> secondValueShift) & 0xFF);

            return new Byte4(a, b, c, d);
        }

        public static uint GetValue(Byte4 byte4)
        {
            return (unchecked((uint)
                        (byte4.A << setShift |
                         byte4.B << TypeShift |
                         byte4.C << firstValueShift |
                         byte4.D << secondValueShift)))
                         & 0xffffffff;
        }
    }
}
