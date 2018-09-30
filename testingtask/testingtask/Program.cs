using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testingtask
{
    class Program
    {
        static void Main(string[] args)
        {
            asdfd();
            //Thread.Sleep(4000); met deze lijn pakt hij hem wel omdat main dan nog niet klaar is 
        }

        private static async void asdfd()
        {
            var test = anothermethod();
            Console.WriteLine(test.IsFaulted);
            Console.WriteLine(test.IsCompleted);
            await test;

        
        }

        private static async Task anothermethod()
        {
            //Thread.Sleep(3000);
            //Console.WriteLine("test");
            throw new NotImplementedException();
        }
    }
}
