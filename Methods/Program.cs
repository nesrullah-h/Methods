using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)

        //task   1

        {
            int answer = number(20, 9);
        Console.WriteLine(answer);
        }

    #region methods
    static int number(int num1, int num2)
    {
        return num1 / num2;
    }


    #endregion






    //task     2   

    //{
    //   Repeat("ha!", 4);
    //}
    //#region repeat
    //static void Repeat(string word , int count)
    //{
    //    for (int i = 0; i < count; i++)
    //    {
    //        Console.Write(word); 

    //    }

    //}
    //#endregion







    //task   3

    //{
    //    int[] arr = { 5, 9, 7, 5 };
    //    Console.WriteLine(Sum(arr));
    //}
    //static int Sum(int[] arr)
    //{
    //    int sum = 0;
    //    for (int i = 0; i < arr.Length; i++) 
    //    { 
    //        sum += arr[i];
    //    }
    //    return sum;
    //}





    //task   4

    //{
    //    int cevre = Sahec(4, 2);
    //    Console.WriteLine($"Cevrenin Sahesi-{cevre}");

    //    int duzbucaqli = Sahed(5, 6);
    //    Console.WriteLine($"Duzbucaqlinin Sahesi-{ duzbucaqli}");

    //}
    //static int Sahec(int p, int r)
    //{
    //    p = 3;
    //    return p * r * r;
    //}

    //static int Sahed(int a, int b)
    //{
    //    return a * b;

    //}















}
}
