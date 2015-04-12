# Cork
>Cork, a song writing/music library and tablature creator
>A class library and test suite for basic music information and tablature.

###Includes the following:

1. Music
  1. all notes
  2. popular scales
  3. chords
  4. popular progressions
  5. methods to interact with the music data
2. Guitar
  1. popular guitar chords
  2. fretboard information for eventual display in a visual format
3. Tablature
  1. class library to create guitar tablature simply and intuitively
  2. ability to add chords, note(s), special characters, or rests to a specific line
  3. header attribute for placing chord/note names above the tab for easy reference when playing
  4. the tablature is extracted in string format and could be displayed directly in a web app/ or saved to a file
  
###*What's coming*

1. ability to import a string/file of a tablature and extract key information
2. suggestion engine for chord progressions and licks that will go well with a set of chords or notes
3. i'm going to be using these classes to create a web based guitar song writing toolkit.  It will include:
  1. suggestions for chord progressions and licks (displayed as tablature)
  2. a way to generate tablature on the fly
  3. ability to upload tablature for analysis
  4. a way to tie lyrics to chord progressions / tabs
4. Lyric class to add lyrics and analyze structure, etc. 

###How to use the tablature engine
Using the tablature class object is pretty simple here is a basic example:
```
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
```
Which outputs the following tab:
```
    C  D  E  E  F
1e--0--2--0--0--1---------b||
2B--1--3--0--0--1----------||
3G--0--2--1--0--1--4-------||
4D--2--0--2--2--3-----4----||
5A--3-----2--2--3----------||
6E--------0--0--1-----6--B-||
```
Use the method `AddSpecialCharater(s)` to add hammer-ons, pull-offs etc.  Eventually I'll probably add an enum with the standard options to make that a little easier.

###Using the random progression generator
To use the random progression generator there are a couple steps
1. obtain a root note
2. obtain whether the progression should be major or minor
Here is a code example for a console application:
```
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
```
###The Guitar Class
The guitar class is composed of the following pieces:

1. `GuitarChordInfo`
  1. a collection of `GuitarNoteInfo` that is composed of 6 items (each string).  Please use `null` for a string that isn't played.
  2. Example:
  
  ```
  public static List<GuitarNoteInfo> D = new List<GuitarNoteInfo>()
  {
    Fretboard.AtPosition(1, 2),
    Fretboard.AtPosition(2, 3),
    Fretboard.AtPosition(3, 2),
    Fretboard.AtPosition(4, 0),
    null,
    null
  };
  ```
  
2. `GuitarChords`
3. `GuitarNoteInfo`
  1. note information for a guitar at a specific string and fret position, `inherits` from `NoteInfo` 
4. `Fretboard`
  1. contains method `AtPosition` to obtain `GuitarNoteInfo` for a specific position
  2. the default guitar tuning is EADGBE however, this can be ammended by adjusting the `Strings` class.  However, this will have no impact on the chords they would continue to be EADGBE.  You would need to ammend the Major/Minor chords too if you want to use those chords or simply generate your own chords that you are going to use.
