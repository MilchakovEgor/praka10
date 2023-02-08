using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal interface ICrud
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }
}