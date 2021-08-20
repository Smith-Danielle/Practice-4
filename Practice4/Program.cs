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
        public static string[] dirReduc(String[] arr)
        {
            List<bool> trues = new List<bool>();
            if (arr.Length == 4)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i].ToLower() == "north" && arr[i + 1] != "south" && arr[i + 1] != "north")
                    {
                        trues.Add(true);
                    }
                    if (arr[i].ToLower() == "south" && arr[i + 1] != "north" && arr[i + 1] != "south")
                    {
                        trues.Add(true);
                    }
                    if (arr[i].ToLower() == "east" && arr[i + 1] != "west" && arr[i + 1] != "east")
                    {
                        trues.Add(true);
                    }
                    if (arr[i].ToLower() == "west" && arr[i + 1] != "east" && arr[i + 1] != "west")
                    {
                        trues.Add(true);
                    }
                }
                if (trues.Count == 4)
                {
                    return arr;
                }
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].ToLower() == "north" && arr[i + 1].ToLower() == "south" || arr[i].ToLower() == "north")
                {
                    if (arr.Contains("south") || arr.Contains("SOUTH") || arr.Contains("South"))
                    {
                        arr[i] = "0";

                        if (arr.Contains("south"))
                        {
                            arr[Array.IndexOf(arr, "south")] = "0";
                        }
                        if (arr.Contains("SOUTH"))
                        {
                            arr[Array.IndexOf(arr, "SOUTH")] = "0";
                        }
                        if (arr.Contains("South"))
                        {
                            arr[Array.IndexOf(arr, "South")] = "0";
                        }
                    }
                }
                if (arr[i].ToLower() == "south" && arr[i + 1].ToLower() == "north" || arr[i].ToLower() == "south")
                {
                    if (arr.Contains("north") || arr.Contains("NORTH") || arr.Contains("North"))
                    {
                        arr[i] = "0";

                        if (arr.Contains("north"))
                        {
                            arr[Array.IndexOf(arr, "north")] = "0";
                        }
                        if (arr.Contains("NORTH"))
                        {
                            arr[Array.IndexOf(arr, "NORTH")] = "0";
                        }
                        if (arr.Contains("North"))
                        {
                            arr[Array.IndexOf(arr, "North")] = "0";
                        }
                    }
                }
                if (arr[i].ToLower() == "east" && arr[i + 1].ToLower() == "west" || arr[i].ToLower() == "east")
                {
                    if (arr.Contains("west") || arr.Contains("WEST") || arr.Contains("West"))
                    {
                        arr[i] = "0";

                        if (arr.Contains("west"))
                        {
                            arr[Array.IndexOf(arr, "west")] = "0";
                        }
                        if (arr.Contains("WEST"))
                        {
                            arr[Array.IndexOf(arr, "WEST")] = "0";
                        }
                        if (arr.Contains("West"))
                        {
                            arr[Array.IndexOf(arr, "West")] = "0";
                        }
                    }
                }
                if (arr[i].ToLower() == "west" && arr[i + 1].ToLower() == "east" || arr[i].ToLower() == "west")
                {
                    if (arr.Contains("east") || arr.Contains("EAST") || arr.Contains("East"))
                    {
                        arr[i] = "0";

                        if (arr.Contains("east"))
                        {
                            arr[Array.IndexOf(arr, "east")] = "0";
                        }
                        if (arr.Contains("EAST"))
                        {
                            arr[Array.IndexOf(arr, "EAST")] = "0";
                        }
                        if (arr.Contains("East"))
                        {
                            arr[Array.IndexOf(arr, "East")] = "0";
                        }
                    }
                }

            }
            List<string> removal = new List<string>();
            foreach (var item in arr)
            {
                if (item != "0")
                {
                    removal.Add(item);
                }
            }
            var conversion = removal.ToArray();
            return conversion;
        }


        public static int[] SortArray(int[] array)
        {
            var sort = array.Where(item => item % 2 != 0).OrderBy(item => item).ToArray();
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] = sort[count];
                    count++;
                }
            }
            return array;
        }
        public static string Rot131(string input)
        {
            string lower = input.ToLower();
            string answer = string.Empty;
            string casing = string.Empty;

            for (int i = 0; i < lower.Length; i++)
            {
                if (lower[i] == 'a')
                {
                    answer += 'n';
                }
                else if (lower[i] == 'b')
                {
                    answer += 'o';
                }
                else if (lower[i] == 'c')
                {
                    answer += 'p';
                }
                else if (lower[i] == 'd')
                {
                    answer += 'q';
                }
                else if (lower[i] == 'e')
                {
                    answer += 'r';
                }
                else if (lower[i] == 'f')
                {
                    answer += 's';
                }
                else if (lower[i] == 'g')
                {
                    answer += 't';
                }
                else if (lower[i] == 'h')
                {
                    answer += 'u';
                }
                else if (lower[i] == 'i')
                {
                    answer += 'v';
                }
                else if (lower[i] == 'j')
                {
                    answer += 'w';
                }
                else if (lower[i] == 'k')
                {
                    answer += 'x';
                }
                else if (lower[i] == 'l')
                {
                    answer += 'y';
                }
                else if (lower[i] == 'm')
                {
                    answer += 'z';
                }
                else if (lower[i] == 'n')
                {
                    answer += 'a';
                }
                else if (lower[i] == 'o')
                {
                    answer += 'b';
                }
                else if (lower[i] == 'p')
                {
                    answer += 'c';
                }
                else if (lower[i] == 'q')
                {
                    answer += 'd';
                }
                else if (lower[i] == 'r')
                {
                    answer += 'e';
                }
                else if (lower[i] == 's')
                {
                    answer += 'f';
                }
                else if (lower[i] == 't')
                {
                    answer += 'g';
                }
                else if (lower[i] == 'u')
                {
                    answer += 'h';
                }
                else if (lower[i] == 'v')
                {
                    answer += 'i';
                }
                else if (lower[i] == 'w')
                {
                    answer += 'j';
                }
                else if (lower[i] == 'x')
                {
                    answer += 'k';
                }
                else if (lower[i] == 'y')
                {
                    answer += 'l';
                }
                else if (lower[i] == 'z')
                {
                    answer += 'm';
                }
                else
                {
                    answer += lower[i];
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    casing += answer[i].ToString().ToUpper();
                }
                else
                {
                    casing += answer[i];
                }
            }
            return casing;

        }
        public static string[] WhoEatsWho(string zoo)
        {
            var animals = zoo.Split(',').ToList();
            List<string> statement = new List<string>();
            statement.Add(zoo);
            if (animals.Contains("leaves"))
            {
                if (animals.Contains("bug"))
                {
                    statement.Add("bug eats leaves");
                    animals.Remove("leaves");

                }
                if (animals.Contains("bear"))
                {
                    statement.Add("bear eats leaves");
                    animals.Remove("leaves");

                }
                if (animals.Contains("giraffe"))
                {
                    statement.Add("giraffe eats leaves");
                    animals.Remove("leaves");

                }
                if (animals.Contains("panda"))
                {
                    statement.Add("panda eats leaves");
                    animals.Remove("leaves");

                }
                else
                {
                    statement.Add("leaves");
                }
            }
            if (animals.Contains("grass"))
            {
                if (animals.Contains("antelope"))
                {
                    statement.Add("antelope eats grass");
                    animals.Remove("grass");

                }
                if (animals.Contains("cow"))
                {
                    statement.Add("cow eats grass");
                    animals.Remove("grass");

                }
                if (animals.Contains("sheep"))
                {
                    statement.Add("sheep eats grass");
                    animals.Remove("grass");

                }
                else
                {
                    statement.Add("grass");
                }
            }
            if (animals.Contains("little-fish"))
            {
                if (animals.Contains("big-fish"))
                {
                    statement.Add("big-fish eats little-fish");
                    animals.Remove("little-fish");

                }
                else
                {
                    statement.Add("little-fish");
                }
            }
            if (animals.Contains("big-fish"))
            {
                if (animals.Contains("bear"))
                {
                    statement.Add("bear eats big-fish");
                    animals.Remove("big-fish");

                }
                else
                {
                    statement.Add("big-fish");
                }
            }
            if (animals.Contains("bug"))
            {
                if (animals.Contains("bear"))
                {
                    statement.Add("bear eats bug");
                    animals.Remove("bug");

                }
                if (animals.Contains("chicken"))
                {
                    statement.Add("chicken eats bug");
                    animals.Remove("bug");

                }
                else
                {
                    statement.Add("bug");
                }
            }
            if (animals.Contains("chicken"))
            {
                if (animals.Contains("bear"))
                {
                    statement.Add("bear eats chicken");
                    animals.Remove("chicken");

                }
                if (animals.Contains("fox"))
                {
                    statement.Add("fox eats chicken");
                    animals.Remove("chicken");

                }
                else
                {
                    statement.Add("chicken");
                }
            }
            if (animals.Contains("cow"))
            {
                if (animals.Contains("bear"))
                {
                    statement.Add("bear eats cow");
                    animals.Remove("cow");

                }
                else
                {
                    statement.Add("cow");
                }
            }
            if (animals.Contains("sheep"))
            {
                if (animals.Contains("bear"))
                {
                    statement.Add("bear eats sheep");
                    animals.Remove("sheep");

                }
                if (animals.Contains("fox"))
                {
                    statement.Add("fox eats sheep");
                    animals.Remove("sheep");

                }
                else
                {
                    statement.Add("sheep");
                }
            }
            if (animals.Contains("antelope"))
            {
                if (animals.Contains("lion"))
                {
                    statement.Add("lion eats antelope");
                    animals.Remove("antelope");

                }
                else
                {
                    statement.Add("antelope");
                }
            }
            if (animals.Contains("bear"))
            {
                statement.Add("bear");
            }
            if (animals.Contains("fox"))
            {
                statement.Add("fox");
            }
            if (animals.Contains("lion"))
            {
                statement.Add("lion");
            }
            var final = statement.ToArray();
            return final;

        }

        public static bool Alphanumeric(string str)
        {
            if (str == "" || str == " " || string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            var special = str.Select(item => char.IsLetterOrDigit(item));
            if (special.Contains(false))
            {
                return false;
            }
            return true;
        }
        public static bool ValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 14)
            {
                return false;
            }
            if (phoneNumber.IndexOf('(') != 0)
            {
                return false;
            }
            if (phoneNumber.IndexOf(')') != 4)
            {
                return false;
            }
            if (phoneNumber.IndexOf(' ') != 5)
            {
                return false;
            }
            if (phoneNumber.IndexOf('-') != 9)
            {
                return false;
            }
            if (phoneNumber.Any(char.IsLetter))
            {
                return false;
            }
            return true;

        }
        public static bool is_valid_IP(string ipAddres)
        {
            if (!ipAddres.Any(Char.IsLetterOrDigit))
            {
                return false;
            }


            if (ipAddres.Any(Char.IsLetter) || ipAddres == "" || ipAddres.Contains(" ") || ipAddres == " ")
            {
                return false;
            }

            int[] split = new int[ipAddres.Length];
            for (int i = 0; i < ipAddres.Length; i++)
            {
                split[i] = Convert.ToInt32(ipAddres[i]);
            }

            if (split.Length != 4)
            {
                return false;
            }

            var split2 = ipAddres.Split('.');
            for (int i = 0; i < split2.Length; i++)
            {
                if (split2[i][0] == '0' && split2[i].Length > 1)
                {
                    return false;
                }
            }

            List<int> split1 = new List<int>();
            foreach (var item in split)
            {
                split1.Add(item);
            }

            for (int i = 0; i < split1.Count; i++)
            {
                if (split1[i] > 255 || split1[i] < 0)
                {
                    return false;
                }
            }
            return true;



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
        /*static void Main(string[] args)
        {
            int[] test = new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2, 1, 1, 1 };

            var spaces = " danielle      smith        ddms ";

            var trimIt = spaces.Trim();

            var listIt = trimIt.ToList();
            for (int i = 0; i < listIt.Count; i++)
            {
                if (listIt[i] == ' ' && listIt[i + 1] == ' ')
                {
                    listIt[i] = '0';
                }
            }
            List<char> trans = new List<char>();
            for (int i = 0; i < listIt.Count; i++)
            {
                if (listIt[i] != '0')
                {
                    trans.Add(listIt[i]);
                }
            }
            for (int i = 0; i < trans.Count; i++)
            {
                if (trans[i] == ' ')
                {
                    trans[i + 1] = char.ToUpper(trans[i + 1]);
                }
            }
            var together = string.Join("", trans);
            var upper = char.ToUpper(together[0]);
            var removed = together.Remove(0, 1);
            var replaceIt = removed.Insert(0, upper.ToString());
            var insertIt = replaceIt.Insert(0, "#");
            var finalTrim = insertIt.Replace(" ", string.Empty);
            Console.WriteLine(finalTrim);
            /*foreach (var item in trans)
            {
                Console.WriteLine(item);
            }

        }*/
        static void Main(string[] args)
        {

            int[] scores = new int[] { 9, 7, 2, 5, -2, -7, -4, -5, 1, -5, 4, -5, 2, 9, 2, -7, -7, 4, 3, 8 };
            Solution(12);

        }
        public static void Solution(long n)
        {
            long collection = 0;
            for (int i = 1; i < n + 1; i++)
            {
                var convert = i.ToString();
                if (convert.Length > 1)
                {
                    int temp = 0;
                    foreach (var item in convert)
                    {
                        temp += Convert.ToInt32(item) - 48;
                        
                    }
                    collection += temp;
                }
                else
                {
                    collection += i;
                }
            }
            Console.WriteLine(collection);
        }
        public static string ReverseWords(string str)
        {
            var split = str.Split(" ").ToList();
            List<string> reversed = new List<string>();
            for (int i = 0; i < split.Count; i++)
            {
                var temp = split[i];
                string rev = string.Empty;
                for (int j = temp.Length - 1; j >= 0; j--)
                {
                    rev += temp[j];
                }
                reversed.Add(rev);
            }
            var joined = string.Join(" ", reversed);
            return joined;
        }
        public static string Number2Words(int n)
        {
            var convert = n.ToString();
            string lettered = string.Empty;
            if (convert.Length > 5)
            {
                if (convert[convert.Length - 6] == '1')
                {
                    lettered += "one hundred ";
                }
                if (convert[convert.Length - 6] == '2')
                {
                    lettered += "two hundred ";
                }
                if (convert[convert.Length - 6] == '3')
                {
                    lettered += "three hundred ";
                }
                if (convert[convert.Length - 6] == '4')
                {
                    lettered += "four hundred ";
                }
                if (convert[convert.Length - 6] == '5')
                {
                    lettered += "five hundred ";
                }
                if (convert[convert.Length - 6] == '6')
                {
                    lettered += "six hundred ";
                }
                if (convert[convert.Length - 6] == '7')
                {
                    lettered += "seven hundred ";
                }
                if (convert[convert.Length - 6] == '8')
                {
                    lettered += "eight hundred ";
                }
                if (convert[convert.Length - 6] == '9')
                {
                    lettered += "nine hundred ";
                }
            }
            if (convert.Length > 4)
            {
                if (convert[convert.Length - 5] == '1')
                {
                    if (convert[convert.Length - 4] == '0')
                    {
                        lettered += "ten thousand ";
                    }
                    if (convert[convert.Length - 4] == '1')
                    {
                        lettered += "eleven thousand ";
                    }
                    if (convert[convert.Length - 4] == '2')
                    {
                        lettered += "twelve thousand ";
                    }
                    if (convert[convert.Length - 4] == '3')
                    {
                        lettered += "thirteen thousand ";
                    }
                    if (convert[convert.Length - 4] == '4')
                    {
                        lettered += "fourteen thousand ";
                    }
                    if (convert[convert.Length - 4] == '5')
                    {
                        lettered += "fifteen thousand ";
                    }
                    if (convert[convert.Length - 4] == '6')
                    {
                        lettered += "sixteen thousand ";
                    }
                    if (convert[convert.Length - 4] == '7')
                    {
                        lettered += "seventeen thousand ";
                    }
                    if (convert[convert.Length - 4] == '8')
                    {
                        lettered += "eighteen thousand ";
                    }
                    if (convert[convert.Length - 4] == '9')
                    {
                        lettered += "nineteen thousand ";
                    }
                }
                if (convert[convert.Length - 5] == '2')
                {
                    lettered += "twenty-";
                }
                if (convert[convert.Length - 5] == '3')
                {
                    lettered += "thirty-";
                }
                if (convert[convert.Length - 5] == '4')
                {
                    lettered += "fourty-";
                }
                if (convert[convert.Length - 5] == '5')
                {
                    lettered += "fifty-";
                }
                if (convert[convert.Length - 5] == '6')
                {
                    lettered += "sixty-";
                }
                if (convert[convert.Length - 5] == '7')
                {
                    lettered += "seventy-";
                }
                if (convert[convert.Length - 5] == '8')
                {
                    lettered += "eighty-";
                }
                if (convert[convert.Length - 5] == '9')
                {
                    lettered += "ninety-";
                }
            }
            if (convert.Length > 3)
            {
                if (convert.Length == 4 || convert[convert.Length - 5] != '1')
                {
                    if (convert[convert.Length - 4] == '1')
                    {
                        lettered += "one thousand ";
                    }
                    if (convert[convert.Length - 4] == '2')
                    {
                        lettered += "two thousand ";
                    }
                    if (convert[convert.Length - 4] == '3')
                    {
                        lettered += "three thousand ";
                    }
                    if (convert[convert.Length - 4] == '4')
                    {
                        lettered += "four thousand ";
                    }
                    if (convert[convert.Length - 4] == '5')
                    {
                        lettered += "five thousand ";
                    }
                    if (convert[convert.Length - 4] == '6')
                    {
                        lettered += "six thousand ";
                    }
                    if (convert[convert.Length - 4] == '7')
                    {
                        lettered += "seven thousand ";
                    }
                    if (convert[convert.Length - 4] == '8')
                    {
                        lettered += "eight thousand ";
                    }
                    if (convert[convert.Length - 4] == '9')
                    {
                        lettered += "nine thousand ";
                    }
                }
            }
            if (convert.Length > 2)
            {
                if (convert[convert.Length - 3] == '1')
                {
                    lettered += "one hundred ";
                }
                if (convert[convert.Length - 3] == '2')
                {
                    lettered += "two hundred ";
                }
                if (convert[convert.Length - 3] == '3')
                {
                    lettered += "three hundred ";
                }
                if (convert[convert.Length - 3] == '4')
                {
                    lettered += "four hundred ";
                }
                if (convert[convert.Length - 3] == '5')
                {
                    lettered += "five hundred ";
                }
                if (convert[convert.Length - 3] == '6')
                {
                    lettered += "six hundred ";
                }
                if (convert[convert.Length - 3] == '7')
                {
                    lettered += "seven hundred ";
                }
                if (convert[convert.Length - 3] == '8')
                {
                    lettered += "eight hundred ";
                }
                if (convert[convert.Length - 3] == '9')
                {
                    lettered += "nine hundred ";
                }
            }
            if (convert.Length > 1)
            {
                if (convert[convert.Length - 2] == '1')
                {
                    if (convert[convert.Length - 1] == '0')
                    {
                        lettered += "ten";
                    }
                    if (convert[convert.Length - 1] == '1')
                    {
                        lettered += "eleven";
                    }
                    if (convert[convert.Length - 1] == '2')
                    {
                        lettered += "twelve";
                    }
                    if (convert[convert.Length - 1] == '3')
                    {
                        lettered += "thirteen";
                    }
                    if (convert[convert.Length - 1] == '4')
                    {
                        lettered += "fourteen";
                    }
                    if (convert[convert.Length - 1] == '5')
                    {
                        lettered += "fifteen";
                    }
                    if (convert[convert.Length - 1] == '6')
                    {
                        lettered += "sixteen";
                    }
                    if (convert[convert.Length - 1] == '7')
                    {
                        lettered += "seventeen";
                    }
                    if (convert[convert.Length - 1] == '8')
                    {
                        lettered += "eighteen";
                    }
                    if (convert[convert.Length - 1] == '9')
                    {
                        lettered += "nineteen";
                    }
                }
                if (convert[convert.Length - 2] == '2')
                {
                    lettered += "twenty-";
                }
                if (convert[convert.Length - 2] == '3')
                {
                    lettered += "thirty-";
                }
                if (convert[convert.Length - 2] == '4')
                {
                    lettered += "fourty-";
                }
                if (convert[convert.Length - 2] == '5')
                {
                    lettered += "fifty-";
                }
                if (convert[convert.Length - 2] == '6')
                {
                    lettered += "sixty-";
                }
                if (convert[convert.Length - 2] == '7')
                {
                    lettered += "seventy-";
                }
                if (convert[convert.Length - 2] == '8')
                {
                    lettered += "eighty-";
                }
                if (convert[convert.Length - 2] == '9')
                {
                    lettered += "ninety-";
                }
            }
            if (convert.Length == 1 || convert[convert.Length - 2] != '1')
            {
                if (convert[convert.Length - 1] == '1')
                {
                    lettered += "one";
                }
                if (convert[convert.Length - 1] == '2')
                {
                    lettered += "two";
                }
                if (convert[convert.Length - 1] == '3')
                {
                    lettered += "three";
                }
                if (convert[convert.Length - 1] == '4')
                {
                    lettered += "four";
                }
                if (convert[convert.Length - 1] == '5')
                {
                    lettered += "five";
                }
                if (convert[convert.Length - 1] == '6')
                {
                    lettered += "six";
                }
                if (convert[convert.Length - 1] == '7')
                {
                    lettered += "seven";
                }
                if (convert[convert.Length - 1] == '8')
                {
                    lettered += "eight";
                }
                if (convert[convert.Length - 1] == '9')
                {
                    lettered += "nine";
                }
            }
            if (convert.Length == 1)
            {
                if (convert[convert.Length - 1] == '0')
                {
                    lettered += "zero";
                }
            }
            if (lettered[lettered.Length - 1] == '-')
            {
                lettered = lettered.Remove(lettered.Length - 1);
            }
            return lettered.Trim();
        }
        public static bool IsAlt(string word)
        {
            List<char> shouldBeVowel = new List<char>();
            List<char> shouldNotBeVowel = new List<char>();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u')
                {
                    if (i % 2 == 0)
                    {
                        shouldBeVowel.Add(word[i]);
                    }
                    else
                    {
                        shouldNotBeVowel.Add(word[i]);
                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {

                        shouldBeVowel.Add(word[i]);

                    }
                    else
                    {
                        shouldNotBeVowel.Add(word[i]);
                    }
                }
            }

            if (shouldBeVowel.Contains('b') || shouldBeVowel.Contains('c') || shouldBeVowel.Contains('d') || shouldBeVowel.Contains('f') || shouldBeVowel.Contains('g') || shouldBeVowel.Contains('h') || shouldBeVowel.Contains('j') || shouldBeVowel.Contains('k') || shouldBeVowel.Contains('l') || shouldBeVowel.Contains('m') || shouldBeVowel.Contains('n') || shouldBeVowel.Contains('p') || shouldBeVowel.Contains('q') || shouldBeVowel.Contains('r') || shouldBeVowel.Contains('s') || shouldBeVowel.Contains('t') || shouldBeVowel.Contains('v') || shouldBeVowel.Contains('w') || shouldBeVowel.Contains('x') || shouldBeVowel.Contains('y') || shouldBeVowel.Contains('z'))
            {
                return false;
            }
            if (shouldNotBeVowel.Contains('a') || shouldNotBeVowel.Contains('e') || shouldNotBeVowel.Contains('i') || shouldNotBeVowel.Contains('o') || shouldNotBeVowel.Contains('u'))
            {
                return false;
            }
            return true;
        }
        public static string AverageString(string str)
        {
            var strList = str.Split(" ").ToList();
            List<int> nums = new List<int>();
            foreach (var item in strList)
            {
                if (item == "zero")
                {
                    nums.Add(0);
                }
                if (item == "one")
                {
                    nums.Add(1);
                }
                if (item == "two")
                {
                    nums.Add(2);
                }
                if (item == "three")
                {
                    nums.Add(3);
                }
                if (item == "four")
                {
                    nums.Add(4);
                }
                if (item == "five")
                {
                    nums.Add(5);
                }
                if (item == "six")
                {
                    nums.Add(6);
                }
                if (item == "seven")
                {
                    nums.Add(7);
                }
                if (item == "eight")
                {
                    nums.Add(8);
                }
                if (item == "nine")
                {
                    nums.Add(9);
                }
            }
            var sum = nums.Sum(item => item);
            var average = sum / nums.Count;
            if (nums.Count != strList.Count)
            {
                return "n/a";
            }
            if (average == 0)
            {
                return "zero";
            }
            else if (average == 1)
            {
                return "one";
            }
            else if (average == 2)
            {
                return "two";
            }
            else if (average == 3)
            {
                return "three";
            }
            else if (average == 4)
            {
                return "four";
            }
            else if (average == 5)
            {
                return "five";
            }
            else if (average == 6)
            {
                return "six";
            }
            else if (average == 7)
            {
                return "seven";
            }
            else if (average == 8)
            {
                return "eight";
            }
            else if (average == 9)
            {
                return "nine";
            }
            return "n/a";
        }
        public static string jumbledString(string s, long n)
        {
            string even = string.Empty;
            string odd = string.Empty;
            long count = 0;
            
            do
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        even += s[i];
                    }
                    else
                    {
                        odd += s[i];
                    }
                    
                }
                count++;
                string endResult = string.Concat(even, odd);
                s = string.Empty;
                s = endResult;
                even = string.Empty;
                odd = string.Empty;

            } while (count < n);

            return s;

        }
        public static int[] FirstNSmallest(int[] arr, int n)
        {
            var sorted = arr.OrderBy(item => item).Take(n).ToList();
            int[] answer = new int[n];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (sorted.Contains(arr[i]) && count < n)
                {
                    answer[count] = arr[i];
                    count++;
                    sorted.Remove(arr[i]);
                }
            }
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            return answer;
            /*var sorted = arr.OrderBy(item => item).Take(n);
            List<int> answer = new List <int>();
            for ( int i = 0; i < arr.Length; i++)
            {
                if (sorted.Contains(arr[i]))
                {
                    answer.Add(arr[i]);
                }
            }
            return answer.ToArray();*/
        }
        public static string StringBreakers(int n, string str)
        {
            var newStr = str.Replace(" ", string.Empty).Trim();
            int count = 0;
            string theEmptyOne = string.Empty;
            for (int i = 0; i < newStr.Length; i++)
            {
                
                theEmptyOne += newStr[i];
                count++;
                if (count % n == 0)
                {
                    theEmptyOne += '\n';
                }
            }
            if (theEmptyOne[theEmptyOne.Length - 1] == '\n')
            {
                return theEmptyOne.Remove(theEmptyOne.Length - 1);
            }
            return theEmptyOne;
        }
        public static int CountSmileys(string[] smileys)
        {
            int count = 0;
            for (int i = 0; i < smileys.Length; i++)
            {
                if (smileys[i].Length == 2)
                {
                    if (smileys[i][0] == ':' || smileys[i][0] == ';')
                    {
                        if (smileys[i][1] == ')' || smileys[i][1] == 'D')
                        {
                            count++;
                        }
                    }
                }
                else if (smileys[i].Length == 3)
                {
                    if (smileys[i][0] == ':' || smileys[i][0] == ';')
                    {
                        if (smileys[i][1] == '-' || smileys[i][1] == '~')
                        {
                            if (smileys[i][2] == ')' || smileys[i][2] == 'D')
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }
        public static string StripComments(string text, string[] commentSymbols)
        {
            bool action = true;
            string newText = string.Empty;
            
            for (int i = 0; i < text.Length; i++)
            {
                if (!commentSymbols.Contains(text[i].ToString()) && action == true)
                {
                    newText += text[i];
                }
                else
                {
                    action = false;
                }
                string newText2 = string.Empty;
                if (action == false && text[i] == '\n')
                {
                    newText2 = newText.Remove(newText.Length - 1);
                    newText2 += text[i];
                    action = true;
                }
                if (newText2.Length > 0)
                {
                    newText = newText2;
                }
            }
            return newText;
        }
        public static int Average(int[] scores)
        {
            double sum = scores.Sum();
            double average = sum / scores.Length;
            return Convert.ToInt32(Math.Round(average, 0));
        }
        public static string GoodVsEvil(string good, string evil)
        {
            var goodSplit = good.Split(" ").ToArray();
            int[] goodArray = Array.ConvertAll(goodSplit, int.Parse);
            int goodCount = goodArray[0] * 1 + goodArray[1] * 2 + goodArray[2] * 3 + goodArray[3] * 3 + goodArray[4] * 4 + goodArray[5] * 10;

            var evilSplit = evil.Split(" ").ToArray();
            int[] evilArray = Array.ConvertAll(evilSplit, int.Parse);
            int evilCount = evilArray[0] * 1 + evilArray[1] * 2 + evilArray[2] * 2 + evilArray[3] * 2 + evilArray[4] * 3 + evilArray[5] * 5 + evilArray[6] * 10;
            if (goodCount > evilCount)
            {
                return "Battle Result: Good triumphs over Evil";
            }
            else if (goodCount == evilCount)
            {
                return "Battle Result: No victor on this battle field";
            }
            return "Battle Result: Evil eradicates all trace of Good";
            
        }
        public static void DeleteNth(int[] arr, int x)
        {
            var over = arr.GroupBy(item => item).Where(item => item.Count() > x).Select(item => item.Key).ToList();
            int[] counter = new int[over.Count()];
            for (int i = 0; i < over.Count(); i++)
            {
                counter[i] = 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < over.Count(); j++)
                {
                    if (arr[i] == over[j]) 
                    {
                        if (counter[j] > x - 1)
                        {
                            arr[i] = 0;
                        }
                        counter[j]++;
                    }
                }
            }
            List<int> answer = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    answer.Add(arr[i]);
                }
            }
            var answerArray = answer.ToArray();
            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
        }
        public static void wave(string str)
        {
            List<string> words = new List<string>();

            var wordLength = str.Length;
            for (int i = 0; i < wordLength; i++)
            {
                words.Add(str);
            }
            List<string> newWords = new List<string>();
            int count = 0;
            for (int i = 0; i < words.Count; i++)
            {
                
                string charToAdd = string.Empty;
                string wordRemoved = string.Empty;
                
                    charToAdd = char.ToUpper(words[i][count]).ToString();
                    wordRemoved = words[i].Remove(count, 1);
                    newWords.Add(wordRemoved.Insert(count, charToAdd));
                    count++;
                
                
            }
            for (int i = 0; i < words.Count; i++)
            {
                if (!words[i].Any(char.IsUpper))
                {
                    newWords.Remove(words[i]);
                }
            }
            foreach (var item in newWords)
            {
                Console.WriteLine(item);
            }
        }
        public static void CamelCase(string str)
        {
            if (str == null || str == "" || str == " ")
            {
                //return "";
            }
            var listOut = str.ToList();
            listOut[0] = Char.ToUpper(listOut[0]);
            for (int i = 1; i < listOut.Count; i++)
            {
                if (listOut[i - 1] == ' ')
                {
                    listOut[i] = Char.ToUpper(listOut[i]);
                }
            }
            foreach (var item in listOut)
            {

            }
            var answer = string.Join("", listOut);
            var noSpace = answer.Replace(" ", String.Empty);



            //var listIt = str.Split().ToList();
            /*foreach (var item in listOut)
            {
                Console.WriteLine(item);
            }*/
        Console.WriteLine(noSpace);
        }
        public static bool Narcissistic(int value)
        {
            int[] array = Array.ConvertAll(value.ToString().ToArray(), item => (int)item - 48);
            List<double> pow = new List<double>();
            for (int i = 0; i < array.Length; i++)
            {
                pow.Add(Math.Pow(array[i], array.Length));
            }
            var sum = pow.Sum();
            if (sum == value)
            {
                return true;
            }
            return false;
        }
        public static double Arithmetic(double a, double b, string op)
        {
            double answer = 0;
            if (op == "add")
            {
                answer = a + b;
            }
            else if (op == "subtract")
            {
                answer = a - b;
            }
            else if (op == "divide")
            {
                answer = a / b;
            }
            else if (op == "multiply")
            {
                answer = a * b;
            }
            return answer;
        }
        public static int SumDigits(int number)
        {
            var array = number.ToString().ToArray();
            int[] numArray = Array.ConvertAll(number.ToString().ToArray(), item => Convert.ToInt32(item));
            var sum = Math.Abs(numArray.Sum());
            return sum;
        }
            public static void FindNumber(int[] array)
        {
            int arrayCount = array.Length + 1;
            List<int> test = new List<int>();
            for (int i = 1; i < arrayCount + 1; i++)
            {
                test.Add(i);
            }
            List<bool> tOrF = new List<bool>();
            for (int i = 0; i < test.Count; i++)
            {
                if (array.Contains(test[i]))
                {
                    tOrF.Add(true);
                }
                else
                {
                    tOrF.Add(false);
                }
            }
            var indexFalse = tOrF.IndexOf(false);
            Console.WriteLine(test[indexFalse]);
        }



        public static void GetFizzBuzzArray(int n)
        {
            List<string> answer = new List<string>();
            for (int i = 1; i < n + 1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i != 1)
                {
                    answer.Add("Fizz");
                }
                else if (i % 3 == 0 && i != 1)
                {
                    answer.Add("Fizz");
                }
                else if (i % 5 == 0 && i != 1)
                {
                    answer.Add("Buzz");
                }
                else
                {
                    answer.Add(Convert.ToString(i));
                }

            }
            var finalAnswer = answer.ToArray();
          
        }
        public static int Persistence(long n)
        {
            if (n.ToString().Length == 1)
            {
                //return 0;
            }
            long newN = n;
            int count = 0;

            do
            {
                long multiple = 1;
                int[] array = Array.ConvertAll(newN.ToString().ToArray(), item => (int)item - 48);
                foreach (var item in array)
                {
                    multiple *= item;
                }
                newN = multiple;
                count++;
            } while (newN.ToString().Length > 1);
            return count;
        }
        public static int findSum(int n)
        {
            int answer = 0;
            for (int i = 2; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    answer += i;
                }
            }
            return answer;
        }
        public static int[] minMax(int[] lst)
        {
            int[] answer = new int[2];
            if (lst.Length == 1)
            {
                answer[0] = lst[0];
                answer[1] = lst[0];
                return answer;
            }
            else
            {
                answer[0] = lst.Max();
                answer[1] = lst.Min();
            }
            return answer;
        }
        public static int Stray(int[] numbers)
        {
            var single = numbers.GroupBy(item => item).Where(item => item.Count() == 1).Select(item => item.Key);
            
            return single.First();
        }
        public static string Switcheroo(string x)
        {
            List<string> switched = new List<string>();
            foreach (var item in x)
            {
                if (item == 'a')
                {
                    switched.Add("b");
                }
                else if (item == 'b')
                {
                    switched.Add("a");
                }
                else
                {
                    switched.Add(item.ToString());
                }
            }
            var finalSwitch = string.Join("", switched);
            return finalSwitch;
        }
        /*public static void SumDigits(int number)
        {
            var array = number.ToString().ToArray();
            int[] numArray = Array.ConvertAll(number.ToString().ToArray(), item => Convert.ToInt32(item));
            var sum = numArray.Sum();
            //foreach (var item in num)
            {
                //Console.WriteLine(item);
            }
        }*/
        public static bool ValidatePin(string pin)
        {
            if (pin.Length != 4 && pin.Length != 6)
            {
                return false;
            }

           

            return true;
        }
        public static string Tickets(int[] peopleInLine)
        {
            int til = 0;

            for (int i = 0; i < peopleInLine.Length; i++)
            {
                int x = peopleInLine[i] - 25;
                if (til < x)
                {
                    return "NO";
                }
                else
                {
                    if (x == 0)
                    {
                        til += peopleInLine[i];
                    }
                    else
                    {
                        til += peopleInLine[i];
                        til -= x;
                    }
                }
            }
            return "YES";
        }
    }
}
