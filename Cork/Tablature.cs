using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cork
{
    public class Tablature
    {

        private List<string> _tab = new List<string>() {"", "", "", "", "", "", "" };
        public List<string> Tab
        {
            get { return _tab; }
            set { _tab = value; }
        }
        public void AddNotes(List<Guitar.GuitarNoteInfo> info, char? header = null)
        {
            Tab[0] += (header != null) ? header.ToString() : " ";

            for (var i = 1; i < Tab.Count; i++)
            {
                var item = info.Where(a => a.fretPosition == i).FirstOrDefault();
                Tab[i] += (item != null) ? item.fretPosition.ToString() : "-";
            }

        }
        public void AddNote(Guitar.GuitarNoteInfo info, char? header = null)
        {
            Tab[0] += (header != null) ? header.ToString() : " ";

            for (var i = 1; i < Tab.Count; i++)
            {
                Tab[i]+= (info.stringPosition != i) ? "-": info.fretPosition.ToString();
            }

        }
        public void AddChord(List<Guitar.GuitarNoteInfo> chord, char? header = null)
        {
            Tab[0] += (header != null) ? header.ToString() : " ";

            for (var i = 1; i < Tab.Count; i++)
            {
                Tab[i] += (chord[i-1] != null) ? chord[i-1].fretPosition.ToString() : "-";
            }
        }
        public void AddRest(int numberOfRests = 1, List<char?> headers = null)
        {
            for (var r = 0; r < numberOfRests; r++)
            {
                if (headers != null && headers.Count >= numberOfRests && headers[r] != null)
                {
                    Tab[0] += headers[r];
                }
                else
                {
                    Tab[0] += " ";
                }
                for (var i = 1; i < Tab.Count; i++)
                {
                    Tab[i] = Tab[i] + "-";
                }
            }
        }
        public void AddLine(string[] lines, char? header = null)
        {
            Tab[0] += (header != null) ? header.ToString() : " ";

            for (var i = 0; i < _tab.Count; i++)
            {
                _tab[i] = _tab[i] + lines[i];
            }
        }
        public class SpecialCharacter
        {
            public int stringPosition { get; set; }
            public char character { get; set; }
        }
        public void AddSpecialCharacters(List<SpecialCharacter> characters, char? header = null)
        {
            Tab[0] += (header != null) ? header.ToString() : " ";
            Dictionary<int, bool> stringsAdjusted = new Dictionary<int, bool>();
            for (var i = 1; i < 7; i++)
            {
                stringsAdjusted.Add(i, false);
            }
            characters.ForEach(a =>
            {
                stringsAdjusted[a.stringPosition] = true;
                Tab[a.stringPosition] += a.character;
            });
            stringsAdjusted.Where(a => a.Value == false).ToList().ForEach(a =>
            {
                Tab[a.Key] += "-";
            });
        }
        public void AddSpecialCharacter(SpecialCharacter character, char? header = null)
        {
            AddSpecialCharacters(new List<SpecialCharacter>() { character }, header);
        }
        public string GetTab(bool includeHeader = true)
        {
            var data = "";
            data += includeHeader ? "  " + Tab[0] + "  \r\n": "";
            data += "1e" + Tab[1] + "||\r\n";
            data += "2B" + Tab[2] + "||\r\n";
            data += "3G" + Tab[3] + "||\r\n";
            data += "4D" + Tab[4] + "||\r\n";
            data += "5A" + Tab[5] + "||\r\n";
            data += "6E" + Tab[6] + "||\r\n";
            return data;
        }
    }
}
