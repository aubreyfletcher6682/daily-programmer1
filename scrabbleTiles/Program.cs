//This was derived from daily programmer #294 -https://www.reddit.com/r/dailyprogrammer/comments/5go843/20161205_challenge_294_easy_rack_management_1/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrabbleTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomTiles;
            string proposedWord;
            bool answer;

            Console.WriteLine("Enter the tiles that you have: ");
            randomTiles = Console.ReadLine();
            Console.WriteLine("Enter the proposed word: ");
            proposedWord = Console.ReadLine();

            answer = scrabble(randomTiles, proposedWord);

            Console.WriteLine(answer);
            Console.ReadLine();
        }


        static bool scrabble(string tiles, string word)
        {
            bool fullTest = true;
            for (int i = 0; i < word.Length; i++)
            {
                bool test = false;
                for (int j = 0; j < tiles.Length; ++j)
                {
                    if (word[i] == tiles[j])
                    {
                        test = true;
                    }
                }
                if (test == false)
                {
                    fullTest = false;
                }
            }

            return fullTest;
        }
    }
}
