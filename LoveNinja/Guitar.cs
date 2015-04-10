using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveNinja
{
    public static class Guitar
    {
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
