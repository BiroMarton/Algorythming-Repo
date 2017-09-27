using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorythmingApp
{
    class Program
    {

        public string ReverseString(string input)
        {
            Stack<string> lettersStack = new Stack<string>();
            char[] characters = input.ToCharArray();
            string result = "";
            foreach (char i in characters)
            {
                lettersStack.Push(i.ToString());

            }

            while (lettersStack.Count > 0)
            {
                result += lettersStack.Pop();
            }

           
            return result;
        }

        public long FactorizeNumber(int num)
        {
            
            long result = 1;

            for( int i =1 ; i < num+1; i++)
            {
                result = result * i;

            }
            return result;



        }

        public bool IsPalindrome(string input)
        {
            input = input.ToLower().Replace(" ",String.Empty);
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            input = rgx.Replace(input, "");
            char[] chars = input.ToCharArray();
            string compareString = "";
            for (int i = chars.Length-1; i > chars.Length/2-1; i--)
            {
                compareString += chars[i];
            }
            if (compareString == input.Substring(0, input.Length / 2))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int LongestWord(string input)
        {
            int count = 0;
            string[] words = input.Split(' ');
            foreach (string s in words)
            {
                if (s.Length > count)
                {
                    count = s.Length;
                }

                
            }
            return count;
            

        }

        public string Capitalize(string input)
        {
            string result = "";
            string[] words = input.Split(' ');
            foreach (string s in words)
            {
                char[] chars = s.ToCharArray();
                chars[0] = Char.ToUpper(chars[0]);
                foreach (char c in chars)
                {
                    result += c;
                }
                result += " ";

            }
            return result.Trim();
        }

        public List<int> LargestNumbers(int[,] arr)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                int num = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (arr[i, j] > num)
                    {
                        num = arr[i, j];
                    }
                    
                }
                result.Add(num);
            }


            return result;
        }

        public bool ConfirmEnding(string input, string check)
        {
            if (input.Substring(input.Length - check.Length) == check)
            {
                return true;
            }
            return false;
        }

        public string RepeatString(string input, int num)
        {
            string result = "";
            if (num < 0)
            {
                return result;
            }

            for (int i = 0; i < num; i++)
            {
                result += input;
            }
            return result;
        }

        public string Turncate(string input, int length)
        {
            string result = "";
            if (length <= 3)
            {
                result += input.Substring(0, length) + "...";
            }
            else if (input.Length > length)
            {
                result += input.Substring(0, length - 3) + "...";
            }
            return result;
        }

        public T[,] ChunkMonkey<T>(T[] arr, int split)
        {
            T[,] resultArr;
            int counter = 0;
            int counter2 = 0;
            if (arr.Count() % split == 0)
            {
                resultArr = new T[arr.Count() / split, split];
            }
            else
            {
                resultArr = new T[arr.Count() / split +1, split];

            }
            for (int i = 0; i < arr.Count(); i++)
            {
                resultArr[counter,counter2] = arr[i];
                counter2++;
                if (counter2 == split)
                {
                    counter++;
                    counter2 = 0;
                }
                
            }

            return resultArr;

        }

        public static void Print2DArray<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintOutArray<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.Write(item.ToString() + " ");
            }
        }

        public T[] Slasher<T>(T[] list, int num)
        {
            T[] result;
            if (num > list.Count())
            {
                return result = new T[0];
            }
            result = new T[list.Count() - num];
            for (int i = 0; i < result.Count(); i++)
            {
                result[i] = list[i + num];

            }
            return result;

        }

        static void Main(string[] args)
        {
            int[,] myArr = new int[4, 4] { { 4, 5, 1, 3 }, { 13, 24, 18, 26 }, { 32, 35, 37, 39 }, { 1000, 1001, 857, 1 } };
            string[] myStrArr = new string[] {"a","b","c","d","e","f","g" };
            int[] myIntArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
           Program p = new Program();

            Console.WriteLine(p.ReverseString("1234567890"));

            Console.WriteLine(p.FactorizeNumber(5).ToString());

            Console.WriteLine(p.IsPalindrome("My age is 0, 0 si ega ym."));

            Console.WriteLine(p.LongestWord("How do I remove all non alphanumeric characters from a string except dash and space characters?"));

            Console.WriteLine(p.Capitalize("union of soviet socialist republics"));

            for (int j = 0; j < 4; j++)
            { Console.WriteLine(p.LargestNumbers(myArr)[j]); }
            
            Console.WriteLine(p.ConfirmEnding(" Meet Aspen the mountain pup, a 4-year-old Golden Retriever who is all about enjoying the fresh air and exploring the world's natural wonder", "der"));

            Console.WriteLine(p.RepeatString("Abc", 6));

            Console.WriteLine(p.Turncate("Kiskutya, nagykutya nem ugat hiába.",11));

            Print2DArray(p.ChunkMonkey(myStrArr,2));

            PrintOutArray(p.Slasher(myIntArr, 2));

            Console.ReadKey();

              
 

        }

       
    }
}
