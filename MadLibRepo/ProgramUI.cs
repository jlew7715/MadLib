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

            Console.WriteLine($"{EnterVocab}verb");
            string verb1 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}noun");
            string noun1 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}plural noun");
            string pluralNoun1 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}verb");
            string verb2 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}verb");
            string verb3 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}famous person");
            string person = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}adjective");
            string adjective1 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}adjective");
            string adjective2 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}adjective ending in ly");
            string ly_adjective = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}noun");
            string noun2 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}catch phrase");
            string catchPhrase = Console.ReadLine().ToLower();
        }
        private void PauseAndWaitForKeypress()
        {
            Console.WriteLine("Just waiting for you to press something...");
            Console.ReadKey();
        }
        private void EnterVocab()
        {
            Console.WriteLine("Please type in a/an ");
        }
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

//StoryThreeMethod
// start an empty list
// put user inputs into it
// Format Story(2, user Inputs)

// public void FormatStory(int id, List<string> strings)
// {
   // string completeStory = string.Format(Stories.StoryList[id], userInputs);
   // Console.WriteLine(completeStory);
   // Speech.whatever

 // }