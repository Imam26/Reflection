using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class TestClass
    {
        public int FirstProperty { get; set; }
        public string SecondProperty { get; set; }
        public bool ThirdProperty { get; set; }
        public float FourthProperty { get; set; }

        public TestClass()
        {
            FirstProperty = 100;
            SecondProperty = "Второй параметр";
            ThirdProperty = true;
            FourthProperty = 18.12f;
        }
    }
}
