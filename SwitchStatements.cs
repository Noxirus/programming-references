namespace ProgrammingOneReferences
{
    public static class SwitchStatements
    {
        // A switch statement is a nice way to manage multiple code responses depending on the variable we are comparing.
        // Remember to include the break at the end of each statement or the code will continue to cascade down.
        public static void HeroesNameResponse(string herosName)
        {
            switch (herosName)
            {
                case "Peach":
                    Console.WriteLine("Princess Toadstool!");
                    break;
                case "Mario":
                    Console.WriteLine("Yahooo! Lets a go!");
                    break;
                case "Yoshi":
                    Console.WriteLine("Brrrrring!");
                    break;
                case "Bowser":
                    Console.WriteLine("Mwuahahahaha");
                    break;
                default:
                    Console.WriteLine("Not sure who this is...");
                    break;

            }
        }

    }
}
