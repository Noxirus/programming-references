//Please refer to the specific classes in the solution explorer to see examples of the code we have worked on during class.
using ProgrammingOneReferences.DataStructures;
using ProgrammingOneReferences.Variables;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionaries.Lists();
        Console.WriteLine("You mitigated: {0:N1} damage!", Enumerations.DamageMitigation(Enumerations.EWeaponTypes.Sword));
        
    }
}