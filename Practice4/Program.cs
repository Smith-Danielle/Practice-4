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
        
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            int[] answer = new int[2];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    answer[0]++;
                }
                if (input[i] < 0)
                {
                    answer[1] += input[i];
                }
            }
            if (answer == null)
            {
                return new int[0];
            }
            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
            return answer;
        }
        static void Main(string[] args)
        {

            double[] scores = new double[] { 1, 1, 1 };
            int[] i = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            string[] test = new string[] { "#", "!" };
            Console.WriteLine(ExpandedForm(12));
        }
        public static int[] PartsSums(int[] ls)
        {
            List<int> sum = new List<int>();
            int sumNum = 0;
            if (ls.Length == 0 || ls == null)
            {
                return ls;
            }
            else
            {
                sumNum += ls[0];
                sum.Add(sumNum);
            }
            if (ls.Length > 1)
            {
                for (int i = 1; i < ls.Length; i++)
                {
                    sumNum -= ls[i];
                    sum.Add(sumNum);
                }
            }
            return sum.ToArray();
        }
        public static string ExpandedForm(long num)
        {
            var number = num.ToString();
            List<string> numList = new List<string>();
            string zeros = "1";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] != '0')
                {
                    
                    numList.Add(((Convert.ToInt32(number[i]) - 48) * Convert.ToInt32(zeros)).ToString());
                    
                }
                zeros += "0";
            }
            numList.Reverse();
            var answer = string.Join(" + ", numList);
            return answer;
        }
        public static string StripComments(string text, string[] commentSymbols)
        {
            string answer = string.Empty;
            bool add = true;
            
            
            for (int i = 1; i < text.Length; i++)
            {
                if (commentSymbols.Contains(text[i].ToString()))
                {
                    add = false;
                    
                    
                    /*if (i > 2 && text[i - 1] == ' ')
                    {
                        text = text.Remove(i - 1);
                    }*/
                    

                }
                
                if (add == false && text[i] == '\n')
                {
                    add = true;
                    /*if (i > 2 && text[i - 1] == ' ')
                    {
                        text = text.Remove(i - 1);
                    }*/

                }
                if (add == false)
                {
                    text = $"{text.Substring(0, i)}{text.Substring(i + 1)}";
                    

                }

            }
            return text.Trim();
        }
        public static int[] Between(int a, int b)
        {
            List<int> answer = new List<int>();
            for (int i = a; i < b + 1; i++)
            {
                
                    answer.Add(i);
                
            }
            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
            return answer.ToArray();
        }
        public static List<int> SumConsecutives(List<int> s)
        {
            List<int> sNew = new List<int>();
            int? consecutive = null;
            int consecutiveAdd = 0;
            
            for (int i = 0; i < s.Count - 1; i++)
            {
                if (s[i] != s[i + 1] && s[i] != consecutive)
                {
                    if (consecutive != null)
                    {
                        sNew.Add(consecutiveAdd);
                        consecutive = null;
                        consecutiveAdd = 0;
                    }
                    sNew.Add(s[i]);
                }
                else
                {
                    if (s[i] != consecutive && consecutiveAdd != 0)
                    {
                        sNew.Add(consecutiveAdd);
                        consecutive = null;
                        consecutiveAdd = 0;
                    }
                    consecutive = s[i];
                    consecutiveAdd += s[i];


                }
            }
            if (consecutive != null)
            {
                sNew.Add(consecutiveAdd);
            }
            if (s[s.Count - 1] == s[s.Count - 2])
            {
                sNew[sNew.Count - 1] = sNew[sNew.Count - 1] + s[s.Count - 1];
            }
            else
            {
                sNew.Add(s[s.Count - 1]);
            }


            foreach (var item in sNew)
            {
                Console.WriteLine(item);
            }
            return sNew;
        }
        public static double[] Tribonacci(double[] signature, int n)
        {

            if (n == 0)
            {
                double[] answer0 = new double[] { };
                return answer0;
            }
            if (n == 1)
            {
                double[] answer1 = new double[] { signature[0] };
                return answer1;
            }
            if (n == 2)
            {
                double[] answer2 = new double[] { signature[0], signature[1] };
                return answer2;
            }
            var sign = signature.ToList();
            double lastNum = signature.Sum();
            if (n > 3)
            {
                sign.Add(lastNum);
            }
            int removeIndex = 0;
            while (sign.Count < n)
            {
                lastNum = lastNum - sign[removeIndex] + lastNum;
                sign.Add(lastNum);
                removeIndex++;
            }
            return sign.ToArray();
        }
        public static int Score(int[] dice)
        {
            int score = 0;
            var threes = dice.GroupBy(item => item).Where(item => item.Count() >= 3).Select(item => item.Key).ToList();
            int third = 0;
            if (threes.Any())
            {
                third = threes.Last();
            }
        
            if (third == 1)
            {
                score += 1000;
            }
            if (third == 2)
            {
                score += 200;
            }
            if (third == 3)
            {
                score += 300;
            }
            if (third == 4)
            {
                score += 400;
            }
            if (third == 5)
            {
                score += 500;
            }
            if (third == 6)
            {
                score += 600;
            }

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            
            for (int i = 0; i < dice.Length; i++)
            {
                if (third == 1 && dice[i] == 1)
                {
                    if (count1 < 3)
                    {
                        dice[i] = 0;
                        count1++;
                    }
                }
                if (third == 2 && dice[i] == 2)
                {
                    if (count2 < 3)
                    {
                        dice[i] = 0;
                        count2++;
                    }
                }
                if (third == 3 && dice[i] == 3)
                {
                    if (count3 < 3)
                    {
                        dice[i] = 0;
                        count3++;
                    }
                }
                if (third == 4 && dice[i] == 1)
                {
                    if (count4 < 3)
                    {
                        dice[i] = 0;
                        count4++;
                    }
                }
                if (third == 5 && dice[i] == 5)
                {
                    if (count5 < 3)
                    {
                        dice[i] = 0;
                        count5++;
                    }
                }
                if (third == 6 && dice[i] == 6)
                {
                    if (count6 < 3)
                    {
                        dice[i] = 0;
                        count6++;
                    }
                }

            }
            Console.WriteLine(count1);
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == 1)
                {
                    score += 100;
                }
                if (dice[i] == 5)
                {
                    score += 50;
                }
            }
            return score;
                
        }
        public static string[] dirReduc(string[] arr)
        {
            List<string> directions = new List<string> { "first" };
            var arr1 = arr.ToList();
            arr1.Add("last");
            var arr2 = arr1.ToArray();
           
            
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i].ToLower() == "north")
                {

                    if (arr2[i + 1].ToLower() == "south" || directions.Last().ToLower() == "south")
                    {

                        
                        if (arr2[i + 1].ToLower() == "south")
                        {
                            arr2[i + 1] = "removed";

                        }
                        
                        if (directions.Any() && directions.Last().ToLower() == "south")
                        {
                            directions.RemoveAt(directions.Count - 1);
                        }
                        
                        arr2[i] = "removed";
                        


                    }
                    else
                    {
                        directions.Add(arr2[i]);
                        
                    }
                }
                
                if (arr2[i].ToLower() == "south")
                {
                    
                    if (arr2[i + 1].ToLower() == "north" || directions.Last().ToLower() == "north")
                    {
                        
                        if (arr2[i + 1].ToLower() == "north")
                        {
                            arr2[i + 1] = "removed";
                        }
                        if (directions.Any() && directions.Last().ToLower() == "north")
                        {
                            directions.RemoveAt(directions.Count - 1);
                        }
                        arr2[i] = "removed";
                    }
                    else
                    {
                        directions.Add(arr2[i]);
                        
                    }
                }
                if (arr2[i].ToLower() == "east")
                {
                    if (arr2[i + 1].ToLower() == "west" || directions.Last().ToLower() == "west")
                    {
                        
                        if (arr2[i + 1].ToLower() == "west")
                        {
                            arr2[i + 1] = "removed";
                        }
                        if (directions.Any() && directions.Last().ToLower() == "west")
                        {
                            directions.RemoveAt(directions.Count - 1);
                        }
                        arr2[i] = "removed";
                    }
                    else
                    {
                        directions.Add(arr2[i]);
                        
                    }
                }
                if (arr2[i].ToLower() == "west")
                {
                    if (arr2[i + 1].ToLower() == "east" || directions.Last().ToLower() == "east")
                    {
                        
                        if (arr2[i + 1].ToLower() == "east")
                        {
                            arr2[i + 1] = "removed";
                        }
                        if (directions.Any() && directions.Last().ToLower() == "east")
                        {
                            directions.RemoveAt(directions.Count - 1);
                        }
                        arr2[i] = "removed";
                    }
                    else
                    {
                        directions.Add(arr2[i]);
                        
                    }
                }
            }
            directions.RemoveAt(0);
            return directions.ToArray();
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
        
        public static string orderWeight(string strng)
        {
            var split = strng.Split(" ").ToList();
            List<string> numIndex = new List<string>();
            for (int i = 0; i < split.Count; i++)
            {
                int total = 0;
                for (int j = 0; j < split[i].Length; j++)
                {
                    total += split[i][j] - 48;
                 }
                numIndex.Add($"{total}.{i}");

            }
            List<decimal> convert = new List<decimal>();
            foreach (var item in numIndex)
            {
                convert.Add(Convert.ToDecimal(item));
            }
            var order = convert.OrderBy(item => item).ToList();
            List<string> index = new List<string>();
            foreach (var item in order)
            {
                var temp = item.ToString();
                index.Add(temp.Substring(temp.IndexOf('.') + 1));
            }
            List<string> answer = new List<string>();
            for (int i = 0; i < index.Count; i++)
            {
                answer.Add(split[Convert.ToInt32(index[i])]);
            }
            var final = string.Join(" ", answer);
            return final;
        }
        public static string SplitInParts(string s, int partLength)
        {
            string answer = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && i % partLength == 0)
                {
                    answer += " ";
                }
                answer += s[i];
            }
            return answer;
        }
        public static string RPSLP(string player1, string player2)
        {
            if (player1.ToLower() == "rock")
            {
                if (player2.ToLower() == "lizard" || player2.ToLower() == "scissor")
                {
                    return "Player 1 won!";
                }
                else if (player2.ToLower() == "spock" || player2.ToLower() == "paper")
                {
                    return "Player 2 won!";
                }
                else if (player2.ToLower() == "rock")
                {
                    return "Draw!";
                }
            }
            if (player1.ToLower() == "paper")
            {
                if (player2.ToLower() == "rock" || player2.ToLower() == "spock")
                {
                    return "Player 1 won!";
                }
                else if (player2.ToLower() == "scissor" || player2.ToLower() == "lizard")
                {
                    return "Player 2 won!";
                }
                else if (player2.ToLower() == "paper")
                {
                    return "Draw!";
                }

            }
            if (player1.ToLower() == "scissor")
            {
                if (player2.ToLower() == "lizard" || player2.ToLower() == "paper")
                {
                    return "Player 1 won!";
                }
                else if (player2.ToLower() == "rock" || player2.ToLower() == "spock")
                {
                    return "Player 2 won!";
                }
                else if (player2.ToLower() == "scissor")
                {
                    return "Draw!";
                }
            }
            if (player1.ToLower() == "spock")
            {
                if (player2.ToLower() == "scissor" || player2.ToLower() == "rock")
                {
                    return "Player 1 won!";
                }
                else if (player2.ToLower() == "lizard" || player2.ToLower() == "paper")
                {
                    return "Player 2 won!";
                }
                else if (player2.ToLower() == "spock")
                {
                    return "Draw!";
                }
            }
            if (player1.ToLower() == "lizard")
            {
                if (player2.ToLower() == "paper" || player2.ToLower() == "spock")
                {
                    return "Player 1 won!";
                }
                else if (player2.ToLower() == "rock" || player2.ToLower() == "scissor")
                {
                    return "Player 2 won!";
                }
                else if (player2.ToLower() == "lizard")
                {
                    return "Draw!";
                }
            }
            if (player1 == null || player2 == null)
            {
                return "Oh, Unknown Thing";
            }
            return "Oh, Unknown Thing";
        }
        public static int TrailingZeros(int n)
        {
            BigInteger fact = 1;
            for (int i = 1; i < n + 1; i++)
            {
                fact *= i;
            }
            var convert = fact.ToString();
            int zeros = 0;
            for (int i = convert.Length - 1; i >= 0; i--)
            {
               
                    if (convert[i] == '0')
                    {
                        zeros++;
                    }
                    else
                    {
                        break;
                    }
            
            }
            return zeros;
           
            
        }
        public static string Repeater(string s, int n)
        {
            string answer = string.Empty;
            for (int i = 1; i < n; i++)
            {
                answer += s;
            }
            return answer;
        }
        public static int FindDup(int[] arr)
        {
            var dup = arr.GroupBy(item => item).Where(item => item.Count() == 2).Select(item => item.Key);
            return dup.First();
        }
        public static int[] Parse(string data)
        {
            
            List<int> move = new List<int>();
            int counter = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == 'i')
                {
                    counter++;
                }
                if (data[i] == 'd')
                {
                    counter--;
                }
                if (data[i] == 's')
                {
                    counter *= counter;
                }
                if (data[i] == 'o')
                {
                    move.Add(counter);
                }
            }
            var answer = move.ToArray();
            return answer;
        }
        
        public static bool StringIntGreaterThan(string a, string b)
        {
            var aNum = int.Parse(a);
            var bNum = int.Parse(b);
            if (aNum > bNum)
            {
                return true;
            }
            return false;
        }
        public static string FormatWords(string[] words)
        {
            List<string> filtered = new List<string>();
            string longFiltered = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    filtered.Add(words[i]);
                }
            }
            if (filtered.Count == 0)
            {
                return "";
            }
            else if (filtered.Count == 2)
            {
                return string.Join(" and ", filtered);
            }
            else
            {
                for (int i = 0; i < filtered.Count; i++)
                {
                    longFiltered += filtered[i];
                    
                    
                    if (i == filtered.Count - 2)
                    {
                        longFiltered += " and ";
                    }
                    else if (i != filtered.Count - 1)
                    {
                        longFiltered += ", ";
                    }
                }
            }
            return longFiltered;
        }
        public static string NumberFormat(int number)
        {
            
            var toString = number.ToString().Reverse().ToList();
            if (toString[toString.Count - 1] == '-')
            {
                toString.Remove('-');
            }
            string nums = string.Empty;
            for (int i = toString.Count - 1; i >= 0; i--)
            {
                
                nums += toString[i];
                if (i % 3 == 0)
                {
                    nums += ',';
                }
            }
            if (nums[0] == ',')
            {
                nums = nums.Substring(1);
            }
            if (nums[nums.Length - 1] == ',')
            {
                nums = nums.Substring(0, nums.Length - 1);
            }
            if (number < 0)
            {
                return nums.Insert(0, "-");
            }
            return nums;
        }
        public static string SortTheInnerContent(string words)
        {
            var wordsList = words.Split(" ").ToList();
            List<string> individual = new List<string>();
      
            for (int i = 0; i < wordsList.Count; i++)
            {
                List<char> sorted = new List<char>();
                for (int j = 0; j < wordsList[i].Length; j++)
                {
                    sorted.Add(wordsList[i][j]);
                }
                sorted.Sort();
                var joinIt = string.Join("", sorted);
                individual.Add(joinIt);
            }
            return "hello";
        }
        public static string GetOrder(string input)
        {
            List<string> food = new List<string>();
            string item = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                item += input[i];
                if (string.Equals(item, "burger") || string.Equals(item, "fries") || string.Equals(item, "chicken") || string.Equals(item, "pizza") || string.Equals(item, "sandwich") || string.Equals(item, "onionrings") || string.Equals(item, "milkshake") || string.Equals(item, "coke"))
                {
                    var first = char.ToUpper(item[0]);
                    var rest = item.Substring(1);
                    food.Add(string.Concat(first, rest));
                    item = string.Empty;
                }
            }
            List<string> ordered = new List<string>();
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i] == "Burger")
                {
                    ordered.Add(food[i]);
                }
            }
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i] == "Fries")
                {
                    ordered.Add(food[i]);
                }
            }
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i] == "Chicken")
                {
                    ordered.Add(food[i]);
                }
            }
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i] == "Pizza")
                {
                    ordered.Add(food[i]);
                }
            }
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i] == "Sandwich")
                {
                    ordered.Add(food[i]);
                }
            }
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i] == "Onionrings")
                {
                    ordered.Add(food[i]);
                }
            }
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i] == "Milkshake")
                {
                    ordered.Add(food[i]);
                }
            }
            for (int i = 0; i < food.Count; i++)
            {
                if (food[i] == "Coke")
                {
                    ordered.Add(food[i]);
                }
            }
            var answer = string.Join(" ", ordered);
            return answer;
        }
        public static string Unlock(string str)
        {
            string answer = string.Empty;
            if (str.Contains("Nokia"))
            {
                answer = "66542";
            }
            if (str.Contains("Valut"))
            {
                answer = "82588";
            }
            if (str.Contains("toilet"))
            {
                answer = "864538";
            }
            return answer;

        }
        public static string ExtractFileName(string dirtFileName)
        {
            bool addIt = false;
            string answer = string.Empty;
            int count = 0;
            int dashCount = 0;
            for (int i = 0; i < dirtFileName.Length; i++)
            {
                if (dirtFileName[i] == '_')
                {
                    addIt = true;
                    dashCount++;
                    if (dashCount > 1)
                    {
                        answer += dirtFileName[i];
                    }
                }
                else if (dirtFileName[i] == '.')
                {
                    count++;
                    if (count < 2)
                    {
                        answer += dirtFileName[i];
                    }
                }
                else if (addIt == true && count < 2)
                {
                    answer += dirtFileName[i];
                }
                
            }
            return answer;
        }
        public static string WhoIsNext(string[] names, long n)
        {
            string answer = string.Empty;
            if (n < names.Length)
            {
                return names[n - 1];
            }
            else
            {
                long x = (long) Math.Floor((double) n / names.Length);
                Console.WriteLine(x);
                long y = x * names.Length;
                long z = n - y;
                answer = names[z];
                
            }
            return answer;
        }
        public static int Divisors(int n)
        {
            int counter = 0;
            for (int i = 0; i < n + 1; i++)
            {
                if (n % i == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
        public static string calculateString(string calcIt)
        {
            string a = string.Empty;
            string b = string.Empty;
            string symbol = string.Empty;
            bool order = true;

            for (int i = 0; i < calcIt.Length; i++)
            {
                if (char.IsNumber(calcIt[i]) || calcIt[i] == '.')
                {
                    if (order == true)
                    {
                        a += calcIt[i].ToString();
                        
                    }
                    else
                    {
                        b += calcIt[i].ToString();
                        
                    }
                }
                if (calcIt[i] == '+' || calcIt[i] == '-' || calcIt[i] == '*' || calcIt[i] == '/')
                {
                    symbol += calcIt[i].ToString();
                    order = false;
                    
                }
            }
            var aNumber = Convert.ToDouble(a);
            var bNumber = Convert.ToDouble(b);
            double answer = 0;

            if (symbol == "+")
            {
                answer = Math.Round(aNumber + bNumber);
            }
            else if (symbol == "-")
            {
                answer = aNumber - bNumber;
            }
            else if (symbol == "*")
            {
                answer = aNumber * bNumber;
            }
            else if (symbol == "/")
            {
                answer = aNumber / bNumber;
            }
            return answer.ToString();

        }
        public static bool is_valid_IP(string ipAddres)
        {
            if (ipAddres.Any(char.IsLetter) || ipAddres.Any(char.IsWhiteSpace) || ipAddres.Contains('-'))
            {
                return false;
            }
            var theList = ipAddres.Split('.').ToList();
            foreach (var item in theList)
            {
                Console.WriteLine(item);
            }
            if (theList.Count != 4)
            {
                return false;
            }
            for (int i = 0; i < theList.Count; i++)
            {
                if (theList[i].Length > 1 && theList[i][0] == '0')
                {
                    return false;
                }
            }
            for (int i = 0; i < theList.Count; i++)
            {
                if (theList[i] == "" || Convert.ToInt32(theList[i]) < 0 || Convert.ToInt32(theList[i]) > 255)
                {
                    return false;
                }
            }
            return true;
        }
        public static string StringLetterCount(string str)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;
            int o = 0;
            int p = 0;
            int q = 0;
            int r = 0;
            int s = 0;
            int t = 0;
            int u = 0;
            int v = 0;
            int w = 0;
            int x = 0;
            int y = 0;
            int z = 0;

            for (int ix = 0; ix < str.Length; ix++)
            {
                if (char.ToLower(str[ix]) == 'a')
                {
                    a++;
                }
                else if (char.ToLower(str[ix]) == 'b')
                {
                    b++;
                }
                else if (char.ToLower(str[ix]) == 'c')
                {
                    c++;
                }
                else if (char.ToLower(str[ix]) == 'd')
                {
                    d++;
                }
                else if (char.ToLower(str[ix]) == 'e')
                {
                    e++;
                }
                else if (char.ToLower(str[ix]) == 'f')
                {
                    f++;
                }
                else if (char.ToLower(str[ix]) == 'g')
                {
                    g++;
                }
                else if (char.ToLower(str[ix]) == 'h')
                {
                    h++;
                }
                else if (char.ToLower(str[ix]) == 'i')
                {
                    i++;
                }
                else if (char.ToLower(str[ix]) == 'j')
                {
                    j++;
                }
                else if (char.ToLower(str[ix]) == 'k')
                {
                    k++;
                }
                else if (char.ToLower(str[ix]) == 'l')
                {
                    l++;
                }
                else if (char.ToLower(str[ix]) == 'm')
                {
                    m++;
                }
                else if (char.ToLower(str[ix]) == 'n')
                {
                    n++;
                }
                else if (char.ToLower(str[ix]) == 'o')
                {
                    o++;
                }
                else if (char.ToLower(str[ix]) == 'p')
                {
                    p++;
                }
                else if (char.ToLower(str[ix]) == 'q')
                {
                    q++;
                }
                else if (char.ToLower(str[ix]) == 'r')
                {
                    r++;
                }
                else if (char.ToLower(str[ix]) == 's')
                {
                    s++;
                }
                else if (char.ToLower(str[ix]) == 't')
                {
                    t++;
                }
                else if (char.ToLower(str[ix]) == 'u')
                {
                    u++;
                }
                else if (char.ToLower(str[ix]) == 'v')
                {
                    v++;
                }
                else if (char.ToLower(str[ix]) == 'w')
                {
                    w++;
                }
                else if (char.ToLower(str[ix]) == 'x')
                {
                    x++;
                }
                else if (char.ToLower(str[ix]) == 'y')
                {
                    y++;
                }
                else if (char.ToLower(str[ix]) == 'z')
                {
                    z++;
                }
            }
                string answer = string.Empty;
                if (a > 0)
                {
                    answer += $"{a}a";
                }
                if (b > 0)
                {
                    answer += $"{b}b";
                }
                if (c > 0)
                {
                    answer += $"{c}c";
                }
                if (d > 0)
                {
                    answer += $"{d}d";
                }
                if (e > 0)
                {
                    answer += $"{e}e";
                }
                if (f > 0)
                {
                    answer += $"{f}f";
                }
                if (g > 0)
                {
                    answer += $"{g}g";
                }
                if (h > 0)
                {
                    answer += $"{h}h";
                }
                if (i > 0)
                {
                    answer += $"{i}i";
                }
                if (j > 0)
                {
                    answer += $"{j}j";
                }
                if (k > 0)
                {
                    answer += $"{k}k";
                }
                if (l > 0)
                {
                    answer += $"{l}l";
                }
                if (m > 0)
                {
                    answer += $"{m}m";
                }
                if (n > 0)
                {
                    answer += $"{n}n";
                }
                if (o > 0)
                {
                    answer += $"{o}o";
                }
                if (p > 0)
                {
                    answer += $"{p}p";
                }
                if (q > 0)
                {
                    answer += $"{q}q";
                }
                if (r > 0)
                {
                    answer += $"{r}r";
                }
                if (s > 0)
                {
                    answer += $"{s}s";
                }
                if (t > 0)
                {
                    answer += $"{t}t";
                }
                if (u > 0)
                {
                    answer += $"{u}u";
                }
                if (v > 0)
                {
                    answer += $"{v}v";
                }
                if (w > 0)
                {
                    answer += $"{w}w";
                }
                if (x > 0)
                {
                    answer += $"{x}x";
                }
                if (y > 0)
                {
                    answer += $"{y}y";
                }
                if (z > 0)
                {
                    answer += $"{z}z";
                }
            
            return answer;
       
        }
        public string ReverseLetter(string str)
        {
            string letters = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(str[i]))
                {
                    letters += str[i];
                }
            }
            return letters;
        }
        public static bool isAValidMessage(string message)
        {
            if (!message.Any())
            {
                return true;
            }
            if (char.IsLetter(message[0]) || char.IsNumber(message[message.Length - 1]) || message == "")
            {
                return false;
            }
            if (message.Contains(" "))
            {
                return false;
            }
            
            List<int> indexes = new List<int>();
            List<double> words = new List<double>();
            string num = string.Empty;
            double counter = 0;
            for (int i = 0; i < message.Length; i++)
            {
                
                if (char.IsNumber(message[i]))
                {
                    if (counter != 0)
                    {
                        words.Add(counter);
                        counter = 0;
                    }
                    num += message[i];
                }
                if (char.IsLetter(message[i]))
                {
                    if (num.Any())
                    {
                        indexes.Add(Convert.ToInt32(num));
                        num = string.Empty;
                    }
                    counter++;
                }
                if (char.IsWhiteSpace(message[i]))
                {
                    return false;
                }
            }
            if (counter != 0)
            {
                words.Add(counter);
               
            }
            if (num.Any())
            {
                indexes.Add(Convert.ToInt32(num));
                
            }
            
            for (int i = 0; i < indexes.Count; i++)
            {
                for (int j = 0; j < words.Count; j++)
                {
                    if (i != j && indexes[i] != words[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static int SumDigits(int number)
        {
            var convert = number.ToString();
            int count = 0;
            for (int i = 0; i < convert.Length; i++)
            {
                if (char.IsDigit(convert[i]))
                {
                    count += Math.Abs(Convert.ToInt32(convert[i] - 48));
                }
                
            }
            return count;
        }
        public static string RemoveParentheses(string s)
        {
            string noPar = string.Empty;
            bool leave = true;
            int openCount = 0;
            int closedCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
               
                if (s[i] == '(')
                {
                    leave = false;
                    openCount++;
                }
                if (leave == true)
                {
                    noPar += s[i];
                }
                if (s[i] == ')')
                {
                    closedCount++;
                    if (openCount == closedCount)
                    {
                        leave = true;
                    }
                }
                
            }
            return noPar;
        }
        public static int Solve(string s)
        {
            List<string> constant = new List<string>();
            string individual = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u')
                {
                    individual += s[i];
                    
                }
                else
                {

                    if (individual.Any())
                    {
                        constant.Add(individual);
                        individual = string.Empty;
                    }
                    
                }
            }
            if (individual.Any())
            {
                constant.Add(individual);
            }
            List<int> ranking = new List<int>();
            for (int i = 0; i < constant.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < constant[i].Length; j++)
                {
                    
                    if (constant[i][j] == 'b')
                    {
                        count += 2;
                    }
                    if (constant[i][j] == 'c')
                    {
                        count += 3;
                    }
                    if (constant[i][j] == 'd')
                    {
                        count += 4;
                    }
                    if (constant[i][j] == 'f')
                    {
                        count += 6;
                    }
                    if (constant[i][j] == 'g')
                    {
                        count += 7;
                    }
                    if (constant[i][j] == 'h')
                    {
                        count += 8;
                    }
                    if (constant[i][j] == 'j')
                    {
                        count += 10;
                    }
                    if (constant[i][j] == 'k')
                    {
                        count += 11;
                    }
                    if (constant[i][j] == 'l')
                    {
                        count += 12;
                    }
                    if (constant[i][j] == 'm')
                    {
                        count += 13;
                    }
                    if (constant[i][j] == 'n')
                    {
                        count += 14;
                    }
                    if (constant[i][j] == 'p')
                    {
                        count += 16;
                    }
                    if (constant[i][j] == 'q')
                    {
                        count += 17;
                    }
                    if (constant[i][j] == 'r')
                    {
                        count += 18;
                    }
                    if (constant[i][j] == 's')
                    {
                        count += 19;
                    }
                    if (constant[i][j] == 't')
                    {
                        count += 20;
                    }
                    if (constant[i][j] == 'v')
                    {
                        count += 22;
                    }
                    if (constant[i][j] == 'w')
                    {
                        count += 23;
                    }
                    if (constant[i][j] == 'x')
                    {
                        count += 24;
                    }
                    if (constant[i][j] == 'y')
                    {
                        count += 25;
                    }
                    if (constant[i][j] == 'z')
                    {
                        count += 26;
                    }
                }
                ranking.Add(count);
            }
            var max = ranking.Max();
            return max;
            
        }
        public static void GroupByCommas(int n)
        {
            var convert = n.ToString().Reverse().ToList();
            List<char> commas = new List<char>();
            if (convert.Count >= 4)
            {
                for (int i = 0; i < convert.Count; i++)
                {
                    if (i > 1 && i % 3 == 0)
                    {
                        commas.Add(',');
                    }
                    commas.Add(convert[i]);
                }
            }
            else
            {
                Console.WriteLine(n);
            }
            List<char> rev = new List<char>();
            for (int i = commas.Count - 1; i >= 0; i--)
            {
                rev.Add(commas[i]);
            }
            var joinIt = string.Join("", rev);
            Console.WriteLine(joinIt);
            
            

        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] answer = new int[2];
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j && numbers[i] + numbers[j] == target && count < 2)
                    {
                        answer[count] = i;
                        count++;
                        answer[count] = j;
                        count++;
                    }
                }
            }
            return answer;
        }
        public static int DeleteDigit(int n)
        {
            
            //List<string> parts = new List<string>();
            var convert = n.ToString();
            string[] parts = new string[convert.Length];
            for (int i = 0; i < convert.Length; i++)
            {
                parts[i] = (convert.Remove(i, 1));
            }
            int[] toNum = Array.ConvertAll(parts, int.Parse);
            var largest = toNum.Max();
            return largest;
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
        /*public static int SumDigits(int number)
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
        }*/



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
