using System;
using System.Diagnostics;

namespace Mountains_And_Valleys
{
    class Program
    {
        static string userInput = "";

        static int[] hikeData = new int[] { 0, 0, 0 };

        //Element one: finishedHeight() ~ Element two: countValleys() ~ Element three: # of steps taken

        static void Main(string[] args)
        {
            takeUserInput();

            startHike(userInput);

            //METHODS
            
            static string takeUserInput()
            {
                Console.WriteLine("Enter your path!\nU = One step down.\nD = One step up.\nF = One " +
                "step forward.");

                userInput = Console.ReadLine();
                
                userInput = userInput.ToUpper();

                for (int i = 0; i < userInput.Length; i++)
                {
                    if (userInput[i] != 'U' && userInput[i] != 'D' && userInput[i] != 'F')
                    {
                        Console.WriteLine("You may only enter U, D, or F!");
                        
                        takeUserInput();
                    }
                    else
                    {
                        continue;
                    }
                }

                return userInput;
            } 

            void startHike(string userInput)
            {
                countFinishedHeight(userInput);

                countValleys(userInput);

                countSteps(userInput);

                writeHikeData(hikeData);
            }

            static void countFinishedHeight(string userInput)
            {
                for (int i = 0; i < userInput.Length; i++)
                {
                    if (userInput[i] == 'U')
                    {
                        hikeData[0]++;
                    }
                    else if (userInput[i] == 'D')
                    {
                        hikeData[0]--;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            static void countValleys(string userInput)
            {
                for (int i = 0; i < userInput.Length - 1; i++)
                {
                    if (userInput[i] == 'U' && userInput[i + 1] == 'D') //UFD COMBO NOT WORKING
                    {
                        hikeData[1]++;
                    }
                }
            }

            static void countSteps(string userInput)
            {
                foreach (char uOrD in userInput)
                {
                    hikeData[2]++;
                }
            }

            static void writeHikeData(int[] hikeData)
            {
                string[] responses = new string[] {"Your finished height is: ", "The number of " +
                    "valleys you walked: ", "Your total number of steps: "};

                for (int i = 0; i < hikeData.Length; i++)
                {
                    Console.Write(responses[i]);
                    Console.WriteLine(hikeData[i]);
                }
            }
        }
    }
}
