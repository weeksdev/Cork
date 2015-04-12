using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cork;
namespace CorkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablature newTab = new Tablature();
            newTab.AddRest(2);
            newTab.AddChord(Guitar.GuitarChords.Major.C, 'C');
            newTab.AddRest(2);
            newTab.AddChord(Guitar.GuitarChords.Major.D, 'D');
            newTab.AddRest(2);
            newTab.AddChord(Guitar.GuitarChords.Major.E, 'E');
            newTab.AddRest(2);
            newTab.AddChord(Guitar.GuitarChords.Minor.E, 'E');
            newTab.AddRest(2);
            newTab.AddChord(Guitar.GuitarChords.Minor.F, 'F');
            newTab.AddRest(2);
            newTab.AddNote(Guitar.Fretboard.AtPosition(3, 4));
            newTab.AddRest(2);
            newTab.AddNotes(new List<Guitar.GuitarNoteInfo>() { 
                Guitar.Fretboard.AtPosition(3, 4),
                Guitar.Fretboard.AtPosition(1, 6) 
            });
            newTab.AddRest(2);
            newTab.AddSpecialCharacter(new Tablature.SpecialCharacter() { character = 'B', stringPosition = 6 });
            newTab.AddSpecialCharacter(new Tablature.SpecialCharacter() { character = 'b', stringPosition = 1 });
            var tab = newTab.GetTab();
            Console.WriteLine(tab);
            while (true)
            {
                Console.Write("Root Note>");
                var note = Console.ReadKey();
                Console.WriteLine();
                Console.Write("Major or Minor?>");
                var majorOrMinor = Console.ReadLine().ToLower();
                var chords = Cork.Music.Chords.MajorChords;
                if(majorOrMinor == "minor"){
                    chords = Cork.Music.Chords.NaturalMinorChords;
                }
                var verse = Cork.Music.Chords.GetRandomProgression(note.KeyChar.ToString(), chords);
                var preChorus = Cork.Music.Chords.GetRandomProgression(note.KeyChar.ToString(), chords);
                var chorus = Cork.Music.Chords.GetRandomProgression(note.KeyChar.ToString(), chords);
                var bridge = Cork.Music.Chords.GetRandomProgression(note.KeyChar.ToString(), chords);
                Console.WriteLine();
                Console.WriteLine("Verse: " + string.Join(" ", verse.Select(a => a.name + a.chordType)));
                Console.WriteLine("Pre-Chorus: " + string.Join(" ", preChorus.Select(a => a.name + a.chordType)));
                Console.WriteLine("Chorus: " + string.Join(" ", chorus.Select(a => a.name + a.chordType)));
                Console.WriteLine("Bridge: " + string.Join(" ", bridge.Select(a => a.name + a.chordType)));
                Console.ReadKey();
            }
        }
    }
}
