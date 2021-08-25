using Lotus.Client.Data.Contexts;
using Lotus.Client.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotus.Client.Data
{
    public class IORepository : IIORepository
    {
        private readonly IOContext _dataContext;
        public IORepository()
        {
        }
        public IORepository(IOContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<KeyStringModel> Load()
        {
            return _dataContext.keyStringModelList;
        }

        public void Add(string value)
        {
            throw new NotImplementedException();
        }

        public bool Exist(string value)
        {
            throw new NotImplementedException();
        }


        public void Find(string value)
        {
            throw new NotImplementedException();
        }
    }
}
