using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(System.Console);

            foreach(MethodInfo info in type.GetMethods())
            {        
                Console.Write((info.IsVirtual?"virtual ":(info.IsStatic?"static ":""))
                    +info.ReturnType.Name +" "+ info.Name + "(");
                foreach(ParameterInfo param in info.GetParameters())
                {
                    Console.Write(param.ParameterType.Name + " "+param.Name);
                }
                Console.WriteLine(")");
            }
        }
    }
}
