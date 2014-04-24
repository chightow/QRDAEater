using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class QRDADocumentType
    {
        private string code;
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        private string tag;
        public string Tag
        {
            get
            {
                return tag;
            }
        }

        public QRDADocumentType()
        {
            tag = "code";
        }

        private string codeSystem;
        public string CodeSystem
        {
            get
            {
                return codeSystem;
            }
            set
            {
                codeSystem = value;
            }
        }

        private string codeSystemName;
        public string CodeSystemName
        {
            get
            {
                return codeSystemName;
            }
            set
            {
                codeSystemName = value;
            }
        }

        private string displayName;
        public string DisplayName
        {
            get
            {
                return displayName;
            }
            set
            {
                displayName = value;
            }
        }

    }
}
