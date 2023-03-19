// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        DataGeneric<String> obj = new DataGeneric<String>("Halo");
        obj.PrintData();
    }
}
class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}