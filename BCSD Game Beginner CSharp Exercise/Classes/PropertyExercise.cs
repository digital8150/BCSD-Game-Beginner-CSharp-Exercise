using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSD_Game_Beginner_CSharp_Exercise.Classes
{
    internal class PropertyExercise
    {
        private string _name = "name";
        private int _value;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }

    class AutoProperty
    {
        public int CurrentHP
        {
            get; private set;
        }

        public string ID
        {
            get; set;
        }
    }

    class PropertyInit
    {
        public void Init()
        {
            PropertyExercise propertyExercise = new PropertyExercise()
            {
                Name = "name",
                Value = 1
            };
        }
    }
}
