using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumeWS.RefWs;

namespace ConsumeWS
{
     class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SrGetRemndSoapClient sr = new SrGetRemndSoapClient();

                Console.WriteLine(" First Number :");
                float x = Single.Parse(Console.ReadLine());
                Console.WriteLine(" Second Number :");
                float y = Single.Parse(Console.ReadLine());

                Console.WriteLine(sr.GetRemainder(x, y));
                Console.ReadLine();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }




        }
    }
}
