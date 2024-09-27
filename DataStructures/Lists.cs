using System.Text;

namespace ProgrammingOneReferences.DataStructures
{
    public static class Lists
    {
        // Lists are a data structure that allows us to scale up quickly.
        // Unlike arrays we can continue to add as many items to this data structure without going out of bounds of the array size.
        public static void ListFunctionlity()
        {
            List<int> numberList = new List<int>();

            // For loops can help with repetive logic in a smaller code block.
            for (int i = 1; i <= 20; i++)
            {
                numberList.Add(i);
            }

            // We can access a specific index within our list, just like an array.
            Console.WriteLine(numberList[1]);

            // We can assign the elements in the array as well.
            numberList[2] = 5;

            // To get the length of a list we use Count instead of length!
            Console.WriteLine("The length of this list is: {0:N0}", numberList.Count());

            // Removes the specific element from the list, will return true or false if it found the item.
            numberList.Remove(3);

            // We can remove items at a specific index as well.
            numberList.RemoveAt(1);

            // We can insert an element at a particular location as well.
            numberList.Insert(0, 50);

            // We can check to see if a particular element exists within our list as well.
            numberList.Contains(50);

            // We can reverse the order of the list.
            numberList.Reverse();

            // We can even sort an array!
            numberList.Sort();
        }

        // Helper functions can be useful for times when we want to re-use our code.
        static string OutputList(List<int> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in list)
            {
                sb.Append(i);
                sb.Append(" ");
            }

            return sb.ToString();
        }
    }
}
