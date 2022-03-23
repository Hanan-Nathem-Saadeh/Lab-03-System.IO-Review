using System;
using System.IO;
namespace Lab_03_System.IO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("*********** Welcom To Lab-03-System I/O **********");
                Console.WriteLine("**************************************************");

                string SNumbers = GetArrForChallenge1();
                Console.WriteLine("The product of the First 3 numbers is: " + MultiplyNumbers(SNumbers));
                Console.WriteLine("*************************************************************");

                int[] ArrForChallenge2 = GetArrForChallenge2();
                Console.WriteLine("The average of these numbers is: " + GetAverage(ArrForChallenge2));
                Console.WriteLine("*************************************************************");

                PrintStars();
                Console.WriteLine();
                Console.WriteLine("*************************************************************");


                int[] IntegerArray = GetArrForChallenge4();
                Console.WriteLine("The number that appears most times is : " + RepeatedNumber(IntegerArray));
                Console.WriteLine("*************************************************************");

                int[] IntegerArray1 = GetArrForChallenge5();

                Console.WriteLine("The maximum value in the array is : " + FindMaximumValue(IntegerArray1));
                Console.WriteLine("*************************************************************");

                InputWord();
                Console.WriteLine("*************************************************************");
                ReadWord();
                Console.WriteLine("*************************************************************");

                RemoveWord();
                Console.WriteLine("*************************************************************");

                Console.WriteLine("*************************************************************");

                NumberOfCharacters(InsertSentence());
                Console.WriteLine("*************************************************************");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        //Challenge1
        public static string GetArrForChallenge1()
        {

            Console.WriteLine("Please Insert 3 Numbers with spaces To multiply .... ");
            string SNumbers = Console.ReadLine();
            return SNumbers;
        }
        public static int MultiplyNumbers(string SNumbers)
        {

            string[] Numbers = SNumbers.Split(' ');
            if (Numbers.Length < 3)
            {
                return 0;
            }
            else
            {
                try
                {

                    int product = 1;
                    int theNumber;
                    for (int i = 0; i < 3; i++)
                    {
                        if (int.TryParse(Numbers[i], out theNumber))
                        {
                            product = product * Convert.ToInt32(Numbers[i]);
                        }
                        else
                        {
                            product = product * 1;
                        }

                    }
                    return product;
                }
                catch (Exception e)

                {
                    Console.WriteLine(e);
                    return 0;
                }



            }


        }
        //Challenge2
        public static int[] GetArrForChallenge2()
        {
            try
            {
                Console.WriteLine("Kindly , insert a number  between 2-10 to find the Average ");
                int num = Convert.ToInt32(Console.ReadLine());
                while (num < 2 || num > 10)

                {
                    Console.WriteLine("you insert a number not between 2-10 Please try again ...");
                    num = Convert.ToInt32(Console.ReadLine());
                }


                int[] array = new int[num];
                for (int i = 1; i <= num; i++)
                {
                    Console.Write(i + " of " + num + " - Enter a number: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x < 0)
                    {
                        Console.WriteLine("It is not allowed to insert a negative number .. Please try again..");
                        Console.Write(i + " of " + num + " - Enter a number: ");
                        x = Convert.ToInt32(Console.ReadLine());
                    }
                    array[i - 1] = x;
                }
                return array;
            }
            catch (Exception)
            {
                throw new Exception("That was not a number you entered.");

            }
        }
        public static int GetAverage(int[] ArrForChallenge2)
        {
            int num = 0;
            int sum = 0;
            int avg = 0;
            num = ArrForChallenge2.Length;
            for (int i = 0; i < ArrForChallenge2.Length; i++)
            {
                sum = sum + ArrForChallenge2[i];
            }
            avg = sum / num;
            return avg;


        }
        //Challenge3
        public static void PrintStars()
        {

            int number, i, k, count = 1;
            number = 5;
            count = number - 1;
            Console.Write("  ");
            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++)

                    Console.Write("*");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("  ");

            }
            count = 1;
            for (k = 1; k <= number - 1; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("  ");

            }
            Console.ReadLine();

        }
        //Challenge4
        public static int[] GetArrForChallenge4()
        {
            Console.WriteLine("Kindly..insert integer numbers you want..to find the number apears most time...");
            string SNumbers = Console.ReadLine();
            string[] Numbers2 = SNumbers.Split(' ');
            int[] IntegerArray = new int[Numbers2.Length];
            for (int i = 0; i < IntegerArray.Length; i++)
            {
                IntegerArray[i] = Convert.ToInt32(Numbers2[i]);

            }
            return IntegerArray;
        }
        public static int RepeatedNumber(int[] IntegerArray)
        {

            int count = 0;
            int Number;
            int CCount;
            int FCount = 0;

            for (int i = 0; i < IntegerArray.Length; i++)
            {
                Number = IntegerArray[i];
                CCount = 1;


                for (int j = i + 1; j < IntegerArray.Length; j++)
                {
                    if (IntegerArray[j] == Number)
                    {
                        CCount++;
                    }
                }
                if (CCount > count)
                {
                    FCount = Number;
                    count = CCount;
                }
            }
            return FCount;


        }
        //Challenge5
        public static int[] GetArrForChallenge5()
        {
            Console.WriteLine("Kindly..insert integer numbers you want..to find the maximum value");
            string SNumbers = Console.ReadLine();
            string[] Numbers2 = SNumbers.Split(' ');
            int[] IntegerArray = new int[Numbers2.Length];
            for (int i = 0; i < IntegerArray.Length; i++)
            {
                IntegerArray[i] = Convert.ToInt32(Numbers2[i]);

            }
            return IntegerArray;
        }

        public static int FindMaximumValue(int[] IntegerArray1)
        {
            int max = -1000000000;
            for (int i = 0; i < IntegerArray1.Length; i++)
            {
                if (max < IntegerArray1[i])
                { max = IntegerArray1[i]; }
            }

            return max;
        }
        //Challenge6

        public static void InputWord()
        {
            Console.WriteLine("Kindly .... Insert a word to save it in a file : ");
            string word = Console.ReadLine();
            string path = "words.txt";

            {
                if (File.Exists(path))
                {
                    File.AppendAllText(path, word + Environment.NewLine);
                }
            }
        }




    //Challenge7
    public static void ReadWord()
        {
            string path = "words.txt";
            String[] fileContent = File.ReadAllLines(path);
            for (int i = 0; i < fileContent.Length; i++)
            { Console.WriteLine(fileContent[i]); }

        }
        //Challenge8
        public static void RemoveWord()
        {

            string path = "words.txt";
            string Contant = File.ReadAllText(path);


            string Word = Contant.Substring(0, Contant.IndexOf(" "));
            string newText = Contant.Remove(0, Word.Length + 1);
            Console.WriteLine("The contant after deleting the first word : \n" + newText);
            //write the contant after delete
            File.WriteAllText(path, newText);
            //write the contant before delete
            //File.WriteAllText(path, Contant);

        }
        //Challenge9
        public static string InsertSentence()
        {
            Console.WriteLine("Kindly...Insert a sentence ");
            string sentence = Console.ReadLine();
            return sentence;
        }

        public static void NumberOfCharacters(string sentence)
        {

            string[] WordSentence = sentence.Split(" ");
            string[] ArrString = new string[WordSentence.Length];
            for (int i = 0; i < WordSentence.Length; i++)
            {
                ArrString[i] = $"{WordSentence[i]}: {WordSentence[i].Length}, ";
                Console.Write(ArrString[i]);
            }
            Console.WriteLine();

        }



    }

}
