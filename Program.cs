public class GenericDelegate
{

    public delegate double AddNumber1Delegate(int no1, float no2, double no3);
    public delegate void AddNumber2Delegate(int no1, float no2, double no3);
    public delegate bool CheckLengthDelegate(string name);


    public static void Main(string[] args)
    {

        AddNumber1Delegate del1 = new AddNumber1Delegate(AddNumber1);

        double result = del1.Invoke(100, 125.45f, 456.789);

        Console.WriteLine(result);

        /**
         * Function generic delegates take an input parameter and return value
         * and the output value is passed as the last enter parameter <..., ..., double>
         * where the double is the output parameter
         * **/
        Func<int, float, double, double> obj1 = new Func<int, float, double, double>(AddNumber1);

        double _funcDel = obj1.Invoke(100, 125.45f, 456.789);

        Console.WriteLine($"Function Delegate: {_funcDel}");

        //Function generic delegates ends here

        AddNumber2Delegate del2 = new AddNumber2Delegate(AddNumber2);

        del2.Invoke(50, 255.45f, 123.456);

        /**
         * Action delegate takes a parameter but does not return any
         * so instead of creating a delegate like del2 above we just
         * use the Action generic delegate.
         * 
         * NB: The Action generic delegate take a maximum of 16 parameter and outputs nothing.
         * **/

        Action<int, float, double> obj2 = new Action<int, float, double>(AddNumber2);

        obj2.Invoke(50, 255.45f, 123.456);

        CheckLengthDelegate del3 = new CheckLengthDelegate(CheckLength);

        bool status = del3.Invoke("Ikechukwu Daniel");

        Console.WriteLine(status);

        /**
         * The predicate delegate takes a maximum of 1 input parameter of any type
         * and returns a boolean value. we dont' need to specify the return type since it 
         * returns a boolean.
         * **/
        Predicate<string> obj3 = new Predicate<string>(CheckLength);
        bool Status = obj3.Invoke("Germany");
        Console.WriteLine(Status);
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
        if (name.Length > 5)
            return false;
        return true;
    }

}