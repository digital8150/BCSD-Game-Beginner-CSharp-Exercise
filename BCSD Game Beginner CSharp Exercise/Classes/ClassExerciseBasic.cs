using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BCSD_Game_Beginner_CSharp_Exercise.Classes
{
    public class Player
    {
        private string ID = "고박사";
        private int currentHP = 100;

        public Player()
        {
            ID = "고박사";
        }

        public Player(int hp): this()
        {
            currentHP = hp;
        }

        public Player(string ID, int currentHP): this(currentHP)
        {
            this.ID = ID;
        }

        public Player DeepCopy()
        {
            Player clone = new Player();
            clone.ID = ID;
            clone.currentHP = currentHP;
            return clone;
        }

        private void Awake()
        {
            TakeDamage(100);
        }

        public void TakeDamage(int damage)
        {
            if(currentHP > damage)
            {
                currentHP -= damage;
            }
        }
    }

    public class Enemy
    {
        private Player player;

        public void AttackToTarget(Player target)
        {
            target.TakeDamage(100);
        }
    }

    public class GameController
    {
        public Player player01;
        public Player player02;

        private void Awake()
        {
            player01 = new Player();
            player01.TakeDamage(100);
            player02 = new Player();
            player02.TakeDamage(200);
        }
    }


    public abstract class AbstractEntity
    {
        protected int damage;
        protected int currentHP;

        public abstract void Attack(AbstractEntity Target);
        public void TakeDamage(int damage)
        {
            if(currentHP > damage)
            {
                currentHP -= damage;
                Console.WriteLine($"체력이 {damage} 감소!");
            }
            else
            {
                Console.WriteLine("DIE");
            }
        }
    }

    public class NewGoblin : AbstractEntity
    {
        public NewGoblin(int damage, int hp)
        {
            base.damage = damage;
            currentHP = hp;
        }

        public override void Attack(AbstractEntity Target)
        {
            Console.WriteLine("고블린의 몽둥이 스매시");
            Target.TakeDamage(damage);
        }
    }

    interface IMovingEntity
    {
        void MoveTo(Vector3 destination);
    }

    public class MovingGoblin : IMovingEntity
    {
        public void MoveTo(Vector3 destination)
        {
            Console.WriteLine($"{destination}까지 걸어서 이동.");
        }
    }
}
