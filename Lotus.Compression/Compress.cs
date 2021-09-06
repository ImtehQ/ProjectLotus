using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lotus.Compression
{
    public class Compress
    {
        private readonly Paths _paths;
        private readonly SetFileManager _setFileManager;


        string[] inputData;
        uint[] inputDataValues;
        uint[] ConvertedDataValues;

        public Compress(Paths paths, SetFileManager setFileManager)
        {
            _paths = paths;
            _setFileManager = setFileManager;
        }

        public void Read(string input)
        {
            inputData = input.Split(' ');
            inputDataValues = new uint[inputData.Length];
            uint? foundValue = null;    

            for (int i = 0; i < inputData.Length; i++)
            {
                foundValue = _setFileManager.FindValue(inputData[i]);
                if (foundValue == null)
                {
                    _setFileManager.RegisterNewValue(inputData[i]);
                }
                else
                {
                    inputDataValues[i] = foundValue.Value;
                }
            }
        }

    }
}
