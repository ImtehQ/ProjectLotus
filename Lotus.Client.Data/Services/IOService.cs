using Lotus.Client.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotus.Client.Data.Services
{
    public class IOService
    {
        public List<KeyString> keyStringList;

        private readonly IIORepository _repository;
        public IOService(IIORepository ioRepository)
        {
            _repository = ioRepository;

        }

        private void Load()
        {
            _repository.Load();
        }
    }
}
