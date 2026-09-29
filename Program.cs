/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            *//*  //operatores
              int num1 = 10;
              int num2 = 20;
              //arithimetic operators
              Console.WriteLine(num1 + num2);
              Console.WriteLine(num1 - num2);
              Console.WriteLine(num1 * num2);
              Console.WriteLine(num1 / num2);
              Console.WriteLine(num1 % num2);

              // assignment operators
              Console.WriteLine(num1 += 5);
              Console.WriteLine(num1 -= 5);
              Console.WriteLine(num1 *= 10);
              Console.WriteLine(num1 /= 10);
              Console.WriteLine(num1 %= 10);

              //comparsion operators
              int a = 10;
              int b = 20;

              Console.WriteLine(a == b);
              Console.WriteLine(a != b);
              Console.WriteLine(a > b);
              Console.WriteLine(a < b);
              Console.WriteLine(a >= b);
              Console.WriteLine(a <= b);
              // logical operators
              int age = 22;
              bool hasId = true;

              Console.WriteLine(age >= 18 && hasId);
              Console.WriteLine(age < 18 || hasId);
              Console.WriteLine(!hasId);
              // unary operstors
              int A = 10;

              A++;

              Console.WriteLine(A);
              // ternary operator
              int person_age = 20;

              string result = person_age >= 18 ? "Eligible" : "Not Eligible";

              Console.WriteLine(result);
              //string operator
              string firstName = "Santhosh";
              string lastName = "Ponnusamy";

              // Concatenation
              string fullName = firstName + " " + lastName;
              Console.WriteLine(fullName);

              // Interpolation
              Console.WriteLine($"My name is {firstName}");

              // Length
              Console.WriteLine(firstName.Length);

              // Substring
              Console.WriteLine(firstName.Substring(0, 4));

              // Replace
              Console.WriteLine(firstName.Replace("Santhosh", "Sanjay"));

              // Trim
              string name = "   Santhosh   ";
              Console.WriteLine(name.Trim());

              // Compare
              Console.WriteLine(string.Compare("Hello", "Hello"));
              //typecasting
              int num = 100;
              double bigNum = num;
              Console.WriteLine("int value:" + num);
              Console.WriteLine($"int value:{num}");
              Console.WriteLine("convert double :" + bigNum);

              double doubleValue = 123.456;
              int intValue = (int)doubleValue;
              Console.WriteLine("int Value :" + intValue);
              Console.WriteLine("double value:" + doubleValue);

              string strNumber = "230";
              int convertedInt = Convert.ToInt32(strNumber);
              double convertedDouble = Convert.ToDouble(strNumber);
              Console.WriteLine(strNumber);

              string strFloat = "12.34";
              double parseDouble = double.Parse(strFloat);
              Console.WriteLine(strFloat);

              // loop conditions

              for (int i = 1; i <= 5; i++)
              {
                  Console.WriteLine(i);
              }

              string[] names = { "Santhosh", "Arun", "Kumar" };

              foreach (string name_1 in names)
              {
                  Console.WriteLine(name_1);
              }
              for (int i = 1; i <= 10; i++)
              {
                  if (i % 2 == 0)
                  {
                      Console.WriteLine(i);
                  }
              }

          }*//*
        }


    }
}
    

*/
using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a = 10;
                int b = 0;

                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException: " + ex.Message);
            }



            try
            {
                int[] numbers = { 10, 20, 30, 40, 60 };

                Console.WriteLine(numbers[6]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
            }



            try
            {
                string name = null;

                Console.WriteLine(name.ToUpper());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException: " + ex.Message);
            }



            try
            {
                object value = "Ravi";

                int number = (int)value;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("InvalidCastException: " + ex.Message);
            }



            try
            {
                string data = File.ReadAllText("newfile.txt");

                Console.WriteLine(data);
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOException: " + ex.Message);
            }



            try
            {
                string[] names = new string[2];

                object[] objects = names;

                objects[0] = 1000;
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine("ArrayTypeMismatchException: " + ex.Message);
            }


            Console.WriteLine("\nProgram completed.");
        }
    }
}