using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterDll
{
    public class Tester
    {
        public int field;
        public int Property { get; set; }
        public void TestMethod() { }

        public int field2;
    }


    public static class ExtMethods
    {
        public static void TestMethod2(this Tester obj) { }
        public static void TestMethod3(this Tester obj, string str) { }
    }
}
