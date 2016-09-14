using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SoccerTeam : Team
    {
        //DECLARE VARIABLES
        public int iDraw { get; set; }
        public int iGoalsFor { get; set; }
        public int iGoalsAgainst { get; set; }
        public int iDifferential { get; set; }
        public int iPoints { get; set; }


        //CONSTRUCTOR(S)
        public SoccerTeam() { } //DEFAULT CONSTRUCTOR

        public SoccerTeam(String sName, int iPoints)
        {
            this.sName = sName;
            this.iPoints = iPoints;
        }

    }
}
