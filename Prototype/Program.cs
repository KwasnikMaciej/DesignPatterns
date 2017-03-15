using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var dev = new Developer()
            {
                Name = "Bob",
                Role = "Team Leader",
                PrefferedLanguage = "C#"
            };

            var devCopy = (Developer)dev.Clone();
            devCopy.Name = "Sue";
            devCopy.PrefferedLanguage = "Java";

            Console.WriteLine(dev);
            Console.WriteLine(devCopy);

            var typist = new Typist()
            {
                Name = "Sue",
                Role = "Typist",
                WordsPerMinute = 120
            };

            var typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Tim";
            typistCopy.WordsPerMinute = 115;

            Console.WriteLine(typist);
            Console.WriteLine(typistCopy);

            Console.ReadKey();
        }
    }
}
