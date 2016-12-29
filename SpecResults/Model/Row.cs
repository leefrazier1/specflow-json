using System.Collections.Generic;

namespace SpecResults.Model
{
    public class Row
    {
        public static readonly int LineFiller = 0;

        public List<string> Cells { get; set; }

        public int Line => LineFiller;  
    }
}