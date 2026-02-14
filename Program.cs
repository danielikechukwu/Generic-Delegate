public class GenericDelegate
{

    public delegate double AddNumber1Delegate(int no1, float no2, double no3);
    public delegate void AddNumber2Delegate(int no1, float no2, double no3);
    public delegate bool CheckLengthDelegate(string name);


    public static void Main(string[] args)
    {
        /**
         * Making using of the Func Generic
         * **/
        AddNumber1Delegate del1 = new AddNumber1Delegate(AddNumber1);

        double result = del1.Invoke(100, 125.45f, 456.789);

        Console.WriteLine(result);

        //The last type will be the output parameter
        Func<int, float, double, double> obj1 = new Func<int, float, double, double>(AddNumber1);

        double _funcDel = obj1.Invoke(100, 125.45f, 456.789);

        Console.WriteLine($"Function Delegate: {_funcDel}");

        AddNumber2Delegate del2 = new AddNumber2Delegate(AddNumber2);

        del2.Invoke(50, 255.45f, 123.456);

        CheckLengthDelegate del3 = new CheckLengthDelegate(CheckLength);

        bool status = del3.Invoke("Ikechukwu Daniel");

        Console.WriteLine(status);


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