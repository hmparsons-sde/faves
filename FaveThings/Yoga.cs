using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faves.FaveThings
{
    class Yoga
    {
        public string Style { get; set; } = "Hatha";
        public string Intensity { get; set; } = "moderate";
        int _numberOfPoses;
        public Yoga(string style)
        {
            Style = style;
            _numberOfPoses = 26;
            Intensity = "moderate";

            if (style.ToLower() == "Restorative")
            {
                Intensity = "chill";
            }
            else if (style.ToLower() == "Yoga Nidra")
            {
                Intensity = "super duper chill";
            }
            else if (style.ToLower() == "Baptiste")
            {
                Intensity = "intense";
            }
            else if (style.ToLower() == "Heated Vinyasa")
            {
                Intensity = "unbearable";
            }
            else
            {
                _ = Intensity;
            }
        }
        public void Sequence(int poses)
        {
            _numberOfPoses++;
            if (_numberOfPoses > 26)
            {
                Console.WriteLine("This is an intense sequence");
            }
            else
            {
                Console.WriteLine("Chillin like a villain");
            }
        }
        public void Stretch()
        {
            Console.WriteLine("Yaaaas queen! Get it!");
        }

    }
}
