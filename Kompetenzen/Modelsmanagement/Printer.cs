using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelsmanagement
{
    public class Printer
    {
        public void PrintInfo(IPrintable printable)
        {
            printable.PrintInfo();
        }
    }
}
