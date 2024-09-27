namespace ProgrammingOneReferences.DataStructures
{
    static class Dictionaries
    {
        enum EDamageTypes
        {
            piercing = 0,
            blunt = 1,
            slashing = 2,
            fire = 3,
        }

        // Dictionaries (or Hash Maps) can be incredibly helpful for finding specific elements rapidy.
        // We use Key Value Pairs in order to specify an index along with the value for that particular index.
        // the Key and Value can be any data type we would like!
        public static void Dictionary()
        {
            // When creating a dictionary it is similar to a list, but we need to specify both a key and a value within the <> braces.
            Dictionary<EDamageTypes, float> damageMitigation = new Dictionary<EDamageTypes, float>();
            damageMitigation.Add(EDamageTypes.piercing, 1.2f);
            damageMitigation.Add(EDamageTypes.blunt, .75f);
            damageMitigation.Add(EDamageTypes.slashing, .5f);
            damageMitigation.Add(EDamageTypes.fire, 2f);

            // Now all we need to do is pass in the key to find the value.
            Console.WriteLine("Damage mitigation was: {0}", damageMitigation[EDamageTypes.piercing]);
        }

        // Additional Tips:
        // Lists are great for scaling up, but for searching they can be a bit more performant as you may need to iterate through every single element in order to find what you are looking for.
        // Dictionaryies (hash maps) are great for finding items rapidly as you are effectively just passing in the index (location) of the item in the array.
        // Dictionaries can also be good to use if you find yourself using multiple if statements to change a value.
        // Dictionaries can be literally any data type! In game engines they can be meshes, materials, etc.
    }
}
