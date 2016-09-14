/*
 * AUTHOR:      Alex Zwingli
 * TEAM:        Core JAMB (1-5)
 * LAST UPDATE: 9/13/2016
 * 
 * PROGRAM:     Olympic Soccer Tournament
 * 
 * DESCRIPTION: Prompts the user to enter in the number of teams  competing in an olympic soccer tournament.
 *              Then for the number of teams entered, prompts the user to enter the name of the team and
 *              the number of points the team has scored. Finally, displays the results of the tournament.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; //ADD THIS TO USE AUTOMATIC WORD CAPITALIZER

namespace ConsoleApplication2
{


    class Program
    {
        static string UppercaseFirst(string s)
        {
            //CHECK FOR EMPTY STRING
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            //RETURN CHAR AND CONCAT SUBSTRING
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        //this is a test note

        static void Main(string[] args)
        {
            //DECLARE VARIABLES
            int iTeamCount,
                iPoints,
                iPosition,
                iID,
                iField;
            string sName;
            Boolean bExit = false,
                valid = false,
                accurate = false;

            //INSTANTIATE OBJECTS
            inputCheck check = new inputCheck();
            output display = new output();
            List<SoccerTeam> teams = new List<SoccerTeam>();

            do
            {
                display.greeting();
                check.clearInput(Console.ReadLine(), "");

                #region SEASON SETUP

                //PROMPT FOR NUMBER OF TEAMS
                display.input();
                string prompt1 = "How many soccer teams are participating in the tournament? ";
                Console.Write("\n" + prompt1);
                iTeamCount = check.team(prompt1);

                //PROMPT FOR TEAM INFO
                for (int i = 1; i <= iTeamCount; i++)
                {
                    string prompt2 = "Enter Team " + i + "'s name: ";
                    Console.Write("\n\n" + prompt2);
                    sName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(check.name(prompt2)); //CAPITALIZE TEAM NAMES

                    string prompt3 = "Enter " + sName + "'s points: ";
                    Console.Write("\n" + prompt3);
                    iPoints = check.point(prompt3);

                    //CREATE OBJECT USING USER INPUT
                    teams.Add(new SoccerTeam(sName, iPoints));

                }

                #endregion //PROMPT FOR NUMBER OF TEAMS

                #region INPUT VERIFICATION
                display.veirfy();
                Console.WriteLine(Convert.ToString("   ID").PadRight(17, ' ')
                    + Convert.ToString("Team Name").PadRight(25, ' ')
                    + Convert.ToString("Score").PadRight(25, ' '));
                Console.WriteLine(Convert.ToString("--------").PadRight(17, ' ')
                    + Convert.ToString("-----------------------").PadRight(25, ' ')
                    + Convert.ToString("-----").PadRight(25, ' '));

                iPosition = 1;

                foreach (var selectTeam in teams)
                {
                    try
                    {
                        Console.WriteLine("   "
                            + Convert.ToString(iPosition).PadRight(14, ' ')
                            + Convert.ToString(selectTeam.sName.Substring(0, 23).PadRight(26, ' '))
                            + Convert.ToString(selectTeam.iPoints).PadRight(25, ' '));
                        iPosition++;
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("   "
                            + Convert.ToString(iPosition).PadRight(14, ' ')
                            + Convert.ToString(selectTeam.sName.PadRight(26, ' '))
                            + Convert.ToString(selectTeam.iPoints).PadRight(25, ' '));
                        iPosition++;
                    }
                }


                do
                {
                    string confirmPrompt = "Is the listed information correct? ";
                    Console.Write("\n" + confirmPrompt);
                    valid = false;

                    do
                    {
                        string response = Console.ReadLine();
                        if (response.Equals("yes", StringComparison.InvariantCultureIgnoreCase) || response.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                        {
                            valid = true;
                            accurate = true;
                        }
                        else if (response.Equals("no", StringComparison.InvariantCultureIgnoreCase) || response.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                        {
                            valid = true;
                            accurate = false;
                        }
                        else
                        {
                            check.terminate(response, confirmPrompt);
                            //System.Windows.Forms.MessageBox.Show("Invalid response.\rPlease enter \"yes\" or \"no\".");
                        }
                    } while (!valid);

                    


                    if (!accurate)
                    {
                        string selectPrompt = "Please enter the ID associated with the team you'd like to edit: ";
                        Console.Write("\n" + selectPrompt);
                        iID = check.id(selectPrompt, iPosition - 1);

                        string togglePrompt = "Would you like to modify Team Name (1) or Points (2)? ";
                        Console.Write("\n" + togglePrompt);
                        iField = check.element(togglePrompt);

                        if (iField == 1)
                        {
                            string prompt4 = "Enter Team " + iID + "'s name: ";
                            Console.Write("\n" + prompt4);
                            teams[iID - 1].sName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(check.name(prompt4)); //CAPITALIZE TEAM NAMES

                        }
                        else
                        {
                            string prompt5 = "Enter " + teams[iField - 1].sName + "'s points: ";
                            Console.Write("\n" + prompt5);
                            teams[iID - 1].iPoints = check.point(prompt5); //CAPITALIZE TEAM NAMES
                        }

                        Console.WriteLine(Convert.ToString("\n   ID").PadRight(18, ' ')
                            + Convert.ToString("Team Name").PadRight(25, ' ')
                            + Convert.ToString("Score").PadRight(25, ' '));
                        Console.WriteLine(Convert.ToString("--------").PadRight(17, ' ')
                            + Convert.ToString("-----------------------").PadRight(25, ' ')
                            + Convert.ToString("-----").PadRight(25, ' '));

                        iPosition = 1;

                        foreach (var selectTeam in teams)
                        {
                            try
                            {
                                Console.WriteLine("   "
                                    + Convert.ToString(iPosition).PadRight(14, ' ')
                                    + Convert.ToString(selectTeam.sName.Substring(0, 23).PadRight(26, ' '))
                                    + Convert.ToString(selectTeam.iPoints).PadRight(25, ' '));
                                iPosition++;
                            }
                            catch (System.ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("   "
                                    + Convert.ToString(iPosition).PadRight(14, ' ')
                                    + Convert.ToString(selectTeam.sName.PadRight(26, ' '))
                                    + Convert.ToString(selectTeam.iPoints).PadRight(25, ' '));
                                iPosition++;
                            }
                        }


                    }

                } while (!accurate);


                #endregion //INPUT VERIFICATION

                #region SEASON OUTPUT
                display.ranking();
                Console.WriteLine(Convert.ToString("Position").PadRight(17, ' ')
                    + Convert.ToString("Team Name").PadRight(27, ' ')
                    + Convert.ToString("Score").PadRight(25, ' '));
                Console.WriteLine(Convert.ToString("--------").PadRight(17, ' ')
                    + Convert.ToString("-----------------------").PadRight(25, ' ')
                    + Convert.ToString("-----").PadRight(25, ' '));

                //SORT AND DISPLAY TEAMS
                List<SoccerTeam> sortedTeams = teams.OrderByDescending(team => team.iPoints).ToList();

                iPosition = 1; //RESET TO 1

                foreach (var selectTeam in sortedTeams)
                {
                    try
                    {
                        Console.WriteLine("   "
                            + Convert.ToString(iPosition).PadRight(14, ' ')
                            + Convert.ToString(selectTeam.sName.Substring(0, 25).PadRight(26, ' '))
                            + Convert.ToString(selectTeam.iPoints).PadRight(25, ' '));
                        iPosition++;
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("   "
                            + Convert.ToString(iPosition).PadRight(14, ' ')
                            + Convert.ToString(selectTeam.sName.PadRight(26, ' '))
                            + Convert.ToString(selectTeam.iPoints).PadRight(25, ' '));
                        iPosition++;
                    }

                }

                Console.WriteLine("\n\n****                  END OF TOURNAMENT                   ****\n");
                #endregion //SEASON OUTPUT

                #region TERMINATION/RESTART
                string finalPrompt = "Would you like to manage another tournament? (yes/no) ";
                Console.Write(finalPrompt);

                do
                {
                    string response = Console.ReadLine();
                    if (response.Equals("yes", StringComparison.InvariantCultureIgnoreCase) || response.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                    {
                        //EXIT REMAINS FALSE
                        Console.Clear();
                        teams.Clear();
                        valid = true;
                    }
                    else if (response.Equals("no", StringComparison.InvariantCultureIgnoreCase) || response.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                    {
                        valid = true;
                        bExit = true;
                    }
                    else
                    {
                        check.terminate(response, finalPrompt);
                    }
                } while (!valid);
                #endregion

            } while (!bExit); //LOOPS UNTIL USER DECIDES TO EXIT PROGRAM

            //DISPLAY END MESSAGE AND EXIT
            display.end();
            check.clearInput(Console.ReadLine(), "");

        }
    }
}
