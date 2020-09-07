using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbhijeetConsole
{
    class boxingvsunboxing
    {
        
            int i = 1;
            object obj = i;//boxing--when value type assigned to reference type--boxing
            int y = (int)obj;//unboxing--when value type extract from reference type--unboxing
            Console.WriteLine(y);
    }
}
