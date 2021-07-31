using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;

namespace Practice4
{
    class Program
    {
        
        public static void Anagrams(string word, List<string> words)
        {
            var ordered = String.Concat(word.OrderBy(item => item));

            List<string> anagrams = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                var orderedItems = String.Concat(words[i].OrderBy(item => item));
                if (ordered == orderedItems)
                {
                    anagrams.Add(words[i]);
                }
            }
            foreach (var item in anagrams)
            {
                Console.WriteLine(item);
            }

        }
        public static void Sort(int[] array)
        {
            //once converted to a list of word numbers, make new sorted word number list
            //loop through the old list and see what their index is in the sorted list. create a list of these indexes
            //somehow loop through the original number list and put them in a list at the index from the index list. (might have to create an empty 0 list?)

            var arrString = Array.ConvertAll(array, item => item.ToString());

            List<string> worded = new List<string>();

            for (int i = 0; i < arrString.Length; i++)
            {
                var tempWord = String.Empty;
                if (arrString[i].Length >= 3)
                {
                    if (arrString[i][0] == '1')
                    {
                        tempWord += "one hundred";
                    }
                    if (arrString[i][0] == '2')
                    {
                        tempWord += "two hundred";
                    }
                    if (arrString[i][0] == '3')
                    {
                        tempWord += "three hundred";
                    }
                    if (arrString[i][0] == '4')
                    {
                        tempWord += "four hundred";
                    }
                    if (arrString[i][0] == '5')
                    {
                        tempWord += "five hundred";
                    }
                    if (arrString[i][0] == '6')
                    {
                        tempWord += "six hundred";
                    }
                    if (arrString[i][0] == '7')
                    {
                        tempWord += "seven hundred";
                    }
                    if (arrString[i][0] == '8')
                    {
                        tempWord += "eight hundred";
                    }
                    if (arrString[i][0] == '9')
                    {
                        tempWord += "nine hundred";
                    }
                }
                if (arrString[i].Length >= 2)
                {
                    if (arrString[i][arrString[i].Length - 2] == '1')
                    {
                        if (arrString[i][arrString[i].Length - 1] == '0')
                        {
                            tempWord += " ten";
                        }
                    }
                    if (arrString[i][arrString[i].Length - 2] == '2')
                    {
                        tempWord += " twenty";
                    }
                    if (arrString[i][arrString[i].Length - 2] == '3')
                    {
                        tempWord += " thirty";
                    }
                    if (arrString[i][arrString[i].Length - 2] == '4')
                    {
                        tempWord += " fourty";
                    }
                    if (arrString[i][arrString[i].Length - 2] == '5')
                    {
                        tempWord += " fifty";
                    }
                    if (arrString[i][arrString[i].Length - 2] == '6')
                    {
                        tempWord += " sixty";
                    }
                    if (arrString[i][arrString[i].Length - 2] == '7')
                    {
                        tempWord += " seventy";
                    }
                    if (arrString[i][arrString[i].Length - 2] == '8')
                    {
                        tempWord += " eighty";
                    }
                    if (arrString[i][arrString[i].Length - 2] == '9')
                    {
                        tempWord += " ninety";
                    }
                }
                if (arrString[i].Length >= 1)
                {
                    if (arrString[i][arrString[i].Length - 1] == '0' && arrString[i].Length == 1)
                    {
                        tempWord += " zero";
                    }
                    if (arrString[i][arrString[i].Length - 1] == '1')
                    {
                        if (arrString[i].Length >= 2 && arrString[i][arrString[i].Length - 2] == '1')
                        {
                            tempWord += " eleven";
                        }
                        else if (arrString[i].Length == 1 || arrString[i][arrString[i].Length - 2] != '1')
                        {
                            tempWord += " one";
                        }
                    }
                    if (arrString[i][arrString[i].Length - 1] == '2')
                    {
                        if (arrString[i].Length >= 2 && arrString[i][arrString[i].Length - 2] == '1')
                        {
                            tempWord += " twelve";
                        }
                        else if (arrString[i].Length == 1 || arrString[i][arrString[i].Length - 2] != '1')
                        {
                            tempWord += " two";
                        }
                    }
                    if (arrString[i][arrString[i].Length - 1] == '3')
                    {
                        if (arrString[i].Length >= 2 && arrString[i][arrString[i].Length - 2] == '1')
                        {
                            tempWord += " thirteen";
                        }
                        else if (arrString[i].Length == 1 || arrString[i][arrString[i].Length - 2] != '1')
                        {
                            tempWord += " three";
                        }
                    }
                    if (arrString[i][arrString[i].Length - 1] == '4')
                    {
                        if (arrString[i].Length >= 2 && arrString[i][arrString[i].Length - 2] == '1')
                        {
                            tempWord += " fourteen";
                        }
                        else if (arrString[i].Length == 1 || arrString[i][arrString[i].Length - 2] != '1')
                        {
                            tempWord += " four";
                        }
                    }
                    if (arrString[i][arrString[i].Length - 1] == '5')
                    {
                        if (arrString[i].Length >= 2 && arrString[i][arrString[i].Length - 2] == '1')
                        {
                            tempWord += " fifteen";
                        }
                        else if (arrString[i].Length == 1 || arrString[i][arrString[i].Length - 2] != '1')
                        {
                            tempWord += " five";
                        }
                    }
                    if (arrString[i][arrString[i].Length - 1] == '6')
                    {
                        if (arrString[i].Length >= 2 && arrString[i][arrString[i].Length - 2] == '1')
                        {
                            tempWord += " sixteen";
                        }
                        else if (arrString[i].Length == 1 || arrString[i][arrString[i].Length - 2] != '1')
                        {
                            tempWord += " six";
                        }
                    }
                    if (arrString[i][arrString[i].Length - 1] == '7')
                    {
                        if (arrString[i].Length >= 2 && arrString[i][arrString[i].Length - 2] == '1')
                        {
                            tempWord += " seventeen";
                        }
                        else if (arrString[i].Length == 1 || arrString[i][arrString[i].Length - 2] != '1')
                        {
                            tempWord += " seven";
                        }
                    }
                    if (arrString[i][arrString[i].Length - 1] == '8')
                    {
                        if (arrString[i].Length >= 2 && arrString[i][arrString[i].Length - 2] == '1')
                        {
                            tempWord += " eighteen";
                        }
                        else if (arrString[i].Length == 1 || arrString[i][arrString[i].Length - 2] != '1')
                        {
                            tempWord += " eight";
                        }
                    }
                    if (arrString[i][arrString[i].Length - 1] == '9')
                    {
                        if (arrString[i].Length >= 2 && arrString[i][arrString[i].Length - 2] == '1')
                        {
                            tempWord += " nineteen";
                        }
                        else if (arrString[i].Length == 1 || arrString[i][arrString[i].Length - 2] != '1')
                        {
                            tempWord += " nine";
                        }
                    }
                }

                worded.Add(tempWord.Trim());
            }
            var sorted = worded.OrderBy(item => item).ToList();

            List<int> indexes = new List<int>();

            for (int i = 0; i < worded.Count; i++)
            {
                if (sorted.Contains(worded[i]))
                {
                    indexes.Add(sorted.IndexOf(worded[i]));
                    sorted[indexes.Last()] = "0";
                    
                }
            }

            int[] answer = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                answer[indexes[i]] = array[i];
            }

            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog."));
            
        }
        public static bool IsPangram(string str)
        {
            var lower = str.ToLower();
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;
            for (int i = 0; i < alpha.Length; i++)
            {
                if (lower.Contains(alpha[i]))
                {
                    count += 1;
                }
            }
            if (count == 26)
            {
                return true;
            }
            return false;
        }
        public static string Rot13(string message)
        {
            string lower = message.ToLower();

            string converted = string.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                if (lower[i] == 'a')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'N';
                    }
                    else
                    {
                        converted += 'n';
                    }
                }
                if (lower[i] == 'b')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'O';
                    }
                    else
                    {
                        converted += 'o';
                    }
                }
                if (lower[i] == 'c')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'P';
                    }
                    else
                    {
                        converted += 'p';
                    }
                }
                if (lower[i] == 'd')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'Q';
                    }
                    else
                    {
                        converted += 'q';
                    }
                }
                if (lower[i] == 'e')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'R';
                    }
                    else
                    {
                        converted += 'r';
                    }
                }
                if (lower[i] == 'f')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'S';
                    }
                    else
                    {
                        converted += 's';
                    }
                }
                if (lower[i] == 'g')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'T';
                    }
                    else
                    {
                        converted += 't';
                    }
                }
                if (lower[i] == 'h')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'U';
                    }
                    else
                    {
                        converted += 'u';
                    }
                }
                if (lower[i] == 'i')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'V';
                    }
                    else
                    {
                        converted += 'v';
                    }
                }
                if (lower[i] == 'j')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'W';
                    }
                    else
                    {
                        converted += 'w';
                    }
                }
                if (lower[i] == 'k')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'X';
                    }
                    else
                    {
                        converted += 'x';
                    }
                }
                if (lower[i] == 'l')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'Y';
                    }
                    else
                    {
                        converted += 'y';
                    }
                }
                if (lower[i] == 'm')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'Z';
                    }
                    else
                    {
                        converted += 'z';
                    }
                }
                if (lower[i] == 'n')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'A';
                    }
                    else
                    {
                        converted += 'a';
                    }
                }
                if (lower[i] == 'o')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'B';
                    }
                    else
                    {
                        converted += 'b';
                    }
                }
                if (lower[i] == 'p')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'C';
                    }
                    else
                    {
                        converted += 'c';
                    }
                }
                if (lower[i] == 'q')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'D';
                    }
                    else
                    {
                        converted += 'd';
                    }
                }
                if (lower[i] == 'r')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'E';
                    }
                    else
                    {
                        converted += 'e';
                    }
                }
                if (lower[i] == 's')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'F';
                    }
                    else
                    {
                        converted += 'f';
                    }
                }
                if (lower[i] == 't')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'G';
                    }
                    else
                    {
                        converted += 'g';
                    }
                }
                if (lower[i] == 'u')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'H';
                    }
                    else
                    {
                        converted += 'h';
                    }
                }
                if (lower[i] == 'v')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'I';
                    }
                    else
                    {
                        converted += 'i';
                    }
                }
                if (lower[i] == 'w')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'J';
                    }
                    else
                    {
                        converted += 'j';
                    }
                }
                if (lower[i] == 'x')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'K';
                    }
                    else
                    {
                        converted += 'k';
                    }
                }
                if (lower[i] == 'y')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'L';
                    }
                    else
                    {
                        converted += 'l';
                    }
                }
                if (lower[i] == 'z')
                {
                    if (char.IsUpper(message[i]))
                    {
                        converted += 'M';
                    }
                    else
                    {
                        converted += 'm';
                    }
                }
                else if (!char.IsLetter(message[i]))
                {
                    converted += message[i];
                }
            }
            return converted;
        }
    }
}
