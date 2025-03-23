using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSD_Game_Beginner_CSharp_Exercise.Classes
{
    internal class ClassAdditiveFunctionExercise
    {
        public class Parent
        {
            public void Method01()
            {
                Console.WriteLine("Parent");
            }
        }

        public class  Child:Parent
        {
            public new void Method01()
            {
                Console.WriteLine("Child");
            }
        }

        public struct Stats
        {
            public string ID;
            public int currentHP;
            public int damage;
        }

        public class GameController
        {
            private void Awake()
            {
                Stats player01 = new Stats();
                Stats player02;

                player02.ID = "고박사";
                player02.currentHP = 100;
                player02.damage = 100;

                Console.WriteLine($"{player01.ID}, 체력 : {player01.currentHP}, 공격력 : {player01.damage}");
                Console.WriteLine($"{player02.ID}, 체력 : {player02.currentHP}, 공격력 : {player02.damage}");


            }
        }

        public class TupleExercise
        {
            public void tuple()
            {
                var a = ("고박사", 35);
                Console.WriteLine($"{a.Item1}, {a.Item2}");

                a.Item2 = 36;
                Console.WriteLine($"{a.Item1}, {a.Item2}");
            }
        }

        public class Enemy
        {
            static int enemyCount = 0;

            public Enemy()
            {
                enemyCount++;
            }
            public static void staticMethod01()
            {
                Console.WriteLine(enemyCount);
            }
        }

        private void testStringExtension()
        {
            string str = "안녕하세요. 고박사 입니다.";
            str.PrintData();
        }
       

    }

    //확장 메소드
    public static class StringExtension
    {
        public static void PrintData(this string str)
        {
            Console.WriteLine(str);
        }
    }
}


namespace BCSD_Game_Beginner_CSharp_Exercise.YourSpace
{
    public class Player
    {

    }
}

namespace BCSD_Game_Beginner_CSharp_Exercise.MySpace
{
    public class Player
    {

    }
}