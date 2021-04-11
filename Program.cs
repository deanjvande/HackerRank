using System;

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

            userInput = userInput.ToUpper();

            startHike(userInput);

            //METHODS

            static string takeUserInput()
            {
                Console.WriteLine("Enter your path!\nU = One step down.\nD = One step up.\nF = One " +
                "step forward.");

                userInput = Console.ReadLine();

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
                    else
                    {
                        hikeData[0]--;
                    }
                }
            }

            static void countValleys(string userInput)
            {
                for (int i = 0; i < userInput.Length; i++)
                {
                    if (userInput[i] == 'U' && userInput[i + 1] == 'D')
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
                string[] responses = new string[] {"Your finished height is: ", "The number of" +
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