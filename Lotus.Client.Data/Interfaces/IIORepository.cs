using Lotus.Client.Data.Models;
using System.Collections.Generic;

namespace Lotus.Client.Data
{
    public interface IIORepository
    {
        void Add(string value);
        bool Exist(string value);
        void Find(string value);
        List<string> Load();
    }
}