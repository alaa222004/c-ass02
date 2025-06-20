using System;
using System.ComponentModel;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1

            //Write a program that allows the user to enter a number then print it.
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            #endregion

            #region q2
            //Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            string x = "123";
            Console.WriteLine(int.Parse(x));


            #endregion

            #region q3
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            float num1 = 3.6f;
            float num2 = 5.5f;
            float num3 = num1 + num2;
            Console.WriteLine(num3);


            #endregion

            #region q4
            //Write C# program that Extract a substring from a given string.
            string n = "alaasamir";
           string part= n.Substring(5,2);
           Console.WriteLine(part);

            #endregion

            #region q5

            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            int value1 = 9;
            int value2 = 10;
            value1 = value2;
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            #endregion
            #region q6
            //rite C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
//!!!



            #endregion

            #region q7


            //Write C# program that take two string variables and print them as one variable 

            string nam1 = "alaa";
            string nam2 = "samir";
            Console.WriteLine(string.Format("{0} {1}", nam1, nam2));
            #endregion
        }
        #region q8
        //        Which of the following statements is correct about the C#.NET code snippet given below?
        //        int d;
        //        d = Convert.ToInt32( !(30 < 20) );

        //ans:A value 1 will be assigned to d.



        #endregion
        #region q9
        //        Which of the following is the correct output for the C# code given below?
        //          Console.WriteLine(13 / 2 + " " + 13 % 2); 

        //ans:6 1

        #endregion
        #region q10
        //10-What will be the output of the C# code given below?
        //int num = 1, z = 5;
        //if (!(num <= 0))
        //    Console.WriteLine( ++num + z++ + " " + ++z ); 
        //else
        //    Console.WriteLine( --num + z-- + " " + --z ); 

        //ans:7 7
        #endregion


    }
}


