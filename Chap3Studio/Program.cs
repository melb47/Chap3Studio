using System;
using System.Collections.Generic;

namespace Chap3Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            string sample = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            char[] charactersInString = sample.ToCharArray();
            Dictionary<char, int> counterList = new Dictionary<char, int>();
            

            foreach (char c in charactersInString)
            {
        
                if (!counterList.ContainsKey(c))
                {
                    int count = 1;
                    counterList.Add(c, count);
                }
                else
                {
                    counterList[c] += 1;
                }
            }
            
            foreach (KeyValuePair<char, int> charCount in counterList)
            {
                Console.WriteLine("{0}: {1}", charCount.Key, charCount.Value);
            }
        }
    }
}
