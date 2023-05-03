using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace layoutandsearchbar
{
    class AnimalModel
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public Group Category { get; set; }
        public enum Group { Land,Water,Air }

    }
}
