using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace faves.FaveThings
{
    class Threads
    {
        // properties
        public string Name { get; set; }
        public int NumberOfColors { get; set; }
        public string Type { get; set; }
        // constructor methods
        public Threads(string name, int colors)
        {
            Name = name;
            NumberOfColors = colors;
        }
        // methods
        public void NewProject(string snarkyProject)
        {
            Console.WriteLine($"You are {Name}ing a {snarkyProject} project. You will need {NumberOfColors} spools of thread.");
        }

        public void Ouch()
        {
            Console.WriteLine($"You pricked your finger while {Name}ing.");
        }
    }
}
