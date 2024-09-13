namespace ProgrammingOneReferences
{
    static class BranchesOperators
    {
        static public void Operators()
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
        }

        static public void ManipulatingVariables()
        {

        }

    }
}
