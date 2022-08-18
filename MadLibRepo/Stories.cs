using System.Speech.Synthesis;

namespace MadLibRepo
{
    public class Stories
    {
        public List<string> void Story_1()
        {
            Console.WriteLine($"One should always {verb1} before getting into ones car.+",
                $"Make sure to have your {noun1} so you can unlock the vehicle.Never focus+",
                $"on the road when thinking about {plural_noun1} because it is important.+",
                $"Driver should always {verb2} and {verb3} while driving in thick traffic.+",
                $"{famous_person} is a perfect example of this. Lastly, drivers who are+",
                $"{adjective1} and {adjective2} can drive fast and {ly_adjective}. Prepare yourself+",
                $"and your {noun2} this is going to be a bumby ride. {catchphrase}");

        }
        private void Story_2()
        {
            Console.WriteLine($"In J.R.R. Tolkien`s famous trilogy Lord of the {noun1}s+", 
                $"the first book is called Fellowship of the {noun1}. In this book a group+",
                $"of {adjective1} Hobbits flee their hometown.They eventually join into a+",
                $"fellowship made up of {animal_plural1}, Elves and {animal_plural2}, with the+",
                $"goal of {ing_verb} the One {noun1}. They begin by traveling through+",
                $"the {adjective2} mountains, where {famous_person} the {color} is lost.+", 
                $"They continue on to the forest, where the queen of the {plural_noun1}+",
                $"gives them {plural_noun2} to ride down the river. At the end of the+",
                $"book, Merri and Pippin get captured by {animal_plural3}, and+",
                $"Frodo is {ed_verb} by one of his fellow {noun_plural3} and leaves on his own+",
                $"(but with Sam).");
        }
        private void Story_3()
        {
            Console.WriteLine($"Come {verb1} at WALMART, where you`ll receive {adjective1}+",
                $"discounts on all of your favorite brand name {plural_noun1}. Our {adjective2} and+",
                $"{ing_verb} associates are there to {verb2} you {num1} hours a day.+",
                $"Here you will find {adjective3} prices on the {plural_noun2} you need. {plural_noun3} for+",
                $"the moms, {plural_noun4} for the kids and all the latest electronics for the+",
                $"{noun}. So come on down to your {adjective4} {adjective5} WALMART+",
                $"where the {plural_noun5} come first.");
        }
    }
}