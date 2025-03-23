using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSD_Game_Beginner_CSharp_Exercise.Classes
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public void Multiple(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine($"{num1} x {num2} = {result}");
        }

        public void Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("나누려는 값이 0 입니다.");
            }

            double result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result}");
        }
    }

    public static class CallByValueExercise
    {
        public static void Swap(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }

    public static class CallByReferenceExercise
    {
        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }

    public static class MultipleReturnExercise
    {
        public static void Divide(int num1, int num2, out int result1, out int result2)
        {
            result1 = num1 / num2;
            result2 = num1 % num2;
            //함수 종료 전까지 결과를 저장하지 않으면 컴파일 오류가 발생.
        }
    }

    public static class MethodOverloadingExercise
    {
        public static void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
        }

        public static void Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
        }
    }

    public static class ParamsExercise
    {
        public static void Sum(params int[] nums)
        {
            int sum = 0;
            for (int i=0; i<nums.Length; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine($"합계 : {sum}");
        }
    }

    public static class NamedArgumentsExercise
    {
        
        public static void Player(string ID, int health)
        {
            Console.WriteLine($"ID : {ID}, HP : {health}");
        }
    }

    public static class OptionalArgumentsExercise
    {
        public static void Player(string ID, int health = 100)
        {
            Console.WriteLine($"ID : {ID}, HP : {health}");
        }
    }
}
