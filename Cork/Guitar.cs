using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cork
{
    /// <summary>
    /// Class containing guitar specific objects, including fretboard information and guitar chord information.
    /// </summary>
    public static class Guitar
    {
        /// <summary>
        /// A class inherited from Music.ChordInfo that can be used to create a specific chord type with the chord variations that can be played on guitar
        /// </summary>
        public class GuitarChordInfo : Music.ChordInfo
        {
            /// <summary>
            /// Constructor for the guitar chord info
            /// </summary>
            /// <param name="chordType">The type of chord (major/minor/etc)</param>
            /// <param name="name">the name of the note the chord is for, for instance, an AMajor chord would be "A"</param>
            /// <param name="chordVariations">a list of variations of the chord as played on guitar</param>
            public GuitarChordInfo(string chordType, string name, List<List<GuitarNoteInfo>> chordVariations)
            {
                this.chordType = chordType;
                this.name = name;
                this.chordVariations = chordVariations;
            }
            /// <summary>
            /// the variations of chord phrasings for guitar
            /// </summary>
            public List<List<GuitarNoteInfo>> chordVariations { get; set; }
            /// <summary>
            /// the basic open chord position
            /// </summary>
            public List<GuitarNoteInfo> basicChord { get; set; }
        }
        public static class GuitarChords
        {
            /// <summary>
            /// obtain a chord phrasing based on the note (c, etc.) and chord type (major, etc.)
            /// </summary>
            /// <param name="name">note the chord corresponds to</param>
            /// <param name="chordType">the type of chord to obtain (major, minor, etc.)</param>
            /// <returns>collection of guitar notes that together, make up the chord phrasing</returns>
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
            /// <summary>
            /// obtain a chord phrasing for natural minor key
            /// </summary>
            /// <param name="name">note the chord corresponds to</param>
            /// <returns>collection of guitar notes that together, make up the chord phrasing</returns
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
            /// <summary>
            /// obtain a chord phrasing for major key
            /// </summary>
            /// <param name="name">note the chord corresponds to</param>
            /// <returns>collection of guitar notes that together, make up the chord phrasing</returns
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
            /// <summary>
            /// basic minor chords
            /// </summary>
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
            /// <summary>
            /// basic major chords
            /// </summary>
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
        /// <summary>
        /// note information for a specific guitar fret/string position (based in standard tuning EADGBE, unless altered)
        /// </summary>
        public class GuitarNoteInfo: Music.NoteInfo
        {
            /// <summary>
            /// constructor to create a guitar note info
            /// </summary>
            /// <param name="fretPosition">the fret the note corresponds to</param>
            /// <param name="stringPosition">the string position the note corresponds to</param>
            /// <param name="name">the name of the note (sharp name)</param>
            /// <param name="alternateName">the alternate name of the note (flat name)</param>
            public GuitarNoteInfo(int fretPosition, int stringPosition, string name, string alternateName)
            {
                this.alternateName = alternateName;
                this.fretPosition = fretPosition;
                this.stringPosition = stringPosition;
                this.name = name;
            }
            /// <summary>
            /// string position
            /// </summary>
            public int stringPosition { get; set; }
            /// <summary>
            /// fret position
            /// </summary>
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
