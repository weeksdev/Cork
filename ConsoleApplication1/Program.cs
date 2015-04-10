using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveNinjaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Root Note>>>");
            var key = Console.ReadKey().KeyChar.ToString();
            var scale = LoveNinja.Music.GetScale(key, LoveNinja.Music.Scales.Major);
            Console.WriteLine();
            var display = String.Join(" ", scale.Select(a=>a.name).ToList());
            Console.WriteLine(display);
            Console.WriteLine();
            Console.Write("Root Note for Chord>>>");
            var note = Console.ReadKey().KeyChar.ToString();
            var chords = LoveNinja.Music.Chords.GetChords(note, LoveNinja.Music.Chords.MajorChords);
            display = string.Join(" ", chords.Select(a => a.name + a.chordType).ToList());
            Console.WriteLine();
            Console.WriteLine(display);
            Console.ReadKey();
        }
    }
}
