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
			int[] itensToRemove = {0, 3};
            Lista.RemoveMany(itensToRemove);

			
            // Lista.Add("Hello 2");
             Console.WriteLine(Lista);

            // Lista.Remove(3);
            // Console.WriteLine(Lista);

        //     Lista.RemoveAll();
        //     Console.WriteLine(Lista);
        }
    }
}
