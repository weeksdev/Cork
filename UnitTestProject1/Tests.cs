using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void MajorScale()
        {
            List<string> scale = LoveNinja.Music.GetScale("C", LoveNinja.Music.Scales.Major).Select(a => a.name).ToList();
            var control = new List<string>(){
                "C","D","E","F","G","A","B","C"
            };

            Assert.AreEqual(scale, control);
        }
        [TestMethod]
        public void GetGuitarNote()
        {
            var note = LoveNinja.Guitar.Fretboard.AtPosition(6, 7);
            Console.WriteLine(note.name);
        }
    }
}
