using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/*2.	Описать класс с несколькими свойствами. Создать экземпляр класса и инициализировать его свойства. 
 * С помощью рефлексии получить свойства и их значения из созданного экземпляра класса. 
 * Вывести полученные значения на экран*/

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            PropertyInfo [] properties = testClass.GetType().GetProperties();
            
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine("{0}:{1} ",property.Name, property.GetValue(testClass));
            }

        }
    }
}
