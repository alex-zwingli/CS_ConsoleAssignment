using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class inputCheck
    {
        public int team(string prompt)
        {
            do //DO UNTIL LOOP RETURNS A DESIRED VALUE
            {
                int min = 2, //YOU HAVE TO HAVE AT LEAST TWO TEAMS TO PLAY A GAME
                    max = 16; //THE OLYMPICS ONLY ALLOW 16 TEAMS IN TOURNAMENT

                string input = Console.ReadLine(); //GET INPUT
                try //HANDLE INVALID INPUTS
                {
                    if (Convert.ToInt16(input) < min) //IS INPUT UNWANTED?
                    {
                        clearInput(input, prompt); //GET RID OF UNWANTED INPUT
                        System.Windows.Forms.MessageBox.Show("Minimum number of team not met. \rPlease input " + min + " to " + max + " teams.");
                    }
                    else if (Convert.ToInt16(input) > max)
                    {
                        clearInput(input, prompt); //GET RID OF UNWANTED INPUT
                        System.Windows.Forms.MessageBox.Show("Maximum number of teams exceeded. \rPlease input " + min + " to " + max + " teams.");
                    }
                    else
                    {
                        return Convert.ToInt16(input); //RETURNS INT
                    }
                }
                catch (System.FormatException) //EXCECUTE IF USER DOES NOT INPUT INT
                {
                    clearInput(input, prompt);
                    System.Windows.Forms.MessageBox.Show("Invalid input type. \rPlease enter an integer between " + min + " and " + max + ".");
                }
                catch (System.OverflowException)
                {
                    clearInput(input, prompt);
                    System.Windows.Forms.MessageBox.Show("Maximum number of teams exceeded. \rPlease input " + min + " to " + max + " teams.");
                }
            } while (true);
        }

        public int point(string prompt)
        {
            do //DO UNTIL LOOP RETURNS A DESIRED VALUE
            {
                int min = 0,
                    max = 50;

                string input = Console.ReadLine(); //GET INPUT
                try //HANDLE INVALID INPUTS
                {
                    if (Convert.ToInt16(input) < min) //IS INPUT UNWANTED?
                    {
                        clearInput(input, prompt); //GET RID OF UNWANTED INPUT
                        System.Windows.Forms.MessageBox.Show("Minimum number of points not met. \rPlease input " + min + " to " + max + " points.");
                    }
                    else if (Convert.ToInt16(input) > max)
                    {
                        clearInput(input, prompt); //GET RID OF UNWANTED INPUT
                        System.Windows.Forms.MessageBox.Show("Maximum number of points exceeded. \rPlease input " + min + " to " + max + " points.");
                    }
                    else
                    {
                        return Convert.ToInt16(input); //RETURNS INT
                    }
                }
                catch (System.FormatException) //EXCECUTE IF USER DOES NOT INPUT INT
                {
                    clearInput(input, prompt);
                    System.Windows.Forms.MessageBox.Show("Invalid input type. \rPlease enter an integer between " + min + " and " + max + ".");
                }
                catch (System.OverflowException)
                {
                    clearInput(input, prompt);
                    System.Windows.Forms.MessageBox.Show("Maximum number of points exceeded. \rPlease input " + min + " to " + max + " points.");
                }
            } while (true);
        }

        public int id(string prompt, int capacity)
        {
            int min = 1,
                max = capacity;

            do //DO UNTIL LOOP RETURNS A DESIRED VALUE
            {

                string input = Console.ReadLine(); //GET INPUT
                try //HANDLE INVALID INPUTS
                {
                    if (Convert.ToInt16(input) < min) //IS INPUT UNWANTED?
                    {
                        clearInput(input, prompt); //GET RID OF UNWANTED INPUT
                        System.Windows.Forms.MessageBox.Show("ID out of range. \rPlease input ID between " + min + " and " + max + ".");
                    }
                    else if (Convert.ToInt16(input) > max)
                    {
                        clearInput(input, prompt); //GET RID OF UNWANTED INPUT
                        System.Windows.Forms.MessageBox.Show("ID out of range. \rPlease input ID between " + min + " and " + max + ".");
                    }
                    else
                    {
                        return Convert.ToInt16(input); //RETURNS INT
                    }
                }
                catch (System.FormatException) //EXCECUTE IF USER DOES NOT INPUT INT
                {
                    clearInput(input, prompt);
                    System.Windows.Forms.MessageBox.Show("Invalid input type. \rPlease input ID between " + min + " and " + max + ".");
                }
                catch (System.OverflowException)
                {
                    clearInput(input, prompt);
                    System.Windows.Forms.MessageBox.Show("ID out of range. \rPlease input ID between " + min + " and " + max + ".");
                }
            } while (true);


        }

        public int element(string prompt)
        {
            do //DO UNTIL LOOP RETURNS A DESIRED VALUE
            {
                int min = 1,
                    max = 2;

                string input = Console.ReadLine(); //GET INPUT
                try //HANDLE INVALID INPUTS
                {
                    if (Convert.ToInt16(input) < min) //IS INPUT UNWANTED?
                    {
                        clearInput(input, prompt); //GET RID OF UNWANTED INPUT
                        System.Windows.Forms.MessageBox.Show("Element out of range. \rPlease enter " + min + " or " + max + ".");
                    }
                    else if (Convert.ToInt16(input) > max)
                    {
                        clearInput(input, prompt); //GET RID OF UNWANTED INPUT
                        System.Windows.Forms.MessageBox.Show("Element out of range. \rPlease enter " + min + " or " + max + ".");
                    }
                    else
                    {
                        return Convert.ToInt16(input); //RETURNS INT
                    }
                }
                catch (System.FormatException) //EXCECUTE IF USER DOES NOT INPUT INT
                {
                    clearInput(input, prompt);
                    System.Windows.Forms.MessageBox.Show("Invalid input type. \rPlease enter " + min + " or " + max + ".");
                }
                catch (System.OverflowException)
                {
                    clearInput(input, prompt);
                    System.Windows.Forms.MessageBox.Show("Element out of range. \rPlease enter " + min + " or " + max + ".");
                }
            } while (true);
        }

        public string name(string prompt)
        {
            do //DO UNTIL LOOP RETURNS A DESIRED INPUT
            {
                string input = Console.ReadLine(); //GET INPUT

                if (input == null)
                {
                    System.Windows.Forms.MessageBox.Show("Blank submission."
                        + "\rPlease enter a team name.");
                    clearInput(input, prompt);
                }
                if (input == "")
                {
                    System.Windows.Forms.MessageBox.Show("Blank submission."
                        + "\rPlease enter a team name.");
                    clearInput(input, prompt);
                }
                else if (input.Length > 25)
                {
                    System.Windows.Forms.MessageBox.Show("Team name longer than 25 characters."
                        + "\rTeam name will not be fully displayed on ranking output.");
                    return input;
                }
                else
                {
                    return input;
                }


            } while (true);
        }

        public void terminate(string input, string prompt)
        {
            System.Windows.Forms.MessageBox.Show("Invalid response"
                + "\rPlease enter \"yes\" or \"no\" to proceed.");
            clearInput(input, prompt);
        }

        public void clearInput(string input, string prompt)
        {
            Console.CursorTop--; //MOVE CURSOR UP ONE
            for (int i = 0; i < prompt.Length; i++) //MOVE CURSOR TO END OF PROMPT
            {
                Console.CursorLeft++;
            }
            for (int i = 0; i < input.Length; i++) //CLEAR PREVIOUS INPUT
            {
                Console.Write(" ");
            }

            for (int i = 0; i < input.Length; i++) //RETURN CURSOR TO INPUT START
            {
                Console.CursorLeft--;
            }

        }

    }
}
