namespace ProgrammingOneReferences.Variables
{
    public static class Enumerations
    {
        // We can use enumerations to specify a particular string value with a number.
        // This can help with the readability of our code, and create rules/restrictions for our values.
        public enum EWeaponTypes
        {
            None = 0,
            Sword = 1,
            Mace = 2,
            Bow = 3,
        }

        public static float DamageMitigation(EWeaponTypes incomingWeaponType)
        {
            // We can combine things like dictionaries with our Enumerations to help find things quickly
            Dictionary<EWeaponTypes, float> damageMitigation = new Dictionary<EWeaponTypes, float>();
            damageMitigation.Add(EWeaponTypes.Bow, .5f);
            damageMitigation.Add(EWeaponTypes.Sword, 1.2f);
            damageMitigation.Add(EWeaponTypes.Mace, .3f);

            return damageMitigation[incomingWeaponType];
        }

        // We can even use the int value as a way to restrict certain options.
        public enum EMovementSpeeds
        {
            idle = 0,
            walking = 50,
            jogging = 100,
            running = 150
        }

        public static void SetMovementSpeed(EMovementSpeeds speed)
        {
            int currentMovementSpeed = (int)speed;
        }
    }
}
