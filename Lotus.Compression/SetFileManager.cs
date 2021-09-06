using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lotus.Compression
{
    public class SetFileManager
    {
        private readonly Paths _paths;

        public SetFileManager(Paths paths)
        {
            _paths = paths;
        }

        public uint? FindValue(string text)
        {
            string line;
            uint counter = 0;
            for (int i = 0; i < 255; i++)
            {
                System.IO.StreamReader file =
                new System.IO.StreamReader(_paths.GetFullSetPathAndSetName() + i.ToString() + _paths.SetFileType);
                while ((line = file.ReadLine()) != null)
                {
                    if (line == text)
                        return counter;
                    counter++;
                }
            }
            return null;
        }

        public void RegisterNewValue(string text)
        {
            var result = FindAvailableSet();
            uint count = result.Item1;
            uint? set = result.Item2;


            File.AppendAllText(_paths.GetFullSetPathAndSetName() + set.Value.ToString() + _paths.SetFileType, 
                text);

            //Now add it to the existing count file :s

        }

        public Tuple<uint, uint?> FindAvailableSet()
        {
            string lineValue;
            uint set = 0;

            System.IO.StreamReader file =
            new System.IO.StreamReader(_paths.GetFullSetPathAndSetSizeFileName(true));
            while ((lineValue = file.ReadLine()) != null)
            {
                uint _lineValue = uint.Parse(lineValue);
                if (_lineValue < 65536)
                    return new Tuple<uint, uint?>(_lineValue, set);
                set++;
            }

            return null;
        }
    }
}
