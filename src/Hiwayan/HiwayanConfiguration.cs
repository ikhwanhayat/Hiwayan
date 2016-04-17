using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hiwayan
{
    public class HiwayanConfiguration
    {
        public string Player { get; set; }
        public List<Media> MediaList { get; set; }
    }

    public class Media
    {
        public string Path { get; set; }
        public string Thumbnail { get; set; }
    }
}
