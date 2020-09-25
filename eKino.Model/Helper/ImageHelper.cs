using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Model.Helper    
{
    public class ImageHelper
    {
        public static byte[] GetImage(string sPath)
        {
            var s = Directory.GetCurrentDirectory();
            var c = GetDirectory.TryGetSolutionDirectoryInfo(s);
            var Path = c.FullName + @"\eKino.Model\Images\" + sPath;

            byte[] data = null;

            FileInfo fInfo = new FileInfo(Path);
            long numBytes = fInfo.Length;

            FileStream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);

            data = br.ReadBytes((int)numBytes);

            return data;
        }
    }
}
