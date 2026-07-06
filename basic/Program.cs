using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise50
{
    public static void Main()
    {
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




    }
}
