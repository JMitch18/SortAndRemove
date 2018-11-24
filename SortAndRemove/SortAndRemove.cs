using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndRemove
{
    class SortAndRemove
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //list of letters
            var letters = new List<char>();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


            //Adding random letters to letters list
            Console.Write("Original letters: ");
            for (int i = 0; i < chars.Length; i++)
            {
                letters.Add(chars[rand.Next(chars.Length)]);
            }

            foreach (var letter in letters)
            {
                Console.Write(letter);
            }

            Console.WriteLine();

            //Sorting in ascending order

            var ascendingLetters = from letter in letters orderby letter ascending select letter;

            Console.Write("Ascending letters: ");
            foreach (var al in ascendingLetters)
            {
                Console.Write(al);
            }

            Console.WriteLine();


            // Sorting in descending Order
            var descendingLetters = from letter in letters orderby letter descending select letter;

            Console.Write("Descending letters: ");
            foreach (var dl in descendingLetters)
            {
                Console.Write(dl);
            }



            Console.ReadKey();

        }
    }
}
