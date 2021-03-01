using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lista = new Lista();

            Lista.Add("Hello");
            Lista.Add("World");
            
            string[] arrayDeStrings = { "Written", "from", "my", "own", "Class", "List!"};
            Lista.AddMany(arrayDeStrings);

            Console.WriteLine(Lista);

            Lista.Remove(0);
            Console.WriteLine(Lista);

            Lista.Remove(3);
            Console.WriteLine(Lista);

            Lista.RemoveAll();
            Console.WriteLine(Lista);
        }
    }
}
