using Lotus.Client.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotus.Client.Data
{
    public class LocalDatabaseRepository : IDatabaseRepository
    {
        private readonly LocalDatabaseContext _dataContext;
        public LocalDatabaseRepository(LocalDatabaseContext dataContext)
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
