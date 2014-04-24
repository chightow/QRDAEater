using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class DocumentCreationTime
    {
        private string tag;
        public string Tag
        {
            get
            {
                return tag;
            }
            
        }

        public DocumentCreationTime()
        {
            tag = "value";
        }
        private string time;
        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
    }
}
