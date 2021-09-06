using System;
using System.Collections.Generic;
using System.Text;

namespace Lotus.Client.Core.Models
{
    public class KeyString
    {
        public int value;
        public string word;

        public KeyString(string value, int keyValue)
        {
            word = value;
            this.value = keyValue;
        }
    }
}
