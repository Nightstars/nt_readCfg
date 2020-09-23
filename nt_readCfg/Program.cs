using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_readCfg
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = ConfigurationManager.AppSettings["demo"].ToString();
            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}
