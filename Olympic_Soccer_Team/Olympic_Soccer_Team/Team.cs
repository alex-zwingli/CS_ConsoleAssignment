using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Team //PARENT CLASS
    {
        //DECLARE VARIABLES
        public string sName { get; set; }
        public int iWins { get; set; }
        public int iLosses { get; set; }

        //CONSTRUCTOR(S)
        public Team() { } //DEFAULT CONSTRUCTOR

        public Team(string sName)
        {
            this.sName = sName;
        }
    }
}
