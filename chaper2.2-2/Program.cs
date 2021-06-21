using System;
using System.Collections;

namespace chaper2._2_2
{
    class Program
    {
        static void Main(string[] args)
        {
           PrintNames(GetArrayList());
            Console.ReadKey();
        }
         
        static ArrayList GetArrayList()
        {
            ArrayList names = new ArrayList();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }
        static void PrintNames(ArrayList names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
}
