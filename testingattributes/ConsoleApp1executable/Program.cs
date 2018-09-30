using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Testingattributess;

namespace ConsoleApp1executable
{
    class Program
    {
        static void Main(string[] args)
        {

            var z =Type.GetType("dfdfdfd"); //runtime fout

            var zz=z.GetProperties();
            //Assembly dllcallingassembly = Assembly.Load("Testingattributes");

            typeof(serializingclass).GetMembers();

            //foreach (Assembly b in AppDomain.CurrentDomain.GetAssemblies()) {

            //    Console.WriteLine(b.FullName);

            //}

            Class1 informatiehalen = new Class1();
            serializingclass test = new serializingclass();


             informatiehalen.testmethod(test);

            //foreach(var x in z) { Console.WriteLine(x); }

        }



        public string yes() {

            


            return "dfdf";
        }
    }

    [DataContract]
    class serializingclass {
        
        [DataMember]
        public int number1 { get; set; }
        public string string1 { get; set; }
           
    }
}
