namespace ProgrammingOneReferences
{
    static class ArraysAndLoops
    {
        // Arrays
        // These are a fixed list of elements. We can specify whichever element we need them to be.
        // Be mindful! Arrays are fixed upon creation and the size cannot be changed after.
        // Also be careful! Attempting to access a index that is not within bounds will throw an error!
        static public void NumberArray()
        {
            // Creating an array and initiating the size
            int[] numbers = new int[3];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
        }

        // A way to repeat logic over a specified amount, or based on certain conditions.
        static public void ForLoop()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Current Number: " + i);
            }
        }

        // Creating an array and setting the values upon creation
        static string[] names = new string[] { "Zelda", "Samus", "Peach" };

        static public void LoopThroughNames()
        {
            // A very basic way to iterate through all items in an array.
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        static public void WhileLoop()
        {
            // Sometimes we need to handle looping functionality based on a specific conditional
            // This while loop code will be entered as long as the condition returns true
            // If the condition is false even at the beginning of execution it will not enter.
            int health = 100;
            while (health > 0)
            {
                health--;
            }

            Console.WriteLine("You died!");
        }

        static public void DoWhileLoop()
        {
            // Do while loops are very similar to regular while loops
            // The difference is they code while be executed even if the while condition is false
            // This will guarantee that this code runs at least once regardless of the condition
            string characterName = "Zelda";
            do
            {
                Console.WriteLine("This happened even though the while condition was false");
            }
            while (characterName != "Zelda");
        }

        // Continue Keyword
        // This allow us to go back to the start of the loop and avoid any logic under the continue keyword
        static public void DontPrintEvenNumbers()
        {
            for(int i = 0; i < 100; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        // Break Keyword
        // This will break us out of the current loop we are in
        static public void StopAfterFinding5()
        {
            for(int i = 0; i < 10; i++)
            {
                if(i == 5)
                {
                    Console.WriteLine("We found 5! We can stop now");
                    break;
                }
                Console.WriteLine("Still looking for a 5...");
            }
        }

        // Return Keyword
        // This will immediately leave the function call and return any value along with the return keyword
        static public int FindAGoodNumber()
        {
            int attempts = 0;
            while (attempts < 10)
            {
                Random random = new Random();
                int dTenDiceRoll = random.Next(1, 10);
                if(dTenDiceRoll == 8)
                {
                    Console.WriteLine("Yay my favorite number was rolled! " +  dTenDiceRoll);
                    return dTenDiceRoll;
                }
                else
                {
                    attempts++;
                }
            }

            // We ALWAYS need to return a value if the function signature calls for it.
            Console.WriteLine("We couldn't find my favorite number, so you get nothing!");
            return 0;
        }

    }
}
