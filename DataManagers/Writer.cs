using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGBToCMYKConvertor.DataManagers
{
    public class Writer
    {
        public static void WriteToFile(string points, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(points);
            writer.Close();
        }
    }
}
