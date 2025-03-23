using System;
using System.Collections.Generic;
using System.Linq;
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
}
