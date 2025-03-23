using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSD_Game_Beginner_CSharp_Exercise.Classes
{
    public class PlayerAdvanced
    {
        private int currentHP;

        public void SetCurrentHP(int hp)
        {
            if(hp>0)
            {
                currentHP = hp;
            }
        }

        public int GetCurrentHP()
        {
            return currentHP;
        }
    }

    public class Entiry
    {
        public string ID;
        protected int currentHP;

        private void Initialize()
        {
            ID = "Noname";
        }

        public void RecoveryHP(int hp)
        {
            currentHP += hp;
        }
    }

    public class PlayerInheritence : Entiry
    {
        public PlayerInheritence(string id, int hp)
        {
            base.ID = id;
            currentHP = hp;

            RecoveryHP(1000);
            //Initialize(); -> private 이기 떄문에 오류
        }
    }

    public class Entity
    {
        public void Attack()
        {
            Console.WriteLine("적을 공격한다.");
        }

        public virtual void Heal()
        {
            Console.WriteLine("체력을 회복한다");
        }
    }

    public class Goblin : Entity
    {
        public void Avoid()
        {
            Console.WriteLine("도망가자!!");
        }
    
        public override void Heal()
        {
            Console.WriteLine("고블린의 체력 회복!");
        }
    }

    public class IsAsExercise
    {
        private void Awake()
        {
            Entity entity = new Goblin();
            if(entity is Goblin)
            {
                Console.WriteLine("Entity type is Goblin!");
            }

            Goblin? goblin = entity as Goblin;

            if (goblin == null)
            {
                Console.WriteLine("Goblin is nul!");
            }
        }
    }


}
