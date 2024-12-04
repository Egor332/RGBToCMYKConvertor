using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGBToCMYKConvertor.DataManagers
{
    public class Reader
    {
        public static List<string> ReadFromFile(string filename)
        {

            StreamReader sr = new StreamReader(filename);
            string line = sr.ReadLine();

            List<string> result = new List<string>();
            while (line != null)
            {
                result.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            return result;
        }
    }
}
