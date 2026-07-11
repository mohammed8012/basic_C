using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise50
{
    //find the pair of adjacent elements
    static int MaxProduct(int[] arr)
    {
        int max = arr[0] * arr[1];

        for (int i = 1; i < arr.Length - 1; i++)
        {
            int product = arr[i] * arr[i + 1];

            if (product > max)
            {
                max = product;
            }
        }

        return max;
    }
    //palindrome
    static bool IsPalindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        /*1. Print Hello and Name

Write a C# Sharp program to print Hello and your name in a separate line.
Expected Output :
Hello: Alexandra Abramov*/
        Console.WriteLine("Hello: Alexandra Abramov");
        Console.WriteLine("-------------------------------------");
        /*2. Sum of Two Numbers

Write a C# Sharp program to print the sum of two numbers.*/
        int x=2; int y=3;
        int z = x + y;
        Console.WriteLine(z);
        Console.WriteLine("--------------------------------------------");
        /*3. Divide Two Numbers

Write a C# Sharp program to print the result of dividing two numbers.*/
        float s = 4 / 2;
        Console.WriteLine(s);
        Console.WriteLine("--------------------------------------------");
        /*4. Specified Operations Results

Write a C# Sharp program to print the results of the specified operations.-1 + 4 * 6
( 35+ 5 ) % 7
14 + -4 * 6 / 11
2 + 15 / 6 * 1 - 7 % 2
Expected Output:
23
5
12
3*/
        double result = -1 + 4 * 6;
        Console.WriteLine(result);
        double result1 = (35 + 5) % 7;
        Console.WriteLine(result1);
        double result2 = 14 + -4 * 6 / 11;
        Console.WriteLine(result2);
        double result3 = 2 + 15 / 6 * 1 - 7 % 2;
        Console.WriteLine(result3);
        
        Console.WriteLine("-------------------------------");
        /*5. Swap Two Numbers

Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5*/
        int first = 5; int second=6;
        (first,second)=(second,first);
        //Another way
        int tm = first;
        first= second;
        second = tm;
        Console.WriteLine($"After Swapping :\nFirst Number : {first}\nSecond Number : {second}");
        Console.WriteLine("-----------------------------------");
        /*6. Multiply Three Numbers

Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36*/
        int a = 2; int b = 3; int c = 6;
        int result4 = a * b * c;
        Console.WriteLine(result4);
        Console.WriteLine("-----------------------------------");
        /*7. Arithmetic Operations

Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1*/
        var num1= 25;  var num2 = 4;
        var r1=num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {r1}");
        var r2 = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {r2}");
        var r3 = num1 * num2;
        Console.WriteLine($"{num1} x {num2} = {r3}");
        var r4 = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {r4}");
        var r5 = num1 % num2;
        Console.WriteLine($"{num1} mod {num2} = {r5}");
        Console.WriteLine("-----------------------------------");
        /*8. Multiplication Table

Write a C# Sharp program that prints the multiplication table of a number as input.
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50*/
        int number = 5;
        for (int i = 0; i <= 10; i++)
        {
            int result5 = number * i;
            Console.WriteLine($"{number} * {i} = {result5}");
        }
        Console.WriteLine("-----------------------------------");
        /*9. Average of Four Numbers

Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18*/
        int numA = 10; int numB = 15; int numC = 20; int numD = 30;
        int average = (numA + numB + numC + numD) / 4;
        Console.WriteLine($"The average of {numA} , {numB} , {numC} , {numD} is: {average}");
        Console.WriteLine("-------------------------------------");
        /*10. Specified Formula with Three Numbers

Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7

Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72*/
        var numa = 5; var numb= 6;
        var numc = 7;
        Console.WriteLine($"(x+y).z is {(numa + numb) * numc} and x.y + y.z is {numa * numb + numb * numc}");
        Console.WriteLine("-----------------------------------");
        /*Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
Test Data:
Enter your age - 25
Expected Output:
You look older than 25*/
        Console.WriteLine("Enter your age");
        var age=Console.ReadLine();
        Console.WriteLine($"You look older than{age}");
        Console.WriteLine("----------------------------------------------");
        /*12. Repeat Number in Rows

Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.
Test Data:
Enter a digit: 25
Expected Output:
25 25 25 25
25252525
25 25 25 25
25252525*/
        int digit = 25;
        Console.WriteLine("{0} {0} {0} {0}", digit);
        Console.WriteLine("{0}{0}{0}{0}", digit);
        Console.WriteLine($"{digit}{digit}{digit}{digit}");
        Console.WriteLine($"{digit} {digit} {digit} {digit}");
        Console.WriteLine("-----------------------------------");
        /*13. Rectangle Pattern with Number

Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
Test Data:
Enter a number: 5
Expected Output:
555
5 5
5 5
5 5
555*/
        int f = 5;
        Console.WriteLine("{0}{0}{0}", f);
        Console.WriteLine("{0} {0}", f);
        Console.WriteLine("{0} {0}", f);
        Console.WriteLine("{0}{0}{0}", f);
        Console.WriteLine("-----------------------------------");
        /*14. Celsius to Kelvin and Fahrenheit

Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
Test Data:
Enter the amount of celsius: 30
Expected Output:
Kelvin = 303
Fahrenheit = 86*/
        int celsius = 30;
        double kelvin = celsius + 273.15;
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Kelvin = {kelvin}");
        Console.WriteLine($"Fahrenheit = {fahrenheit}");
        Console.WriteLine("-----------------------------------");
        /*15. Remove Character by Index

Write a C# program that removes a specified character from a non-empty string using the index of a character.
Test Data:
w3resource
Sample Output:
wresource
w3resourc
3resource*/
        string name= "w3resource";
        Console.WriteLine(name);

        Console.WriteLine(name.Remove(1, 2));
        Console.WriteLine(name.Remove(9, 1));
        Console.WriteLine(name.Remove(0, 1));
        Console.WriteLine("-----------------------------------");
        /*16. Swap First and Last Characters

Write a C# program to create a new string from a given string where the first and last characters change their positions.
Test Data:
w3resource
Python
Sample Output:
e3resourcw
nythoP
x*/
        string str1 = "w3resource";
        string str2 = "Python";

        char[] chars= str1.ToCharArray();
        char tempChar = chars[0];
        chars[0] = chars[chars.Length - 1];
        chars[chars.Length - 1] = tempChar;

        char[] chars2 = str2.ToCharArray();
        char tempChar2 = chars2[0];
        chars2[0] = chars2[chars2.Length - 1];
        chars2[chars2.Length - 1] =tempChar2;
        Console.WriteLine(new string(chars));
        Console.WriteLine(new string(chars2));
        Console.WriteLine("-----------------------------------");
        /*17. Add First Character to Front and Back

Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog.
TThe quick brown fox jumps over the lazy dog.T*/
        string inputString = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(inputString);
        char firstChar = inputString[0];
        string newString = firstChar + inputString + firstChar;
        Console.WriteLine($"{firstChar}{inputString}{firstChar}");
        Console.WriteLine("-----------------------------------");
        /*18. Check Positive and Negative Pair

Write a C# program to check a pair of integers and return true if one is negative and one is positive.
Sample Output:
Input first integer:
-5
Input second integer:
25
Check if one is negative and one is positive:
True*/
        int num5 = -5;
        int num25 = 25;
        bool resalt10 = (num5 < 0 && num25 > 0) || (num5 > 0 && num25 < 0);
        Console.WriteLine($"Check if one is negative and one is positive: {resalt10}");
        Console.WriteLine("-----------------------------------");
        /*19. Sum or Triple Sum of Integers

Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.*/

        Console.WriteLine("Enter two integers:");
        int numA1 =Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter second integer:");
        int numB1 = Int32.Parse(Console.ReadLine());
        int sumOrTriple = numA1 == numB1 ? (numA1 + numB1) * 3 : numA1 + numB1;
        Console.WriteLine($"Sum or Triple Sum: {sumOrTriple}");
        Console.WriteLine("-----------------------------------");
        /*20. Absolute Difference or Double It

Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than the second number.*/































        /*
         Write a C# program to rotate an array (length 3) of integers in the left direction.
Test Data:
Array1: [1, 2, 8]
After rotating array becomes: [2, 8, 1]
         */
        int[] arr = { 1, 2, 8 };

        var temp = arr[0]; 

        for (var i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1]; 
        }

        arr[arr.Length - 1] = temp;

        Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", arr));
        Console.WriteLine("-----------------------------------");
        /*
         Write a C# program to get the largest value between the first and last element of an array (length 3) of integers.
Test Data:
Array1: [1, 2, 5, 7, 8]
Highest value between first and last values of the said array: 8
         */
        int[] arr1 = { 1, 2, 5, 7, 8 };
        var temp1 = arr[0];
        for (var i = 0; i <arr1.Length; i++)
        {
            if (arr1[i] > arr1[0])
            {
                temp1 = arr1[i];
            }


        }
        Console.WriteLine($"Highest value between first and last values of the said array: 8",temp1);
        Console.WriteLine("-----------------------------------");
        /*
         Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
Test Data:
Array1: [1, 2, 5]
Array2: [0, 3, 8]
Array3: [-1, 0, 2]
New array: [2, 3, 0]
         */
        int[] Array1 = { 1, 2, 5 };
        int[] Array2 = { 0, 3, 8 };
        int[] Array3 = { -1, 0, 2 };
        int[] new_array = { Array1[1], Array2[1], Array3[1] };
        Console.WriteLine(string.Join(",", new_array));
        Console.WriteLine("-----------------------------------");
        /*Write a C# program to check if an array contains an odd number.
Test Data:
Original array: [2, 4, 7, 8, 6]
Check if an array contains an odd number? True*/
        int[] array = { 2, 4, 7, 8, 6 };
        bool vodd = false;
        foreach (var i in array)
        {
            if (i % 2 != 0)
            {
                vodd = true;
                break;
            }
            
        }
        Console.WriteLine($"Check if an array con tains an odd number?{vodd}");
        Console.WriteLine("------------------------------------");
        /*Find Century of Year

Write a C# program to get the century of a year*/

        int year = 1900;
        int century = (year + 99) / 100;
        Console.WriteLine($"The century of the year {year} is: {century}");
        Console.WriteLine("------------------------------------");
        /*Max Product of Adjacent Elements

Write a C# program to find the pair of adjacent elements that has the largest product of the given array.*/
        //The main function is above.

        int[] arr4 = { 3, 6, -2, -5, 7, 3 };

        Console.WriteLine(MaxProduct(arr));
        Console.WriteLine("------------------------------------");
        /*Check Palindrome String

Write a C# program to check if a given string is a palindrome or not.*/
        //The main function is above.
        Console.WriteLine(IsPalindrome("aba"));
        Console.WriteLine(IsPalindrome("abcd"));
        Console.WriteLine("------------------------------------");
        /*57. Max Product of Adjacent Integers

Write a C# program to find the pair of adjacent elements that has the highest product of an array of integers.*/



    }
}
