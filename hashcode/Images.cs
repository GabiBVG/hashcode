using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashcode
{
    class Images
    {
        public List<string> tags { get; set; }
        public string orientation { get; set; }

        public Images( string o)
        {
            orientation = o;
            this.tags = new List<string>();
        }
        public void AddTag(string tag)
        {
            tags.Add(tag);
        }
        public Images this[int index]
        {
            get { return this; }
        }
    }
}
