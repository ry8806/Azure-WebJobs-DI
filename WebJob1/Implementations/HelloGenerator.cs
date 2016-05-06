using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJob1.Implementations
{
    class HelloGenerator : IStringGenerator
    {
        public string GetWord()
        {
            return "Hello";
        }
    }
}
