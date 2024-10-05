using System.Text;

namespace ProgrammingOneReferences.ObjectOriented
{
    // Object Oriented programming is incredibly powerful.
    // This allows us to group up our code for re-use.
    // This also allows us to describe our programs through the idea of objects as well.
    internal class PlayerCharacter
    {
        // A class is the blueprint to the object we are going to be creating.
        // A class can have variables.
        string playerName = "Player";
        float health;
        int strength = 5, dexterity = 5, intelligence = 5, constitution = 5;
        // We can use a constructor to add functionality upon object creation.
        public PlayerCharacter(string playerName, float health, int strengthRoll, int dexterityRoll, int intelligenceRoll, int constitutionRoll)
        {
            // There can be times where we have ambiguity for the variable we are trying to describe.
            // We can use the "this" keyword to specify the object and not the other value.
            this.playerName = playerName;
            this.health = health;
            this.strength = strengthRoll;
            this.dexterity = dexterityRoll;
            this.intelligence = intelligenceRoll;
            this.constitution = constitutionRoll;
        }

        // We can have multiple constructors as well as long as they have different parameters.
        public PlayerCharacter()
        {
            playerName = GenerateName();
            Random random = new Random();
            strength = random.Next(1, 10);
            dexterity = random.Next(1, 10);
            intelligence = random.Next(1, 10);
            constitution = random.Next(1, 10);

            health = constitution * 20;
        }

        // A class can also have functions.


        // Access modifiers help us control which functions and variables are available/unavailable depending on the context.
        // Public means we can access this function on the object outside of the class.
        public void ReturnPlayerDetails()
        {
            Console.WriteLine($"Player Name: {playerName} \n Strength: {strength} \n Dexterity: {dexterity} " +
                $"\n Intelligence: {intelligence} \n Constitution: {constitution} \n Current Health: {health}");
        }
        public void Attack()
        {

            Random random = new Random();
            float damageModifier = random.NextSingle() * (1.5f - 1.0f) + 1.0f;
            float attackDamage = strength * damageModifier;
            int criticalStrikeRoll = random.Next(dexterity, 100);

            if (criticalStrikeRoll > 90)
            {
                Console.WriteLine("Critical Strike!");
                attackDamage *= 2;
            }

            Console.WriteLine($"You swing your sword for {attackDamage} damage!");
        }

        // Private means we cannot access this function outside of the class.
        // Functions and variables are private by default in a class.
        private void KeepASecret()
        {
            Console.WriteLine("I am not telling you!");
        }
        private string GenerateName()
        {
            char[] consonants = { 'q', 'w', 'r', 't', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            char[] vowels = { 'e', 'u', 'i', 'o', 'a' };

            StringBuilder stringBuilder = new StringBuilder();

            Random random = new Random();
            int nameLength = random.Next(4, 8);

            bool bVowelNext = random.Next(0, 2) == 1;

            while(stringBuilder.Length < nameLength)
            {
                if (bVowelNext)
                {
                    int randomVowel = random.Next(0, vowels.Length);
                    stringBuilder.Append(vowels[randomVowel]);
                }
                else
                {
                    int randomConsonant = random.Next(0, consonants.Length);
                    stringBuilder.Append(consonants[randomConsonant]);
                }

                bVowelNext = !bVowelNext;
            }

            return stringBuilder.ToString();
        }

        // Protected means we can access these variables/functions in children classes.
        // We will be discussing inheritance in classes more in depth later.
        protected void ChildSecret()
        {
            Console.WriteLine("This is only for my children!");
        }
    }
}
