using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ConfidentialityCode
    {
        public ConfidentialityCode()
        {
            tag = "confidentialityCode";
        }
        private string tag;
        public string Tag
        {
            get
            {
                return tag;
            }
        }

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
    }
}
