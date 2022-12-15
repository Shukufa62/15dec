using System;

namespace _15_dec
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine(Sum(45,67));
            // Console.WriteLine(Square(5));
            // Console.WriteLine(HasA("kazim"));
            // Console.WriteLine(SumOfDigits(75));
            //  Console.WriteLine(Avr(8,72,90,126));
            //  Console.WriteLine(Pwr(5,2));
            //  Console.WriteLine(MaxNumber(38,39,37));
            
           

        }



        //Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
        //static int Sum(int num1,int num2)
        //{
        //  return num1 + num2;
        //}
        //Verilmiş ədədin kvadratını qaytaran metod
        //static int Square(int num)
        //{
        //   return num * num;

        //  }


        //Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod

        //static bool HasA(string str)
        //{
        //  for(int i=0;i<str.Length; i++)
        //{
        //  if (str[i]=='a'|| str[i]=='A')
        // {
        //    return true;
        //}

        // }
        //return false;
        //}


        // Verilmiş ədədin rəqəmləri cəmini qaytaran metod
        //static int SumOfDigits(int n)
        //{
        //  int sum = 0;
        // while(n>0)
        // {
        //   sum += n % 10;
        // n = (n - n % 10) / 10;
        //}
        //return sum;
        //}


        //Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod
        //static int Avr(int a,int b, int c, int d)
        //{
        // return (a + b + c + d) / 4;
        // }

        //Verilmiş ədədin verilmiş qüvvətini tapan metod
        // static int Pwr(int number,int power)
        //{
        //   int result = 1;
        // for(int i=0;i<power;i++)
        // {
        //     result *= number;
        // }
        //return result;
        // }


        // Verilmiş 3 ədəddən ən böyüyünü tapan metod
        //static int MaxNumber(int firsnum,int secondnum,int thirdnum)
        // {
        // if(firsnum>secondnum)
        //  {
        //   if(firsnum>thirdnum)
        //  {
        //    return firsnum;
        //}
        // else
        //{
        //  return thirdnum;
        //}

        // }
        //else if(secondnum>thirdnum)
        //  {
        //     return secondnum;
        // }
        //else
        //{

        //    return thirdnum;
        //}



        //  }


        //Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod

        // static int Sum(int[]number)
        // {
        //     int sumofarraynums = 0;
        //    for(int i=0;i<number.Length;i++)
        //    {
        //       sumofarraynums += number[i];
        //   }
        //    return sumofarraynums;
        // }


        //Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan metod
         static int FindBiggest(int[]number)
        {
         int max = number[0];
         for(int i=0;i<number.Length;i++)
        {
          if (number[i]>max)
           {
           max = number[i];

            }
         }
        return max;

        }

        //- Verilmiş yazılar siyahısındaki (string array) verilmiş
        //yazının yerləşdiyi indexi qaytaran metod.
        //Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın
        // static int FindIndex(string array,string word)
        //{
        // for(int i=0;i<array.Length;i++)
        //{
        //  if (array[i]==word)
        //{
        //  return i;
        //}

        //}
        //return -1;
        //}

        //Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət
        //olanlarından ibarət yeni bir array qaytaran metod.Yəni metodu işə salın {4,-5,3,-2,6} ədədlərindən i
        //barət array göndərsəm metod geriyə {4,3,6} ədədlərindən ibarət array qaytarmalıdır
        // static int[] FilterPositve(int[]numbers)
        //{
        //  int count = 0;
        //for(int i=0;i<numbers.Length;i++)
        //{
        //  if (numbers[i]>0)
        //{
        //  count++;
        //}
        //}
        //int j = 0;
        // int[]PositiveNumber = new int[count];
        // for(int i=0;i<numbers.Length;i++)
        //{
        //  if(numbers[i]>0)
        // {
        //PositiveNumber[j] = numbers[i];
        //j++;

        //  }
        // }
        // return PositiveNumber;

        //}

        //Verilmiş yazıda rəqəm olub olmadığını qaytaran metod
        //static int FindIndex(char[] arr, char chr)
        //{
        //  for (int i = 0; i < arr.Length; i++)
        // {
        //   if (chr == arr[i])
        //     return i;
        //}
        //return -1;
        // }
        // static bool IsDigit(char givenchar)
        // {
        //    char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //  return (FindIndex(digits, givenchar) != -1);




        // }
        //  static bool HasDigit(string word)
        // {
        //  for (int i = 0; i < word.Length; i++)

        // {
        //   if (IsDigit(word[i]))
        //      return true;
        // }
        // return false;
        // }
        //Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod
        static int FindFirstNonSpaceIndex(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    return i;
            }
            return -1;
        }
        // Verilmiş yazıdaki son boşluq olmayan index-i qaytaran metod
        static int FindFirstNonSpaceIndex1(string str)
        {
            for (int i = str.Length-1; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    return i;
            }
            return -1;
        }


        //Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
        static string TrimLeft(string str)
        {
            var startIndex = FindFirstNonSpaceIndex(str);
            string newStr = "";
            for (int i = startIndex; i < str.Length; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }
        static string Trimright(string str)
        {
            var startIndex = FindFirstNonSpaceIndex1(str);
            string newStr = "";
            for (int i = startIndex; i < str.Length; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }

    }
}

