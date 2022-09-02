internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите ваше имя");
        string username = Console.ReadLine();
        Console.Write("Привет, ");
        Console.Write(username);
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
