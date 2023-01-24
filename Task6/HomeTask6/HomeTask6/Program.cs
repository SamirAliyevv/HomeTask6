using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace HomeTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string word = "Kitab";
            //    Console.WriteLine(CheckNumber(word));
            //string fullname = "Samir Aliyev";

            //Console.WriteLine(CheckName(fullname));
            //int[] numbers = { 2, 3, 3, 4, 5, 6, 7, 7, 8 };
            //var result = NumberArray(numbers);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);

            //}
            string[] gmail = { "samirsa@code.edu.az", "samirsa@coe.edu.az", "nuruhuseynov@gmail.com", "bahruzrehimov@gmail.com", "samirsa@mail.ru" };

            Console.WriteLine();
        }
        #region
        //static bool CheckNumber(string word)
        //{
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (char.IsDigit(word[i]))
        //        {
        //            return true;    
        //        }


        //    }
        //    return false;
        //}


        //static bool IsName (string name)
        //{
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        return false;
        //    }
        //    if (!char.IsUpper(name[0]))
        //    {
        //        return false;

        //    }
        //    for (int i = 1; i < name.Length; i++)
        //    {
        //        if (!char.IsLower(name[i]))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}   



        //static bool CheckName (string name)
        //{  
        //  name=name.Trim ();
        //  var arr =name.Split(' ');
        //  if (IsName(arr[0]) && IsName(arr[1]))
        //  {
        //      return true;
        //  }
        //  return false;


        //}
        #endregion
        //static int[]  NumberArray ( int[] arr)
        //{

        //    int[] num = new int[0];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (Array.IndexOf(num, arr[i]) == -1)
        //        {
        //            Array.Resize( ref num, num.Length+1);
        //            num[num.Length - 1] = arr[i];   
        //        }


        //    }return num; 


    }

       static string[] GetDomain(string[] arr)
       {
        string[] newArr = new string[arr.Length];


        for (int i = 0; i < arr.Length; i++)
        {
            var result = arr[i].Substring(arr[i].IndexOf('@') + 1);
            newArr[i] = result;
        }
        return newArr;
       
       }

          static string[] MakeDomain(string[] arr)
        {
           string [] newMassiv = new string[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(newMassiv, arr[i]) == -1)
                {
                   Array.Resize(ref newMassiv, newMassiv.Length + 1);
                   newMassiv[newMassiv.Length - 1] = arr[i];


                }

            
             
            } 
              return newMassiv;

        }


    

}   


