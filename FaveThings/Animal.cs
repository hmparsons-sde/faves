using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faves.FaveThings
{
    class Animal
    {
        //Properties
        public string Name { get; set; }
        public string FaveFood { get; set; }

        private bool _isFun = true;
        //Constuctor
        public Animal(string name, string faveFood)
        {
            Name = name;
            FaveFood = faveFood;
            Console.WriteLine($"The animal's name is {Name} and it loooooves {FaveFood}");
        }

        //Methods
        public void Play(string funActivity)
        {
            if (_isFun)
            {
                Console.WriteLine($"{Name} just wants to {funActivity}");
                _isFun = true;
            }
            else
            {
                Console.WriteLine($"{Name} would rather snooze.");
            }
        }
        public void TippyTap(string action)
        {
            Console.WriteLine($"{Name} has the best {action}");
        }
    }
}
