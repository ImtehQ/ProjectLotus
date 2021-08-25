using Lotus.Client.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotus.Client.Data.Services
{
    public class DataBaseService
    {
        public List<KeyString> keyStringList;

        private readonly IDatabaseRepository _repository;
        public DataBaseService(IDatabaseRepository dataRepository)
        {
            _repository = dataRepository;

        }

        private void Load()
        {
            _repository.Load();
        }
    }
}
