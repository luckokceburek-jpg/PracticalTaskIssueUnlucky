using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    internal class Song
    {
        public string Name { get; set; }
        public double Time { get; set; }
        public string Style { get; set; }
        public Song(string name, double time, string style)
        {
            Name = name;
            Time = time;
            Style = style;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Time {Time}, Style: {Style}";
        }
    }
}
