namespace ProgrammingOneReferences.Variables
{
    static class StringFormatting
    {
        // Strings can be elaborate in what we can do with them and how to represent them.
        // Luckily C# has a large library of ways to format our strings!
        // Reference this site for other ways to change a string: https://learn.microsoft.com/en-us/dotnet/api/system.string.format?view=net-8.0
        public static void VariablesInStrings()
        {
            string characterName = "Blue Wizard";
            int health = 25;

            string formattedString = string.Format("{0} has {1} health remaining!", characterName, health);
            Console.WriteLine(formattedString);
        }

        public static void DecimalPlaceInNumbers()
        {
            float positionX = 15.5213F;
            float positionY = -74.1263F;

            string formattedString = string.Format("Current character position is: X:{0:N1} / Y:{1:N1}", positionX, positionY);
            Console.WriteLine(formattedString);
        }

        public static void DateFormatting()
        {
            DateTime currentTime = DateTime.Now;

            string formattedString = string.Format("The current time is: {0:HH:mm:ss} on {1:MM-dd}", currentTime, currentTime);

            Console.WriteLine(formattedString);
        }
    }
}
