namespace ProgrammingOneReferences.Variables
{
    internal class Variables
    {
        // Variables are the basis for all code.
        // We need ways to store and manipulate the data in our code.
        // This is how we can do that!

        // Boolean, this variable represent either true or false. 1 meaning true, 0 meaning false.
        bool hasDied = false; // 1 Bit

        // Character, a individual character, this is represented by surrounding the character in ''
        char rank = 'A'; // 2 Bytes

        // String, an array of characters, this is represented by surrounding the character in ""
        string characterName = "Hamish"; // 2 Bytes per character

        // Integer, a whole number
        int currentGold = 15; // 4 bytes, maximum value of: 2,147,483,647

        // Long, a whole number with twice the amount of bytes available
        long numOfDaysSinceUniverseExisted = 100000000000000L; // 8 bytes, maximum value of: 9,223,372,036,854,775,807

        // Floating point value, this allows us to insert a decimal place into the number
        float health = 100.00F; // 4 bytes

        // Double, has twice as much bytes for high potential numbers to use.
        double mana = 150.00D; // 8 bytes

        // A singular byte of 8 bits.
        byte hearts = 3; // 1 byte, maximum value of: 255

        // Extra Tips
        // A Byte is 8 bits (a series of one's and zero's in memory.
        // Reminder that strings are immutable! Which means when we change them a new array must be created in memory.
        // Integers and long values cannot have decimal places!
        // We can unsign a number to remove the negative potential, this will double the size but only allow positive numbers.
        // For example: uint, ulong
        // Try to be mindful with decided which variables to use for your project, having to change them later can make life difficult!

        // It's generally good practice to put D, F or L next
        // to the specific variable so that compiler does not get confused with a different potential value type.
    }
}
