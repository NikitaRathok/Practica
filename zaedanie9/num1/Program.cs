using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            TestClass tc = new TestClass();
            tc.F1();
            tc.F0(10);
            tc.IxF0(10);
            tc.IxF1();  
            var objIz = tc as Iz;
            objIz.F0(10);
            objIz.F1();
        }
    }
}
