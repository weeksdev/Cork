using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cork;

namespace UnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void MajorScale()
        {
            List<string> scale = Cork.Music.GetScale("C", Music.Scales.Major).Select(a => a.name).ToList();
            var control = new List<string>(){
                "C","D","E","F","G","A","B","C"
            };

            Assert.AreEqual(scale, control);
        }
        [TestMethod]
        public void MajorPentatonicScale()
        {
            var scale = string.Join(" ", Cork.Music.GetScale("C", Music.Scales.MajorPentatonic).Select(a => a.name));
            Assert.AreEqual("C D E G A C", scale);
        }
        [TestMethod]
        public void MinorPentatonicScale()
        {
            var scale = string.Join(" ", Cork.Music.GetScale("C", Music.Scales.MinorPentatonic).Select(a => a.alternateName));
            Assert.AreEqual("C E♭ F G B♭", scale);
            scale = string.Join(" ", Cork.Music.GetScale("A", Music.Scales.MinorPentatonic).Select(a => a.alternateName));
            Assert.AreEqual("A C D E G", scale);
        }
        [TestMethod]
        public void BluesScales()
        {
            var scale = string.Join(" ", Cork.Music.GetScale("C", Music.Scales.MinorPentatonicBlues).Select(a => a.name));
            Assert.AreEqual("C D# F F# G A# C", scale);
            scale = string.Join(" ", Cork.Music.GetScale("C", Music.Scales.MajorPentatonicBlues).Select(a => a.name));
            Assert.AreEqual("C D D# E G A C", scale);
        }
        [TestMethod]
        public void GetGuitarNote()
        {
            var note = Guitar.Fretboard.AtPosition(6, 7);
            var control = "B";
            Assert.AreEqual(control, note.name);
        }
        [TestMethod]
        public void GetProgression()
        {
            var progression = Music.Chords.GetProgression("C", Music.Chords.MajorChords, Music.PopularProgressions[0]);
            var result = string.Join(" ", progression.Select(a => a.name + a.chordType));
            var control = "CMajor GMajor AMinor FMajor";
            Assert.AreEqual(result, control);
        }
        [TestMethod]
        public void TablatureTest()
        {
            Tablature newTab = new Tablature();
            newTab.AddRest(2);
            newTab.AddChord(Guitar.GuitarChords.Major.D);
            newTab.AddRest(2);
            newTab.AddChord(Guitar.GuitarChords.Minor.E);
            var tab = newTab.GetTab();
        }

    }
}
