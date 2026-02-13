public class GenericDelegate
{

    public delegate double AddNumber1Delegate(int no1, float no2, double no3);
    public delegate void AddNumber2Delegate(int no1, float no2, double no3);
    public delegate bool CheckLengthDelegate(string name);


    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
    }


    public static double AddNumber1(int no1, float no2, double no3)
    {
        return no1 + no2 + no3;
    }

    public static void AddNumber2(int no1, float no2, double no3)
    {
        Console.WriteLine(no1 + no2 + no3);
    }

    public static bool CheckLength(string name)
    {
        if(name.Length > 5)
            return false;
        return true;
    }

}