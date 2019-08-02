using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_csharp
{
    interface IDateAndCopy
    {
        object DeepCopy();
        DateTime Birthday { get; set; }
    }
}
