using System;
using faves.FaveThings;

namespace faves
{
    class Program
    {
        static void Main(string[] args)
        {
            var welcomeSign = new Threads("cross-stitch", 8);
            welcomeSign.NewProject("subversive");
            welcomeSign.Ouch();

            var jacksSock = new Threads("darn", 1);
            jacksSock.NewProject("right neighborly");
            jacksSock.Ouch();
            jacksSock.Ouch();
            jacksSock.Ouch();

            var melba = new Animal("Melly-belly", "cheddar cheese");
            melba.TippyTap("happy dance");
            melba.Play("tug-o-war");

            var cormac = new Animal("Cormac", "cow bones");
            cormac.TippyTap("groans");
            cormac.Play("snore");
        }
    }
}
