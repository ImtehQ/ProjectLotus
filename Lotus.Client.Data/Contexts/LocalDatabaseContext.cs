using Lotus.Client.Data.Models;
using System.Collections.Generic;

namespace Lotus.Client.Data
{
    public class LocalDatabaseContext : DataContext
    {
        public List<MessageBlock> MessageBlockList; //.Data layer model
    }
}
