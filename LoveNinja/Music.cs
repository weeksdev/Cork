using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveNinja
{
    public static class Music
    {
        public class NoteInfo
        {
            public NoteInfo()
            {

            }
            public NoteInfo(int place, string name, string alternateName){
                this.place = place;
                this.name = name;
                this.alternateName = alternateName;
            }
            public int place { get; set; }
            public string name { get; set; }
            public string alternateName { get; set; }
        }
        
        public static List<NoteInfo> Notes = new List<NoteInfo>(){
            new NoteInfo(1,"C","C"),
            new NoteInfo(2,"C#","D♭"),
            new NoteInfo(3,"D","D"),
            new NoteInfo(4,"D#","E♭"),
            new NoteInfo(5,"E","E"),
            new NoteInfo(6,"F","F"),
            new NoteInfo(7, "F#","G♭"),
            new NoteInfo(8, "G","G"),
            new NoteInfo(9, "G#","A♭"),
            new NoteInfo(10, "A","A"),
            new NoteInfo(11, "A#","B♭"),
            new NoteInfo(12, "B","B"),
            new NoteInfo(13, "C","C")
        };
        public static List<NoteInfo> GetNotes(NoteInfo root, int[] steps)
        {
            List<NoteInfo> notes = new List<NoteInfo>();
            notes.Add(root);
            var nextNote = root;
            foreach (var step in steps)
            {
                for (var i = 0; i < step; i++)
                {
                    if (nextNote.place == 13)
                    {
                        nextNote = Notes[1];
                    }
                    else
                    {
                        nextNote = Notes.Where(a => a.place == nextNote.place + 1).FirstOrDefault();
                    }
                }
                    
                notes.Add(nextNote);
            }
            return notes;
        }
        public class Scales
        {
            private Scales(int[] value) { Value = value; }
            public int[] Value { get; set; }
//            Major Scale: R, W, W, H, W, W, W, H
            //Natural Minor Scale: R, W, H, W, W, H, W, W
            //Harmonic Minor Scale: R, W, H, W, W, H, 1 1/2, H   (notice the step and a half)
            //Melodic Minor Scale: going up is: R, W, H, W, W, W, W, H
            //going down is: R, W, W, H, W, W, H, W
            //Dorian Mode is: R, W, H, W, W, W, H, W
            //Mixolydian Mode is: R, W, W, H, W, W, H, W
            //Ahava Raba Mode is: R, H, 1 1/2, H, W, H, W, W
            //A minor pentatonic blues scale (no sharped 5) is: R, 1 1/2, W, W, 1 1/2, W
            public static Scales 
                Major { get { return new Scales(new int[] { 2, 2, 1, 2, 2, 2, 1 }); } }
            public static Scales 
                NaturalMinor { get { return new Scales(new int[] { 2, 1, 2, 2, 1, 2, 2 }); } }
            public static Scales
                HarmonicMinor { get { return new Scales(new int[] { 2, 1, 2, 2, 1, 3, 2 }); } }
            public static Scales
                MelodicMinor { get { return new Scales(new int[] { 2, 1, 2, 2, 2, 2, 1 }); } }
            public static Scales
                DorianMode { get { return new Scales(new int[] { 2, 1, 2, 2, 2, 1, 2 }); } }
            public static Scales
                MixolydianModel { get { return new Scales(new int[] { 2, 2, 1, 2, 2, 1, 2 }); } }
            public static Scales
                PentatonicBlues { get { return new Scales(new int[] { 3, 2, 1, 1, 3, 2 }); } }
        }
        public static List<NoteInfo> GetScale(string root, Scales scale)
        {
            return GetScale(Notes.Where(a => a.name == root.ToUpper() || a.alternateName == root.ToUpper()).FirstOrDefault(), scale);
        }
        public static List<NoteInfo> GetScale(NoteInfo root, Scales scale)
        {
            return GetNotes(root, scale.Value);
        }
        
        public class ChordInfo
        {
            public string name { get; set; }
            public string chordType { get; set; }
            public static NoteInfo[] notes { get; set; }
        }
        public static class Chords
        {
            public static List<ChordInfo> GetChords(string note, List<ChordInfo> chords)
            {
                note = note.ToUpper();
                var scale = LoveNinja.Music.GetScale(note, Scales.Major);
                for (var i = 0; i < 7; i++)
                {
                    chords[i].name = scale[i].name;
                }
                return chords;
            }
            
            public static List<ChordInfo> MajorChords = new List<ChordInfo>(){
                new ChordInfo(){ chordType = "Major"},
                new ChordInfo(){ chordType = "Minor"},
                new ChordInfo(){ chordType = "Minor"},
                new ChordInfo(){ chordType = "Major"},
                new ChordInfo(){ chordType = "Major"},
                new ChordInfo(){ chordType = "Minor"},
                new ChordInfo(){ chordType = "Diminished"}
            };
            public static List<ChordInfo> NaturalMinorChords = new List<ChordInfo>(){
                new ChordInfo(){ chordType = "Minor"},
                new ChordInfo(){ chordType = "Diminished"},
                new ChordInfo(){ chordType = "Major"},
                new ChordInfo(){ chordType = "Minor"},
                new ChordInfo(){ chordType = "Minor"},
                new ChordInfo(){ chordType = "Major"},
                new ChordInfo(){ chordType = "Major"}
            };
        }
    }
}
