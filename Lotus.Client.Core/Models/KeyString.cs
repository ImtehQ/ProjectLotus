using System;
using System.Collections.Generic;
using System.Text;

namespace Lotus.Client.Core.Models
{
    public class KeyString
    {
        public string word;
        public Key key;

        public KeyString(string value, int keyValue)
        {
            word = value;
            key = new Key(keyValue);
        }
    }
}
