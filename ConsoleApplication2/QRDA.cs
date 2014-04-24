using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class QRDA
    {
        private QRDAHeader header = new QRDAHeader();
        public QRDAHeader Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
            }
        }
    }
}
