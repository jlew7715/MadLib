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

        private readonly Stories _repo = new Stories();

        List<string> Vocab1 = new List<string>();

        List<string> Vocab2 = new List<string>();

        List<string> Vocab3 = new List<string>();
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
            string plural_noun1 = Console.ReadLine().ToLower();

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

            Vocab1.Add.(verb1, noun1, plural_noun1, verb2, verb3, person, adjective1, adjective2, ly_adjective, noun2, catchPhrase);
        }

        private void LordRings()
        {
            Console.WriteLine("Well, now you are stuck with that choice, lets begin");
            PauseAndWaitForKeypress();

            Console.WriteLine($"{EnterVocab}noun");
            string noun1 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}adjective");
            string adjetive1 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}animal plural");
            string animal_plural1 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}another animal plural");
            string animal_plural2 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}verb ending in ing");
            string ing_verb = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}adjective");
            string adjective2 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}famous person");
            string famous_person = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}color");
            string color = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}noun plural");
            string noun_plural1 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}another noun plural");
            string noun_plural2 = Console.ReadLine().ToLower();
            
            Console.WriteLine($"{EnterVocab}animal plural");
            string animal_plural3 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}verb ending in ed");
            string ed_verb = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}noun plural");
            string noun_plural3 = Console.ReadLine().ToLower();

        }

        private void Walmart()
        {
            Console.WriteLine("Well, now you are stuck with that choice, lets begin");
            PauseAndWaitForKeypress();

            Console.WriteLine($"{EnterVocab}verb");
            string verb1 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}adjective");
            string adjetive1 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}noun plural");
            string noun_plural1 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}adjective");
            string adjective22 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}verb ending in ing");
            string ing_verb = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}verb");
            string verb2 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}number");
            string number = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}adjective");
            string adjective3 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}noun plural");
            string noun_plural2 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}another noun plural");
            string noun_plural3 = Console.ReadLine().ToLower();
           
            Console.WriteLine($"{EnterVocab}one more noun plural");
            string noun_plural4 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}noun");
            string noun = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}adjective");
            string adjective4 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}adjective");
            string adjective5 = Console.ReadLine().ToLower();

            Console.WriteLine($"{EnterVocab}noun plural");
            string noun_plural5 = Console.ReadLine().ToLower();
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