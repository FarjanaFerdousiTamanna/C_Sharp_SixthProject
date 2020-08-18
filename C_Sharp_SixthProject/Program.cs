using System;

namespace C_Sharp_SixthProject
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = new string[4];  //here, creating array by the command, String[] names
                                             // and allocating memory by new string [4];
            names[0] = "Tamanna";
            names[1] = "Mou";
            names[2] = "Rakib";
            names[3] = "Khan";

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
        }
    }
}
