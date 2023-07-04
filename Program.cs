public class Singelton
{
    private static Singelton _instance;

    public static Singelton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singelton();
        }
        return _instance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Singelton s1 =  Singelton.GetInstance();
        Singelton s2 =  Singelton.GetInstance();
        if (s1 == s2)
        {
            Console.WriteLine("Singelton works");
        }
        else
        {
            Console.WriteLine("not working");
        }
    }
}
