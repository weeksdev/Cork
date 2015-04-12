using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cork
{
    public static class Guitar
    {
        public class GuitarChordInfo : Music.ChordInfo
        {
            public GuitarChordInfo(string chordType, string name, List<List<GuitarNoteInfo>> chordVariations)
            {
                this.chordType = chordType;
                this.name = name;
                this.chordVariations = chordVariations;
            }
            public List<List<GuitarNoteInfo>> chordVariations { get; set; }
            public List<GuitarNoteInfo> basicChord { get; set; }
        }
        public static class GuitarChords
        {

            public static List<GuitarNoteInfo> GetChord(string name, string chordType)
            {
                switch (chordType.ToLower())
                {
                    case "major":
                        return GetMajorChord(name);
                    case "minor":
                        return null;
                    case "diminished":
                        throw new NotImplementedException("the chord type you specified isn't implemented.");
                    default:
                        throw new NotImplementedException("the chord type you specified isn't implemented.");
                }
            }
            public static List<GuitarNoteInfo> GetMinorChord(string name)
            {
                switch (name.ToUpper())
                {
                    case "C":
                        return Minor.C;
                    case "C#":
                    case "D♭":
                        return Minor.CSharpDFlat;
                    case "D":
                        return Minor.D;
                    case "D#":
                    case "E♭":
                        return Minor.DSharpEFlat;
                    case "E":
                        return Minor.E;
                    case "F":
                        return Minor.F;
                    case "F#":
                    case "G♭":
                        return Minor.FSharpGFlat;
                    case "G":
                        return Minor.G;
                    case "G#":
                    case "A♭":
                        return Minor.GSharpAFlat;
                    case "A":
                        return Minor.A;
                    case "B":
                        return Minor.B;
                    default:
                        throw new NotImplementedException("the name you entered didn't correspond to anything.");
                }
            }
            public static List<GuitarNoteInfo> GetMajorChord(string name)
            {
                switch (name.ToUpper())
                {
                    case "C":
                        return Major.C;
                    case "C#":
                    case "D♭":
                        return Major.CSharpDFlat;
                    case "D":
                        return Major.D;
                    case "D#":
                    case "E♭":
                        return Major.DSharpEFlat;
                    case "E":
                        return Major.E;
                    case "F":
                        return Major.F;
                    case "F#":
                    case "G♭":
                        return Major.FSharpGFlat;
                    case "G":
                        return Major.G;
                    case "G#":
                    case "A♭":
                        return Major.GSharpAFlat;
                    case "A":
                        return Major.A;
                    case "B":
                        return Major.B;
                    default:
                        throw new NotImplementedException("the name you entered didn't correspond to anything.");
                }
            }
            public static class Minor
            {
                public static List<GuitarNoteInfo> C = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 3),
                    Fretboard.AtPosition(2, 4),
                    Fretboard.AtPosition(3, 5),
                    Fretboard.AtPosition(4, 5),
                    Fretboard.AtPosition(5, 3),
                    null
                };
                public static List<GuitarNoteInfo> CSharpDFlat = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 4),
                    Fretboard.AtPosition(2, 5),
                    Fretboard.AtPosition(3, 6),
                    Fretboard.AtPosition(4, 6),
                    Fretboard.AtPosition(5, 4),
                    null
                };
                public static List<GuitarNoteInfo> D = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 1),
                    Fretboard.AtPosition(2, 3),
                    Fretboard.AtPosition(3, 2),
                    Fretboard.AtPosition(4, 0),
                    null,
                    null
                };
                public static List<GuitarNoteInfo> DSharpEFlat = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 6),
                    Fretboard.AtPosition(2, 7),
                    Fretboard.AtPosition(3, 8),
                    Fretboard.AtPosition(4, 8),
                    Fretboard.AtPosition(5, 6),
                    null
                };
                public static List<GuitarNoteInfo> E = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 0),
                    Fretboard.AtPosition(2, 0),
                    Fretboard.AtPosition(3, 0),
                    Fretboard.AtPosition(4, 2),
                    Fretboard.AtPosition(5, 2),
                    Fretboard.AtPosition(6, 0)
                };
                public static List<GuitarNoteInfo> F = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 1),
                    Fretboard.AtPosition(2, 1),
                    Fretboard.AtPosition(3, 1),
                    Fretboard.AtPosition(4, 3),
                    Fretboard.AtPosition(5, 3),
                    Fretboard.AtPosition(6, 1)
                };
                public static List<GuitarNoteInfo> FSharpGFlat = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 2),
                    Fretboard.AtPosition(2, 2),
                    Fretboard.AtPosition(3, 2),
                    Fretboard.AtPosition(4, 4),
                    Fretboard.AtPosition(5, 4),
                    Fretboard.AtPosition(6, 2)
                };
                public static List<GuitarNoteInfo> G = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 3),
                    Fretboard.AtPosition(2, 3),
                    Fretboard.AtPosition(3, 3),
                    Fretboard.AtPosition(4, 5),
                    Fretboard.AtPosition(5, 5),
                    Fretboard.AtPosition(6, 3)
                };
                public static List<GuitarNoteInfo> GSharpAFlat = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 4),
                    Fretboard.AtPosition(2, 4),
                    Fretboard.AtPosition(3, 4),
                    Fretboard.AtPosition(4, 6),
                    Fretboard.AtPosition(5, 6),
                    Fretboard.AtPosition(6, 4)
                };
                public static List<GuitarNoteInfo> A = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 0),
                    Fretboard.AtPosition(2, 1),
                    Fretboard.AtPosition(3, 2),
                    Fretboard.AtPosition(4, 2),
                    Fretboard.AtPosition(5, 0),
                    null
                };
                public static List<GuitarNoteInfo> ASharpBFlat = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 1),
                    Fretboard.AtPosition(2, 2),
                    Fretboard.AtPosition(3, 3),
                    Fretboard.AtPosition(4, 3),
                    Fretboard.AtPosition(5, 1),
                    null
                };
                public static List<GuitarNoteInfo> B = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 2),
                    Fretboard.AtPosition(2, 3),
                    Fretboard.AtPosition(3, 4),
                    Fretboard.AtPosition(4, 4),
                    Fretboard.AtPosition(5, 2),
                    null
                };
            }
            public static class Major
            {
                public static List<GuitarNoteInfo> C = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 0),
                    Fretboard.AtPosition(2, 1),
                    Fretboard.AtPosition(3, 0),
                    Fretboard.AtPosition(4, 2),
                    Fretboard.AtPosition(5, 3),
                    null
                };
                public static List<GuitarNoteInfo> CSharpDFlat = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 4),
                    Fretboard.AtPosition(2, 6),
                    Fretboard.AtPosition(3, 6),
                    Fretboard.AtPosition(4, 6),
                    Fretboard.AtPosition(5, 4),
                    null
                };
                public static List<GuitarNoteInfo> D = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 2),
                    Fretboard.AtPosition(2, 3),
                    Fretboard.AtPosition(3, 2),
                    Fretboard.AtPosition(4, 0),
                    null,
                    null
                };
                public static List<GuitarNoteInfo> DSharpEFlat = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 6),
                    Fretboard.AtPosition(2, 8),
                    Fretboard.AtPosition(3, 8),
                    Fretboard.AtPosition(4, 8),
                    Fretboard.AtPosition(5, 6),
                    null
                };
                public static List<GuitarNoteInfo> E = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 0),
                    Fretboard.AtPosition(2, 0),
                    Fretboard.AtPosition(3, 1),
                    Fretboard.AtPosition(4, 2),
                    Fretboard.AtPosition(5, 2),
                    Fretboard.AtPosition(6, 0)
                };
                public static List<GuitarNoteInfo> F = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 1),
                    Fretboard.AtPosition(2, 1),
                    Fretboard.AtPosition(3, 2),
                    Fretboard.AtPosition(4, 3),
                    Fretboard.AtPosition(5, 3),
                    Fretboard.AtPosition(6, 1)
                };
                public static List<GuitarNoteInfo> FSharpGFlat = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 2),
                    Fretboard.AtPosition(2, 2),
                    Fretboard.AtPosition(3, 3),
                    Fretboard.AtPosition(4, 4),
                    Fretboard.AtPosition(5, 4),
                    Fretboard.AtPosition(6, 2)
                };
                public static List<GuitarNoteInfo> G = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 3),
                    Fretboard.AtPosition(2, 0),
                    Fretboard.AtPosition(3, 0),
                    Fretboard.AtPosition(4, 0),
                    Fretboard.AtPosition(5, 2),
                    Fretboard.AtPosition(6, 3)
                };
                public static List<GuitarNoteInfo> GSharpAFlat = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 4),
                    Fretboard.AtPosition(2, 4),
                    Fretboard.AtPosition(3, 5),
                    Fretboard.AtPosition(4, 6),
                    Fretboard.AtPosition(5, 6),
                    Fretboard.AtPosition(6, 4)
                };
                public static List<GuitarNoteInfo> A = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 0),
                    Fretboard.AtPosition(2, 2),
                    Fretboard.AtPosition(3, 2),
                    Fretboard.AtPosition(4, 2),
                    Fretboard.AtPosition(5, 0),
                    null
                };
                public static List<GuitarNoteInfo> ASharpBFlat = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 1),
                    Fretboard.AtPosition(2, 3),
                    Fretboard.AtPosition(3, 3),
                    Fretboard.AtPosition(4, 3),
                    Fretboard.AtPosition(5, 1),
                    null
                };
                public static List<GuitarNoteInfo> B = new List<GuitarNoteInfo>()
                {
                    Fretboard.AtPosition(1, 2),
                    Fretboard.AtPosition(2, 4),
                    Fretboard.AtPosition(3, 4),
                    Fretboard.AtPosition(4, 4),
                    Fretboard.AtPosition(5, 2),
                    null
                };
            }
            
        }
        public class GuitarNoteInfo: Music.NoteInfo
        {
            public GuitarNoteInfo(int fretPosition, int stringPosition, string name, string alternateName)
            {
                this.alternateName = alternateName;
                this.fretPosition = fretPosition;
                this.stringPosition = stringPosition;
                this.name = name;
            }
            public int stringPosition { get; set; }
            public int fretPosition { get; set; }
        }
        public static List<GuitarNoteInfo> Strings = new List<GuitarNoteInfo>(){
            new GuitarNoteInfo(0, 1, "E", "High E"),
            new GuitarNoteInfo(0, 2, "B", "B"),
            new GuitarNoteInfo(0, 3, "G", "G"),
            new GuitarNoteInfo(0, 4, "D", "D"),
            new GuitarNoteInfo(0, 5, "A", "A"),
            new GuitarNoteInfo(0, 6, "E", "Low E")
        };
        
        public static class Fretboard
        {
            public static GuitarNoteInfo AtPosition(int stringPosition, int fretPosition)
            {
                var currentString = Strings.Where(a=>a.stringPosition == stringPosition).FirstOrDefault();
                var currentFretPosition = currentString;
                for (var i = 0; i < fretPosition; i++)
                {
                    var currentNote = Music.Notes.Where(a=>a.name == currentFretPosition.name).FirstOrDefault();
                    var nextNote = Music.Notes.Where(a=>a.place == currentNote.place + 1).FirstOrDefault();
                    if(nextNote.name == currentNote.name){
                        nextNote = Music.Notes.Where(a=>a.place == currentNote.place + 2).FirstOrDefault();
                    }
                    currentFretPosition = new GuitarNoteInfo(fretPosition, stringPosition, nextNote.name, nextNote.alternateName); 
                }
                return currentFretPosition;
            }
        }
    }
}
