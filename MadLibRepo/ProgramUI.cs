using System.Media;
using System.Speech.Synthesis;
namespace MadLibRepo
{
    public enum MadLib
    {
        DriversEd,
        LordRings,
        Walmart,
        EvilPlan
    }

    public class ProgramUI
    {

        public void run()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\theme.wav";
            player.Play();
            Console.WriteLine("I am your host Rick and yea, we all know I am the smartest guy there is. I have some MadLibs for you to complete.It will be just like an adventure.We will be " +
                "entering words and working hard to be creative only to realize none of this matters because nothing matters your existence is a lie, except for Andrew BUUUUURRRRRRPPPPPP, because we need him to graduate " +
                "So you dont become the next useless jerry, all you have to do is follow the prompts. Enter some nouns, and verbs and stuff and and and you will get some funny stoies. Okay im going to not waste time any longer " +
                "so im going to watch some Interdiminsional television until you complete this. If you cant complete this then you are equal to jerry, I cant take another jerry.\n" +
                "BBUUUURRRRPPP!!! Press any key even Jerry could do it!");
            PauseAndWaitForKeypress();
            MadLib c = (MadLib)new Random().Next(0, 4);
            switch (c)
            {
                case MadLib.DriversEd:
                    DriversEd();
                    break;
                case MadLib.LordRings:
                    LordRings();
                    break;
                case MadLib.Walmart:
                    Walmart();
                    break;
                case MadLib.EvilPlan:
                    EvilPlan();
                    break;
                default:
                    break;
            }
        }
        private void DriversEd()
        {
            Console.Clear();

            Console.WriteLine("Well, now you are stuck with that choice, lets begin");
            PauseAndWaitForKeypress();

            Console.Clear();

            Console.WriteLine("Please type in a verb");
            string verb1 = GetValidStringInput();

            Console.WriteLine("Please type in a noun");
            string noun1 = GetValidStringInput();

            Console.WriteLine("Please type in a plural noun");
            string plural_noun1 = GetValidStringInput();

            Console.WriteLine("Please type in a verb");
            string verb2 = GetValidStringInput();

            Console.WriteLine("Please type in another verb");
            string verb3 = GetValidStringInput();

            Console.WriteLine("Please type in a famous person");
            string person = GetValidStringInput();

            Console.WriteLine("Please type in an adjective");
            string adjective1 = GetValidStringInput();

            Console.WriteLine("Please type in another adjective");
            string adjective2 = GetValidStringInput();

            Console.WriteLine("Please type in an adjective ending in ly");
            string ly_adjective = GetValidStringInput();

            Console.WriteLine("Please type in a noun");
            string noun2 = GetValidStringInput();

            Console.WriteLine("Please type in a catch phrase");
            string catchPhrase = GetValidStringInput();

            var synthesizer = new SpeechSynthesizer();
            foreach (var voice in synthesizer.GetInstalledVoices())
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"One should always {verb1} before getting into ones car. " +
                    $"Make sure to have your {noun1} so you can unlock the vehicle. Never focus " +
                    $"on the road when thinking about {plural_noun1} because it is important. " +
                    $"Driver should always {verb2} and {verb3} while driving in thick traffic. " +
                    $"{person} is a perfect example of this. Lastly, drivers who are " +
                    $"{adjective1} and {adjective2} can drive fast and {ly_adjective}. Prepare yourself " +
                    $"and your {noun2} this is going to be a bumby ride. {catchPhrase}");

