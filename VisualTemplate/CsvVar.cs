﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualTemplate
{
    class CsvVar
    {
        public string Name { get; set; }
        public string Path{ get; set;}
        public char Separator { get; set; }

        [JsonIgnore]
        public Encoding Encoding  { get; set; } // .UTF8

        public string encodingStr
        {
            get
            {
                if (Encoding == Encoding.Default)
                {
                    return "Default";
                }
                if (Encoding == Encoding.ASCII)
                {
                    return "ASCII";

                }
                if (Encoding == Encoding.UTF8)
                {
                    return "UTF8";
                }


                return null;
            }
            set
            {
                switch (value)
                {
                    case "Default":
                        Encoding = Encoding.Default;
                        break;
                    case "ASCII":
                        Encoding = Encoding.ASCII;
                        break;
                    case "UTF8":
                        Encoding = Encoding.UTF8;
                        break;
                }
            }
        }
        public CsvVar(string path)
        {
            Encoding = Encoding.Default;
            Path = path;
        }
    }
}
