using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Testingattributess
{
    public class Class1
    {
        public void testmethod(object test)
        {


            //Type y = Type.GetType(test.GetType().AssemblyQualifiedName);
            
            Type instanttype = test.GetType();
            
            IEnumerable<PropertyInfo> deproperties = instanttype.GetRuntimeProperties();


            foreach (var infoproperty in deproperties) {

               List<Attribute> attributes= infoproperty.GetCustomAttributes().ToList();


                if (attributes.Count != 0)
                {
                    foreach (var attribute in attributes)
                    {
                        Console.WriteLine(attribute);

                    }
                }


                else {
                    Console.WriteLine($"property {infoproperty.Name}has no attributes");

                }
                                 
                

            }

            var x = test.GetType().Namespace.ToString();
            var assemblynaam = new AssemblyName(x);

            //Assembly dllcallingassembly = Assembly.Load(x);

           // var z = dllcallingassembly.GetType(test.GetType().ToString());

          

        }
    }
}
