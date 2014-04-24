using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class QRDAGuid
    {
        private string tag;
        public string Tag
        {
            get
            {
                return tag;
            }
        }
        public QRDAGuid()
        {
            tag = "id";
        }

        private string data;
        public string Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
    }
}
