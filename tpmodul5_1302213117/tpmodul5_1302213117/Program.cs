internal class Program
{
    private static void Main(string[] args)
    {
        DataGeneric<string> siswa = new DataGeneric<string>("1302213117");
        siswa.PrintData();
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: "+data);
    }
}