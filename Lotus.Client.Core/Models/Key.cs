using System;
using System.Collections.Generic;
using System.Text;

namespace Lotus.Client.Core.Models
{
    public struct Key
    {
        private int id;
        private byte type;
        private byte firstValue;
        private byte secondValue;
        private byte set;

        private const int setShift = 24;
        private const int TypeShift = 16;
        private const int firstValueShift = 8;
        private const int secondValueShift = 0;

        public Key(byte t, byte fv, byte sv, byte s)
        {
            long Data = (long)(unchecked((uint)
                        (t << TypeShift |
                         fv << firstValueShift |
                         sv << secondValueShift |
                         s << setShift)))
                         & 0xffffffff;
            type = t;
            firstValue = fv;
            secondValue = sv;
            set = s;
            id = (int)Data;
        }

        public Key(int Data)
        {
            id = Data;
            type = (byte)((Data >> TypeShift) & 0xFF);
            firstValue = (byte)((Data >> firstValueShift) & 0xFF);
            secondValue = (byte)((Data >> secondValueShift) & 0xFF);
            set = (byte)((Data >> setShift) & 0xFF);
        }

        public int GetKeyValue()
        {
            return firstValue * secondValue;
        }
        public int GetKeySet()
        {
            return set;
        }
        public int GetKeyId()
        {
            return id;
        }
        public int GetKeyType()
        {
            return type;
        }
    }
}
