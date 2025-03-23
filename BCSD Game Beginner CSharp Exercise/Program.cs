using BCSD_Game_Beginner_CSharp_Exercise.Classes;

class Program
{
    public static void Main(string[] args)
    {
        TestCalc();
        TestCallByRef();
        TestCallByValue();
        TestMultipleReturn();
        TestMethodOverloading();
        TestParams();
        TestNamedArguments();
        TestOptionalArguments();
    }


    private static void TestCalc()
    {
        int num1 = 1;
        int num2 = 2;

        Console.WriteLine($"{num1} + {num2} = {new Calculator().Add(num1, num2)}");
        new Calculator().Multiple(num1, num2);
        new Calculator().Divide(num1, num2);
    }

    private static void TestCallByValue()
    {
        int num1 = 23;
        int num2 = 34;
        Console.WriteLine("값에 의한 호출로 구현된 Swap 테스트");
        Console.WriteLine($"num1 : {num1}, num2 : {num2}");
        CallByValueExercise.Swap(num1, num2);
        Console.WriteLine($"num1 : {num1}, num2 : {num2}");
    }

    private static void TestCallByRef()
    {
        int num1 = 23;
        int num2 = 34;
        Console.WriteLine("참조에 의한 호출로 구현된 Swap 테스트");
        Console.WriteLine($"num1 : {num1}, num2 : {num2}");
        CallByReferenceExercise.Swap(ref num1, ref num2);
        Console.WriteLine($"num1 : {num1}, num2 : {num2}");
    }

    private static void TestMultipleReturn()
    {
        int num1 = 52;
        int num2 = 5;
        int result1, result2;

        MultipleReturnExercise.Divide(num1, num2, out result1, out result2);
        Console.WriteLine($"다중 리턴 테스트: return1 = {result1}, return2 = {result2}");
    }

    private static void TestMethodOverloading()
    {
        MethodOverloadingExercise.Add(1, 2);
        MethodOverloadingExercise.Add(1.2, 2.3);
    }

    private static void TestParams()
    {
        ParamsExercise.Sum(1);
        ParamsExercise.Sum(1,2);
        ParamsExercise.Sum(1,2,3);
        ParamsExercise.Sum(1,2,3,4);
    }

    private static void TestNamedArguments()
    {
        NamedArgumentsExercise.Player("Player1", 200);
        NamedArgumentsExercise.Player(ID : "Player2", health: 100);
        NamedArgumentsExercise.Player(health: 100, ID: "Player3");
    }

    private static void TestOptionalArguments()
    {
        OptionalArgumentsExercise.Player("Player1", 300);
        OptionalArgumentsExercise.Player("Player2");
    }
}

