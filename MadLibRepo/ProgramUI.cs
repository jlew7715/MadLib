using System.Speech.AudioFormat;

namespace MadLibRepo
{
    public enum MadLib
    {
        DriversEd,
        LordRings,
        Walmart
    }
    public class ProgramUI
    {
        public void run()
        {
            Console.WriteLine("BBUUUURRRRPPP!!! Press any key even Jerry could do it!");
            PauseAndWaitForKeypress();
            MadLib c = (MadLib)new Random().Next(0, 3);
            switch (c)
            {
                case MadLib.DriversEd:
                    DriversEd();
                    break;
                case MadLib.LordRings:
                    // LordRings();
                    break;
                case MadLib.Walmart:
                    // Walmart();
                    break;
                default:
                    break;
            }
        }
        private void DriversEd()
        {
            Console.WriteLine("Well, now you are stuck with that choice, lets begin");
            PauseAndWaitForKeypress();


        }
        private void PauseAndWaitForKeypress()
        {
            Console.WriteLine("Just waiting for you to press something...");
            Console.ReadKey();
        }
    }



    // user input string => in a list

    // StoryOneMethod
    // start an empty list
    // put user inputs into it
    // Format Story(0, user Inputs)

    //StoryTwoMethod
    // start an empty list
    // put user inputs into it
    // Format Story(1, user Inputs)

    public void FormatStory(int id, List<string> strings)
    {
        string completeStory = string.Format(Stories.StoryList[is], userInputs);
        Console.WriteLine(completeStory);
        Speech.whatever

    }