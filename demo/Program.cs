using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Demo;
using System.Diagnostics;
using Google.Protobuf;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                SchoolAddr = new Address()
            };
            //Debug.Assert(!person.HasId2);

            byte[] result = new byte[person.CalculateSize()];
            CodedOutputStream output = new CodedOutputStream(result);
            person.WriteTo(output);


            Person person1 = new Person();
            person1.MergeFrom(result);

            Console.WriteLine(person1.Id2);

            if(person1.SchoolAddr != null)
            {
                Console.WriteLine("has school!");
            }

            Console.WriteLine(person1.Id2);
            if(person1.HasId2)
            {
                Console.WriteLine("has id2!");
            }
            Console.WriteLine("enter key!");
            Console.ReadKey();
        }
    }
}
