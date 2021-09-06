using System;
using System.Collections.Generic;
using System.Text;

namespace Lotus.Compression
{
    public class Paths
    {
        public string ApplicationSetPath = @"N:\LotusData";
        public string SetFolderPath = @"Sets\";
        public string SetName = "Default";
        public string SetSizeFileName = "DefaultSizeFile";
        public string SetFileType = ".txt";

        public string GetFullSetPath()
        {
            return ApplicationSetPath + @"\" + SetFolderPath + @"\" + SetName + @"\";
        }
        public string GetFullSetPathAndSetName(bool IncludeExtension = false)
        {
            if(IncludeExtension)
                return ApplicationSetPath + @"\" + SetFolderPath + @"\" + SetName + @"\" + SetName + SetFileType;
            return ApplicationSetPath + @"\" + SetFolderPath + @"\" + SetName + @"\" + SetName;
        }
        public string GetFullSetPathAndSetSizeFileName(bool IncludeExtension = false)
        {
            if(IncludeExtension)
                return ApplicationSetPath + @"\" + SetFolderPath + @"\" + SetName + @"\" + SetSizeFileName + SetFileType;
            return ApplicationSetPath + @"\" + SetFolderPath + @"\" + SetName + @"\" + SetSizeFileName;
        }
    }
}
