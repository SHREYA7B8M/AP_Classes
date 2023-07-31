using System;
using System.Collections.Generic;
using System.Text;

namespace AP_Classes
{
    public class Subject
    {
        private string name;
        private string shortName;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ShortName
        {
            get { return shortName; }
            set { shortName = value; }
        }
    }
}
