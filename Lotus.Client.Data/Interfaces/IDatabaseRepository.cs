using Lotus.Client.Data.Models;
using System.Collections.Generic;

namespace Lotus.Client.Data
{
    public interface IDatabaseRepository
    {
        void Add(string value);
        bool Exist(string value);
        void Find(string value);
        List<MessageBlock> Load();
    }
}