                //var info = voice.VoiceInfo;//
                synthesizer.Speak($"One should always {verb1} before getting into ones car. " +
                $"Make sure to have your {noun1} so you can unlock the vehicle. Never focus " +
                $"on the road when thinking about {plural_noun1} because it is important. " +
                $"Driver should always {verb2} and {verb3} while driving in thick traffic. " +
                $"{person} is a perfect example of this. Lastly, drivers who are " +
                $"{adjective1} and {adjective2} can drive fast and {ly_adjective}. Prepare yourself " +
                $"and your {noun2} this is going to be a bumby ride. {catchPhrase}");
                Console.ResetColor();
                PauseAndWaitForKeypress();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("%%%%######((((((((((//(//////////////////***///***/////////////////////((((((((#\r\n%%%#######((((((((((////*****///////////////////////////////////////////(((((###\r\n%########(((((((((//////********//////((///////////////////////////////((((((###\r\n%########(((((((////////////*/&&###############@/////////////////////(((((((####\r\n%%#######((((((//////*//**@######################%(//////////////////((((((((###\r\n%%########((((///////*//%##########%&(*,..../&&######/////////////////(((((((###\r\n%%%#####(((((////////*&########&..................&#&/////////////////((((((####\r\n%%####((((((/**//////&######&,......................#///*////////////((((((((###\r\n####(((/////////////(######,.......(,      #,....*(    #(/*******//////(((((((##\r\n((((((//////////////@####%......../          #..(        &*****///////(((((((###\r\n######((((//////////%####(,......,.     %    #.,      %  (*/******/////(((((####\r\n######(((/////////**&####*........#         %...*,      ,/******///////((((((###\r\n######(((//////*****/@###&#..........,(##(.......%..,,.,/*****/****///((((((####\r\n####(((((//////****///&#/......................,,......*/***////*/*///((((((####\r\n###(((((///////****/***/#*.............................#***///////////((((((####\r\n####(((((////////////*****//,.,..........&%%%%%%%&*..,///***/////////((((((((###\r\n####(((((((//////*//*********#*....................,%/******////////(((((/((((##\r\n######(((((((///////****///////%*%,............,%#**/********//////((/(((((((###\r\n######((((((///***//****/////(,...................#********//*///((((((((((((###\r\n#####(((((((////*///********#,....................****,**///////(((((((((((#####\r\n#####(((((((/////////***//*//.................... .(****///////////(((((((######\r\n######((((((/////******////#.....................&..(,*****//////////((((#######\r\n#####((((((//////********/*@.....(...............*..%*******/////////((((((((###\r\n#####(((((///*******,*****//.....#...............,..********////*////(((((((####\r\n#####(((////*********,,***/......#................* ,************//((((#########\r\n####((((////////**//******(......%................#*%*******//////(((((###(####%\r\n###((((((//////************(....@.................#.#********////(((((((((######\r\n####((((((////**********,**/....@.................#.#******//////(/((((((#######\r\n##((((((((/////*******,****/,...@.................%.(******///////(((((((#######\r\n((((((/(((((//////**********,...@.................%.#******//////(((((((#######%\r\n###(((((/////////**********/,...@.................%.#********//%#&&&&##%#@@&&&#%\r\n#####((((///////*************...@.................%.%*******////(/(((#&########%");
                Console.ResetColor();
                return;
            }

        }

        private void LordRings()
        {
            Console.Clear();

            Console.WriteLine("Well, now you are stuck with that choice, lets begin");
            PauseAndWaitForKeypress();

            Console.Clear();

            Console.WriteLine("Please type in a noun");
            string noun1 = GetValidStringInput();

            Console.WriteLine("Please type in an adjective");
            string adjective1 = GetValidStringInput();

            Console.WriteLine("Please type in an animal plural");
            string animal_plural1 = GetValidStringInput();

            Console.WriteLine("Please type in an another animal plural");
            string animal_plural2 = GetValidStringInput();

            Console.WriteLine("Please type in a verb ending in ing");
            string ing_verb = GetValidStringInput();

            Console.WriteLine("Please type in an adjective");
            string adjective2 = GetValidStringInput();

            Console.WriteLine("Please type in a famous person");
            string famous_person = GetValidStringInput();

            Console.WriteLine("Please type in a color");
            string color = GetValidStringInput();

            Console.WriteLine("Please type in a noun plural");
            string noun_plural1 = GetValidStringInput();

            Console.WriteLine("Please type in an another noun plural");
            string noun_plural2 = GetValidStringInput();

            Console.WriteLine("Please type in an animal plural");
            string animal_plural3 = GetValidStringInput();

            Console.WriteLine("Please type in a verb ending in ed");
            string ed_verb = GetValidStringInput();

            Console.WriteLine("Please type in a noun plural");
            string noun_plural3 = GetValidStringInput();

            var synthesizer = new SpeechSynthesizer();
            foreach (var voice in synthesizer.GetInstalledVoices())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"In J.R.R. Tolkien`s famous trilogy Lord of the {noun1}s " +
                    $"the first book is called Fellowship of the {noun1}. In this book a group " +
                    $"of {adjective1} Hobbits flee their hometown. They eventually join into a " +
                    $"fellowship made up of {animal_plural1}, Elves and {animal_plural2}, with the " +
                    $"goal of {ing_verb} the One {noun1}. They begin by traveling through " +
                    $"the {adjective2} mountains, where {famous_person} the {color} is lost. " +
                    $"They continue on to the forest, where the queen of the {noun_plural1} " +
                    $"gives them {noun_plural2} to ride down the river. At the end of the " +
                    $"book, Merri and Pippin get captured by {animal_plural3}, and " +
                    $"Frodo is {ed_verb} by one of his fellow {noun_plural3} and leaves on his own " +
                    $"(but with Sam).");

                //var info = voice.VoiceInfo;//
                synthesizer.Speak($"In J.R.R. Tolkien`s famous trilogy Lord of the {noun1}s " +
                    $"the first book is called Fellowship of the {noun1}. In this book a group " +
                    $"of {adjective1} Hobbits flee their hometown.They eventually join into a " +
                    $"fellowship made up of {animal_plural1}, Elves and {animal_plural2}, with the " +
                    $"goal of {ing_verb} the One {noun1}. They begin by traveling through " +
                    $"the {adjective2} mountains, where {famous_person} the {color} is lost. " +
                    $"They continue on to the forest, where the queen of the {noun_plural1} " +
                    $"gives them {noun_plural2} to ride down the river. At the end of the " +
                    $"book, Merri and Pippin get captured by {animal_plural3}, and " +
                    $"Frodo is {ed_verb} by one of his fellow {noun_plural3} and leaves on his own " +
                    $"(but with Sam).");
                Console.ResetColor();
                PauseAndWaitForKeypress();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("%%%%######((((((((((//(//////////////////***///***/////////////////////((((((((#\r\n%%%#######((((((((((////*****///////////////////////////////////////////(((((###\r\n%########(((((((((//////********//////((///////////////////////////////((((((###\r\n%########(((((((////////////*/&&###############@/////////////////////(((((((####\r\n%%#######((((((//////*//**@######################%(//////////////////((((((((###\r\n%%########((((///////*//%##########%&(*,..../&&######/////////////////(((((((###\r\n%%%#####(((((////////*&########&..................&#&/////////////////((((((####\r\n%%####((((((/**//////&######&,......................#///*////////////((((((((###\r\n####(((/////////////(######,.......(,      #,....*(    #(/*******//////(((((((##\r\n((((((//////////////@####%......../          #..(        &*****///////(((((((###\r\n######((((//////////%####(,......,.     %    #.,      %  (*/******/////(((((####\r\n######(((/////////**&####*........#         %...*,      ,/******///////((((((###\r\n######(((//////*****/@###&#..........,(##(.......%..,,.,/*****/****///((((((####\r\n####(((((//////****///&#/......................,,......*/***////*/*///((((((####\r\n###(((((///////****/***/#*.............................#***///////////((((((####\r\n####(((((////////////*****//,.,..........&%%%%%%%&*..,///***/////////((((((((###\r\n####(((((((//////*//*********#*....................,%/******////////(((((/((((##\r\n######(((((((///////****///////%*%,............,%#**/********//////((/(((((((###\r\n######((((((///***//****/////(,...................#********//*///((((((((((((###\r\n#####(((((((////*///********#,....................****,**///////(((((((((((#####\r\n#####(((((((/////////***//*//.................... .(****///////////(((((((######\r\n######((((((/////******////#.....................&..(,*****//////////((((#######\r\n#####((((((//////********/*@.....(...............*..%*******/////////((((((((###\r\n#####(((((///*******,*****//.....#...............,..********////*////(((((((####\r\n#####(((////*********,,***/......#................* ,************//((((#########\r\n####((((////////**//******(......%................#*%*******//////(((((###(####%\r\n###((((((//////************(....@.................#.#********////(((((((((######\r\n####((((((////**********,**/....@.................#.#******//////(/((((((#######\r\n##((((((((/////*******,****/,...@.................%.(******///////(((((((#######\r\n((((((/(((((//////**********,...@.................%.#******//////(((((((#######%\r\n###(((((/////////**********/,...@.................%.#********//%#&&&&##%#@@&&&#%\r\n#####((((///////*************...@.................%.%*******////(/(((#&########%");
                Console.ResetColor();
                return;
            }
        }

        private void Walmart()
        {
            Console.Clear();

            Console.WriteLine("Well, now you are stuck with that choice, lets begin");
            PauseAndWaitForKeypress();
            Console.Clear();

            Console.WriteLine("Please type in a verb");
            string verb1 = GetValidStringInput();

            Console.WriteLine("Please type in an adjective");
            string adjetive1 = GetValidStringInput();

            Console.WriteLine("Please type in a noun plural");
            string noun_plural1 = GetValidStringInput();

            Console.WriteLine("Please type in an adjective");
            string adjective2 = GetValidStringInput();

            Console.WriteLine("Please type in a verb ending in ing");
            string ing_verb = GetValidStringInput();

            Console.WriteLine("Please type in a verb");
            string verb2 = GetValidStringInput();

            Console.WriteLine("Please type in a number");
            string number = GetValidStringInput();

            Console.WriteLine("Please type in an adjective");
            string adjective3 = GetValidStringInput();

            Console.WriteLine("Please type in a noun plural");
            string noun_plural2 = GetValidStringInput(); ;

            Console.WriteLine("Please type in an another noun plural");
            string noun_plural3 = GetValidStringInput();

            Console.WriteLine("Please type in one more noun plural");
            string noun_plural4 = GetValidStringInput();

            Console.WriteLine("Please type in a noun");
            string noun = GetValidStringInput();

            Console.WriteLine("Please type in an adjective");
            string adjective4 = GetValidStringInput();

            Console.WriteLine("Please type in another adjective");
            string adjective5 = GetValidStringInput();

            Console.WriteLine("Please type in a noun plural");
            string noun_plural5 = GetValidStringInput();

            var synthesizer = new SpeechSynthesizer();
            foreach (var voice in synthesizer.GetInstalledVoices())
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Come {verb1} at WALMART, where you`ll receive {adjetive1} " +
                 $"discounts on all of your favorite brand name {noun_plural1}. Our {adjective2} and " +
                 $"{ing_verb} associates are there to {verb2} you {number} hours a day. " +
                 $"Here you will find {adjective3} prices on the {noun_plural2} you need. {noun_plural3} for " +
                 $"the moms, {noun_plural4} for the kids and all the latest electronics for the " +
                 $"{noun}. So come on down to your {adjective4} {adjective5} WALMART " +
                 $"where the {noun_plural5} come first.");

                //var info = voice.VoiceInfo;//

                synthesizer.Speak($"Come {verb1} at WALMART, where you will receive {adjetive1} " +
                $"discounts on all of your favorite brand name {noun_plural1}. Our {adjective2} and " +
                $"{ing_verb} associates are there to {verb2} you {number} hours a day. " +
                $"Here you will find {adjective3} prices on the {noun_plural2} you need. {noun_plural3} for " +
                $"the moms, {noun_plural4} for the kids and all the latest electronics for the " +
                $"{noun}. So come on down to your {adjective4} {adjective5} WALMART " +
                $"where the {noun_plural5} come first.");
                Console.ResetColor();
                PauseAndWaitForKeypress();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n&&&&&&&%%%%%%%%%%%%%#####(/*********************%%%%#/#&%%&&%%%%%%%%#/&&&&%%%%%%\r\n%%%%%%%%%%%%%%%%%%###############,#****//((/#####%##%&#%##//#&%%%%%%%##/%%%&/###\r\n%%%%%%%%%%%%%%%%%%%%%############...**///((%%%%%%%%%%#%%%%&%%##%%#(((((####%%%%%\r\n%%%%%%%%%%%%%%%%%%%%%%%###%%%%%##/...,.%//%#(%%%%%%&.,%%%%%%%%%%%%%%%%%%%%%#%##%\r\n%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@,....,.(/%#%%%%#...,(%%%%%%%%%%%%%%%%%%%%%%%%%\r\n##%%##############%%%####%%######&.,.......#%%%,...,..(#########################\r\n*&&&&&&&&&&&&&@&&&&&&&&&&&&&&%&%&%.......,,..,......,.%%##%%##%#################\r\n%(########%###%#######,,,.....,,.,,,..,,,..,,..,..,..(##&&%((,##################\r\n&&%%/%####%###&########*,........,..&,.,,,,.,,,,,.*.....,....#((#,,,,,,,,#######\r\n###&&%%(%(&@/(((((((((((#.,...,../,,,,,,,*(,,.....///,.,..,(#####*,//%/*/#######\r\n#######&&%&%##%&##########,......,,,,#.,.,%..,,,,,**..*.,,#######/,**/*/,&######\r\n########%###&%&(/%#######%/.,.,(,,,,/(/.,,,,,,,,,,,,,,/...#######%/%(/%#########\r\n########%######(((##%*........,,,.,,,,,,,,,,,,,,.,,,,,,(...,.,/%#####(/####&%###\r\n########%#%#(#&%#&*.,,,,.....,#,,,#,,,,,,,,,*,*,,,,,,,,,/,..*%##%###,/,###%%&###\r\n########%##(/#%%%%%%%%&/.,,..,/,,,(          ,/         /.%%%%%%%%%%%%%&%%%%%%%%\r\n########%%%//#%#%#####%%#%,,..*,,.,&       ,,,,,.     ,/..##(((%(#(&((/#*/#/(/*/\r\n%#######%%&%%#%#####%#/.,...,./,,,,,,,,,,,,,,,,,/,,,,,((,...*//%//#*/**%****//#*\r\n(##%%%%%&%%((#%###%,....,,.,%,,,,,,,,,,,,,,,,,,,#,,,,,,(,/,&,*%///(******@/((&**\r\n(#%####&%#%#(#%#########%(,.,,,,,,,,,,,,,,,,,,,,,,,,,,,*,%%**#%%/*%##**//(%#/##%\r\n(#%####%%%&#(#&########%#/..,,(%.,,,.,,,,,,,,,,,.,,,,,.,..&**%&&**%%&**/&/(((//*\r\n(#%###%#%%%###%%########%####%#,.,,,/,#&&&&%&(&,%#%**,#,%#%/**%##/*/*/*(**/((**(\r\n(#&###&##&@@&#&%##############,.,,...&,**,,,/,..**,/*,%##*%**##&##,*,##%&(,*,#*/\r\n(#&###&#%#%#(#%%#############%%###%,,,,,,,**,/,,,,,,%#%#((%**(&&&,(/#*&#%,,,//(/\r\n######&##&%#(#%%############%%%%%%%%%%/,,,,.,,,,*%%#%#%#%##%#%&%##,,(########%##\r\n#####/%&##&&&%%%#####((((#%%&&&&&&%%%&#,,,,,,,(%&@&&&&%##%%#%######(#(#(((((((/(\r\n##%#%///////////(%%%%((((#%%%%%%&(    ,,,***.,/     *&%#%%########/%##(####%####\r\n#%(####/,,(%#%%%%%%%%&#(@%&&&%,       ,,,,,,,,,  ,       %#(((#########(##(#####\r\n&###&#&&#%#%%#%(*,,,,,.,,#%%%%       *,,,,,,,,   .        ###%%%#######%#####%%%\r\n##&%(##&###%%###(#(###*##%#&&    (   #,,,,,,,/    *       /(((########%%######%%\r\n%&&%&&%%&%%%%%%%/((*%%*##%%%  . (    .,,,,,,,(             (((##################\r\n%///(/##/((//(,##*(*/(#%/.,*  .      ,,,,,,,,,     **      /#(,../( .,/*. .*.   \r\n./%&##*///***////////(((/((  .      /,,,,,,,,.              (**(,*(*,,,,..,,,*/*\r\n##%#/,,,*#&&#**/,../*,*,,/   ,  .   (,,,,,,,,     /  *      %//////((((###%%%%%%\r\n      **.#//#&%%*,*%((&&&    /   .  ,,,,,,,,.   (    ,      ,#######%%%%%###%###\r\n.,,,,.,/*../(/(###(##&&@     # *    ,,,,,,,,,    /           ###################\r\n////*#,/*..*(*/##@&@&&@      /     #,,,,,,,,*      (  *      &##################");
                Console.ResetColor();
                return;
            }
        }

        private void EvilPlan()
        {
            Console.Clear();
            Console.WriteLine("Well, now you are stuck with that choice, lets begin");
            PauseAndWaitForKeypress();
            Console.Clear();

            Console.WriteLine("Please type in an adjective");
            string Adjective1 = GetValidStringInput();

            Console.WriteLine("Please type in a verb");
            string Verb1 = GetValidStringInput();

            Console.WriteLine("Please type in a noun");
            string Noun1 = GetValidStringInput();

            Console.WriteLine("Please type in an adjective");
            string Adjective2 = GetValidStringInput();

            Console.WriteLine("Please type in a plural noun");
            string Plural_noun1 = GetValidStringInput();

            Console.WriteLine("Please type in a noun");
            string Noun2 = GetValidStringInput();

            Console.WriteLine("Please type in a event (Plural)");
            string Event_plural = GetValidStringInput();

            Console.WriteLine("Please type in a verb");
            string Verb2 = GetValidStringInput();

            Console.WriteLine("Please type in a noun plural");
            string Noun_plural2 = GetValidStringInput(); ;

            Console.WriteLine("Please type in an adjective");
            string Adjective3 = GetValidStringInput();

            Console.WriteLine("Please type in a noun plural");
            string Plural_noun3 = GetValidStringInput();

            Console.WriteLine("Please type in an animal");
            string Animal = GetValidStringInput();

            Console.WriteLine("Please type in an noun");
            string Noun3 = GetValidStringInput();

            Console.WriteLine("Please type in a type of vehicle");
            string Type_of_vehicle = GetValidStringInput();

            Console.WriteLine("Please type in an adjective");
            string Adjective4 = GetValidStringInput();

            Console.WriteLine("Please type in another adjective");
            string Adjective5 = GetValidStringInput();

            Console.WriteLine("Please type in a verb");
            string Verb3 = GetValidStringInput();

            Console.WriteLine("Please type in a plural noun");
            string Plural_noun4 = GetValidStringInput();

            Console.WriteLine("Please type in a company");
            string Company = GetValidStringInput();

            Console.WriteLine("Please type in a verb");
            string Verb4 = GetValidStringInput();

            Console.WriteLine("Please type in a noun");
            string Noun4 = GetValidStringInput();

            Console.WriteLine("Please type in a verb");
            string Verb5 = GetValidStringInput();

            Console.WriteLine("Please type in a plural noun");
            string Plural_noun5 = GetValidStringInput();

            Console.WriteLine("Please type in a noun");
            string Noun5 = GetValidStringInput();

            var synthesizer = new SpeechSynthesizer();
            foreach (var voice in synthesizer.GetInstalledVoices())
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"I am Doctor {Adjective1}. I am destined to {Verb1} the {Noun1}. " +
                    $"Unfortunately, the {Noun1} is full of a bunch of {Adjective2} {Plural_noun1} " +
                    $"that do not agree. I am sad to say that the {Noun2} Buster did not trigger the huge " +
                    $"{Event_plural} as I planned for it to do. Instead, all it did was {Verb2} some " +
                    $"{Noun_plural2}. So this is my new {Adjective3} plan to take over the {Noun1}:\r\n\r\nUsing " +
                    $"my unlimited source of {Plural_noun3} I inherited from my {Animal} I will build the largest " +
                    $"{Noun3} in the {Noun1}. I will then send it up into space aboard a {Type_of_vehicle}. " +
                    $"It will be fully {Adjective4} and operable from a {Adjective5} control. With it I " +
                    $"will threaten to {Verb3} all the {Plural_noun4} owned by {Company} unless the " +
                    $"{Noun1} bows before me. If they do not {Verb4} me, I will turn my {Noun3} upon the " +
                    $"{Noun4} islands and {Verb3} the entire thing. Then they will {Verb5} in their " +
                    $"{Plural_noun5} and I will be the most powerful {Noun5} in the {Noun1}!");

                synthesizer.Speak($"I am Dr. {Adjective1}. I am destined to {Verb1} the {Noun1}. " +
                    $"Unfortunately, the {Noun1} is full of a bunch of {Adjective2} {Plural_noun1} " +
                    $"that do not agree. I am sad to say that the {Noun2} Buster did not trigger the huge " +
                    $"{Event_plural} as I planned for it to do. Instead, all it did was {Verb2} some " +
                    $"{Noun_plural2}. So this is my new {Adjective3} plan to take over the {Noun1}:\r\n\r\nUsing " +
                    $"my unlimited source of {Plural_noun3} I inherited from my {Animal} I will build the largest " +
                    $"{Noun3} in the {Noun1}. I will then send it up into space aboard a {Type_of_vehicle}. " +
                    $"It will be fully {Adjective4} and operable from a {Adjective5} control. With it I " +
                    $"will threaten to {Verb3} all the {Plural_noun4} owned by {Company} unless the " +
                    $"{Noun1} bows before me. If they do not {Verb4} me, I will turn my {Noun3} upon the " +
                    $"{Noun4} islands and {Verb3} the entire thing. Then they will {Verb5} in their " +
                    $"{Plural_noun5} and I will be the most powerful {Noun5} in the {Noun1}!");
                Console.ResetColor();
                PauseAndWaitForKeypress();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\r\n&&&&&&&%%%%%%%%%%%%%#####(/*********************%%%%#/#&%%&&%%%%%%%%#/&&&&%%%%%%\r\n%%%%%%%%%%%%%%%%%%###############,#****//((/#####%##%&#%##//#&%%%%%%%##/%%%&/###\r\n%%%%%%%%%%%%%%%%%%%%%############...**///((%%%%%%%%%%#%%%%&%%##%%#(((((####%%%%%\r\n%%%%%%%%%%%%%%%%%%%%%%%###%%%%%##/...,.%//%#(%%%%%%&.,%%%%%%%%%%%%%%%%%%%%%#%##%\r\n%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@,....,.(/%#%%%%#...,(%%%%%%%%%%%%%%%%%%%%%%%%%\r\n##%%##############%%%####%%######&.,.......#%%%,...,..(#########################\r\n*&&&&&&&&&&&&&@&&&&&&&&&&&&&&%&%&%.......,,..,......,.%%##%%##%#################\r\n%(########%###%#######,,,.....,,.,,,..,,,..,,..,..,..(##&&%((,##################\r\n&&%%/%####%###&########*,........,..&,.,,,,.,,,,,.*.....,....#((#,,,,,,,,#######\r\n###&&%%(%(&@/(((((((((((#.,...,../,,,,,,,*(,,.....///,.,..,(#####*,//%/*/#######\r\n#######&&%&%##%&##########,......,,,,#.,.,%..,,,,,**..*.,,#######/,**/*/,&######\r\n########%###&%&(/%#######%/.,.,(,,,,/(/.,,,,,,,,,,,,,,/...#######%/%(/%#########\r\n########%######(((##%*........,,,.,,,,,,,,,,,,,,.,,,,,,(...,.,/%#####(/####&%###\r\n########%#%#(#&%#&*.,,,,.....,#,,,#,,,,,,,,,*,*,,,,,,,,,/,..*%##%###,/,###%%&###\r\n########%##(/#%%%%%%%%&/.,,..,/,,,(          ,/         /.%%%%%%%%%%%%%&%%%%%%%%\r\n########%%%//#%#%#####%%#%,,..*,,.,&       ,,,,,.     ,/..##(((%(#(&((/#*/#/(/*/\r\n%#######%%&%%#%#####%#/.,...,./,,,,,,,,,,,,,,,,,/,,,,,((,...*//%//#*/**%****//#*\r\n(##%%%%%&%%((#%###%,....,,.,%,,,,,,,,,,,,,,,,,,,#,,,,,,(,/,&,*%///(******@/((&**\r\n(#%####&%#%#(#%#########%(,.,,,,,,,,,,,,,,,,,,,,,,,,,,,*,%%**#%%/*%##**//(%#/##%\r\n(#%####%%%&#(#&########%#/..,,(%.,,,.,,,,,,,,,,,.,,,,,.,..&**%&&**%%&**/&/(((//*\r\n(#%###%#%%%###%%########%####%#,.,,,/,#&&&&%&(&,%#%**,#,%#%/**%##/*/*/*(**/((**(\r\n(#&###&##&@@&#&%##############,.,,...&,**,,,/,..**,/*,%##*%**##&##,*,##%&(,*,#*/\r\n(#&###&#%#%#(#%%#############%%###%,,,,,,,**,/,,,,,,%#%#((%**(&&&,(/#*&#%,,,//(/\r\n######&##&%#(#%%############%%%%%%%%%%/,,,,.,,,,*%%#%#%#%##%#%&%##,,(########%##\r\n#####/%&##&&&%%%#####((((#%%&&&&&&%%%&#,,,,,,,(%&@&&&&%##%%#%######(#(#(((((((/(\r\n##%#%///////////(%%%%((((#%%%%%%&(    ,,,***.,/     *&%#%%########/%##(####%####\r\n#%(####/,,(%#%%%%%%%%&#(@%&&&%,       ,,,,,,,,,  ,       %#(((#########(##(#####\r\n&###&#&&#%#%%#%(*,,,,,.,,#%%%%       *,,,,,,,,   .        ###%%%#######%#####%%%\r\n##&%(##&###%%###(#(###*##%#&&    (   #,,,,,,,/    *       /(((########%%######%%\r\n%&&%&&%%&%%%%%%%/((*%%*##%%%  . (    .,,,,,,,(             (((##################\r\n%///(/##/((//(,##*(*/(#%/.,*  .      ,,,,,,,,,     **      /#(,../( .,/*. .*.   \r\n./%&##*///***////////(((/((  .      /,,,,,,,,.              (**(,*(*,,,,..,,,*/*\r\n##%#/,,,*#&&#**/,../*,*,,/   ,  .   (,,,,,,,,     /  *      %//////((((###%%%%%%\r\n      **.#//#&%%*,*%((&&&    /   .  ,,,,,,,,.   (    ,      ,#######%%%%%###%###\r\n.,,,,.,/*../(/(###(##&&@     # *    ,,,,,,,,,    /           ###################\r\n////*#,/*..*(*/##@&@&&@      /     #,,,,,,,,*      (  *      &##################");
                Console.ResetColor();
                return;
            }
        }

        private void PauseAndWaitForKeypress()
        {
            Console.WriteLine("Just waiting for you to press something...");
            Console.ReadKey();
        }

        private string GetValidStringInput()
        {
            string input;
            do
            {

                input = Console.ReadLine().ToLower();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("cannot be empty");
                    Console.ResetColor();
                    PauseAndWaitForKeypress();
                }

            } while (string.IsNullOrWhiteSpace(input));

            return input;
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

/*         ???possible???

           Vocab1.Add(verb1);
           Vocab1.Add(noun1);
           Vocab1.Add(plural_noun1);
           Vocab1.Add(verb2);
           Vocab1.Add(verb3);
           Vocab1.Add(person);
           Vocab1.Add(adjective1);
           Vocab1.Add(adjective2);
           Vocab1.Add(ly_adjective);
           Vocab1.Add(noun2);
           Vocab1.Add(catchPhrase);  */