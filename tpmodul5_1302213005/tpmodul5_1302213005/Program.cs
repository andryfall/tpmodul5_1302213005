// See https://aka.ms/new-console-template for more information


internal class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nama Praktikan : ");
        String input = Console.ReadLine();
        HaloGeneric.SapaUser<String>(input);
    }
}

public class HaloGeneric
{
    public static void SapaUser<T>(T input)
    {
        Console.WriteLine("Halo user " + input);
    }
}