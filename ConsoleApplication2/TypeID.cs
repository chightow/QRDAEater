﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TypeID
    {
        private string tag;
        public string Tag
        {
            get
            {
                return tag;
            }
        }

        private string root;
        public string Root
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }


        private string extension;
        public string Extension
        {
            get
            {
                return extension;
            }
            set
            {
                extension = value;
            }
        }

        public TypeID()
        {
            tag = "typeId";
        }
    }
}
