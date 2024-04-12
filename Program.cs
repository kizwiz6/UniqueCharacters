using System.Reflection.Metadata.Ecma335;

namespace UniqueCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testing the uniqueCharacters function
            Console.WriteLine(uniqueCharacters("apple"));
            Console.WriteLine(uniqueCharacters("jam"));
        }

        /// <summary>
        /// Checks if a string has all unique characters
        /// </summary>
        /// <param name="strIn">The input string to check.</param>
        /// <returns>True if all characters in the string are unique, false otherwise.</returns>
        public static bool uniqueCharacters(string strIn)
        {
            // Create a HashSet to store unique characters
            HashSet<char> characters = new HashSet<char>();

            // Iterate over each character in the input string
            foreach (char c in strIn)
            {
                // If the character is already in the HashSet, it's not unique
                if (characters.Contains(c))
                {
                    return false; // Character already encountered, not unique
                }
                // Add the character to the HashSet
                characters.Add(c);
            }

            // If the loop completes without finding any duplicate characters
            return true; // All charactesrs are unique
        }
    }
}
