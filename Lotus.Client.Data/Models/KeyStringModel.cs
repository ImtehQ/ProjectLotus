using System;
using System.Collections.Generic;
using System.Text;

namespace Lotus.Client.Data.Models
{
    public class KeyStringModel
    {
        public int Id { get; set; }
        public int KeyId { get; set; }
        public string StringValue {  get; set; }
        public int KeyType { get; set; }
        public int KeyValue { get; set; }
        public int KeySet { get; set; }
    }
}
