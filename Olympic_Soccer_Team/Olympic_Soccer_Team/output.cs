using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class output
    {

        public void greeting()
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine("****                                                      ****");
            Console.WriteLine("****                      WELCOME                         ****");
            Console.WriteLine("****                                                      ****");
            Console.WriteLine("****             OLYMPIC SOCCER TOURNAMENT                ****");
            Console.WriteLine("****                                                      ****");
            Console.WriteLine("****              PRESS 'ENTER' TO BEGIN                  ****");
            Console.WriteLine("****                                                      ****");
            Console.WriteLine("****                                                      ****");
            Console.WriteLine("**************************************************************");
        }

        public void end()
        {
            Console.WriteLine("\n\n**************************************************************");
            Console.WriteLine("****                                                      ****");
            Console.WriteLine("****                 END OF PROGRAM                       ****");
            Console.WriteLine("****                                                      ****");
            Console.WriteLine("****              PRESS 'ENTER' TO EXIT                   ****");
            Console.WriteLine("****                                                      ****");
            Console.WriteLine("**************************************************************");
        }

        public void input()
        {
            Console.WriteLine("\n\n****             SETUP TOURNAMENT TEAMS                   ****");
        }

        public void veirfy()
        {
            Console.WriteLine("\n\n****                 INPUT VERIFICATION                   ****\n");
        }

        public void ranking()
        {
            Console.WriteLine("\n\n****              FINAL TOURNAMENT RANKING                ****\n");
        }
    }
}
