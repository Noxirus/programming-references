namespace ProgrammingOneReferences.Branching
{
    static class Operators
    {
        static public void OperatorLogic()
        {
            // Operators are ways for us to apply logic to variables
            // Then also be used to check conditions and return a true or false result

            // +
            // The addition operator, adds two variables together, if they are strings or characters they will append onto each other
            int number1 = 6;
            int number2 = 3;
            int result = number1 + number2; // The result of this will be 9

            string firstString = "Hello";
            string secondString = "World";
            string resultString = firstString + " " + secondString; // Result is Hello World
            Console.WriteLine(resultString + "!");

            // -
            // The subtraction operator, will minus the second number from the first
            result = number1 - number2; // The result of this will be 3

            // *
            // The multiplication operator, will times the two numbers together
            result = number1 * number2; // The result of this will be 18

            // /
            // The division operator, will divide the two numbers
            result = number1 / number2; // The result of this will be 2

            // %
            // The modeulo operator, will return the remainder
            result = number1 % number2; // The result of this will be 0, meaning that 6 is divisible by 3
            result = 5 % 3; // The result of this will be 2

            // Extra Tips
            // Appending a string to a number will make the entire value a string
            resultString = firstString + " " + number1; // resultString will be assigned the value of: "Hello 6"
        }

        static public void ManipulatingVariables()
        {
            // There are other ways to change variable values
            int number1 = 6;
            int number2 = 3;

            // +=
            // This will add the right side to the left side variables
            number1 += number2; // number2 will be added to number1 and set number1 to 9

            // The same logic applies to all other arithmetic operators
            // Just a reminder that number1 is changing with each of these equations! number1 is not staying 6 the whole time here

            number1 -= number2; // number2 will be subtracted from number1 and set number1 back to 6
            number1 *= number2; // number1 will multiply number2 and set number1 to 18
            number1 /= number2; // number1 will divid by number2 and set number1 back to 6

            // We can also increment and assign values by using ++ and --
            number1++; // This will add 1 to number1 and set it to 7
            number1--; // This will minus 1 from number1 and set it back to 6

            // Extra Tips
            // ++ and -- can be added to either side of the variable (but not both!)
            // When ++ is on the left side of the variable it will increment the number first then execute the full line of code
            // When ++ is on the right side of the variable is will execute the line of code first then increment the number
        }
    }
}
