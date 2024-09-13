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


        static public void Branching()
        {
            // Sometimes we need to check certain conditions to see if they meet the requirements to enter code
            // We can accomplish this with if, else if, else statements

            if (true)
            {
                // This value was true so we enter this section of code
            }
            else
            {
                // The above sections returned false so this section of code was entered
            }

            // We need to use a series of operators and conditional logic to figure out if things are true or false
            int number1 = 5;
            int number2 = 3;

            // We can add as many else cases to our if statements, the code will start at the top and
            // check the conditions until it finds the first true one, then it will exit out of the whole thing
            if (number1 == number2)
            {
                // this is not true so it will not be executed here
            }
            else if(number1 > number2)
            {
                // this is true so this code will execute and exit from this whole condition statement
            }
            else
            {
                // since the above condition was true and executed, this code will not happen
            }

            // Less, greater or equal to
            // This is how we can compare numerical values to return either true or false
            if(number1 > number2)
            {
                // number1 was greater than number2
            }
            else if(number1 < number2)
            {
                // number1 was less than number2
            }
            else if(number1 == number2)
            {
                // number1 was equal to number2
            }
            else if(number1 != number2)
            {
                // number1 was not equal to number2
            }
            else if(number1 >= number2)
            {
                // number1 was greater than OR equal to number2
            }
            else if(number1 <= number2)
            {
                // number1 was less than OR equal to number2
            }
            else
            {
                // All of the above cases were false so we execute this code
            }

            // We can also check strings
            string enemyType = "Fire";
            if (enemyType == "Fire")
            {
                // We can add bonus damage when using a water attack!
            }

            string name = "Link";
            if(name != "Zelda")
            {
                // Link is not Zelda!
            }

            // We may need to check multiple conditions in a single if statement

            // AND
            // Both conditions need to be true in order for this whole statement to be true
            bool bIsAlive = true;
            int currentMana = 10;
            int manaCost = 5;

            if(bIsAlive && currentMana > manaCost)
            {
                // We are alive and have enough mana so we can cast a spell!
            }

            // OR
            // One or the other can be true in order for the statement to return true
            // Both need to be false in order for the entire statement to be false
            int rupees = 10;
            int cost = 5;
            bool bHasFreeCoupon = true;
            if(rupees >= cost || bHasFreeCoupon)
            {
                // I have enough rupees or have a free coupon so I can purchase the item!
                // Either can be true to enter this case
            }

            // !
            // The reverse boolean, this will switch the boolean from true to false or false to true
            if (!bHasFreeCoupon)
            {
                // I do not have a free coupon so I will have to pay instead!
            }

            // Tips
            // If you find your condition check is getting too long, moving it into a boolean variable can help keep it clear
            bool bCanPurchaseItem = rupees >= cost || bHasFreeCoupon;
            if (bCanPurchaseItem)
            {
                // I can purchase an item!
            }
            // Try to make sure you checks are clear and understanadable!
            // Try to make sure that the condition that is most likely to be false in an AND check occurs first
                // The code will start at the beginning and if the first case is false it will not bother to check the second one
        }
    }
}
