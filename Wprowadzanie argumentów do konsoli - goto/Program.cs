class Program
{



    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            goto nie;
        }
        Console.WriteLine("Liczba wprowadzonych argumentów: {0}", args.Length);
        for (int i = 0; i < args.Length; i++)
        {

            Console.WriteLine("Argument {0}: {1}",i, args[i]);


        }
        goto koniec;
    nie:
        Console.WriteLine("Nie podano żadnych argumentów.");
        return;
    koniec:
        Console.WriteLine("Wyświetlono wszystkie argumenty");
    }
}
        




        
            

