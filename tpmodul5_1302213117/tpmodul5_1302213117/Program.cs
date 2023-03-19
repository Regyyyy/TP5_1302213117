using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric<string> gen = new HaloGeneric<string>();
        gen.SapaUser("Regy");
    }
}

public class HaloGeneric<T>
{
    /*
    public keyValue[] Data;
    public int index;
    */
    public void SapaUser(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}