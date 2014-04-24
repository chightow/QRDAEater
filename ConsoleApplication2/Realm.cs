using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class RealmCode
    {
        private string tag;
        public string Tag
        {
            get
            {
                return tag;
            }
            
        }
        
        private string code;
        public string Data
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

        public RealmCode()
        {
            tag = "realmCode";
        }
        
        
        
    }
}
