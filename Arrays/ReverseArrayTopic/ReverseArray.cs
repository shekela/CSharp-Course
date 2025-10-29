using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.ReverseArrayTopic
{
    public static class ReverseArray
    {
        public static void Main()
        {
            int[] testArray = { 1, 2, 3, 4, 5 };

            var reversedArrayWithForLoop = ReverseArrayInPlace(testArray);

            for (int i = 0; i < reversedArrayWithForLoop.Length; i++)
            {
                Console.Write(reversedArrayWithForLoop[i] + " "); //Expected output: 5 4 3 2 1
            }
            Console.ReadKey();
        }


        // Reverse array with for loop (slower and memory taking version)
        public static int[] ReverseArrayWithForLoop(int[] array)
        {
            int[] tempArray = new int[array.Length]; //Initialise new empty array size of passed array
            for (int i = 0; i < array.Length; i++)
            {
                // We fill in empty array step by step from the end of passed array 
                // array is 0 indexed so we need to fill in array.Length - 1 and then - i(index of the number in loop)
                tempArray[i] = array[array.Length - 1 - i];
            }

            return tempArray; //Return the reversed array
        }

        // Reverse array in place (faster and memory efficient version) we change from right to left 
        // which make performance better, faster and memory efficient


        public static int[] ReverseArrayInPlace(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            // Step 1: We have array: 1(indx 0) , 2(indx 1), 3(indx 2), 4(indx 3), 5(indx 4)
            // Step 2: We need to bring 5 to (indx 0) at the place of 1 | We cannot leave (indx 4)place of 5 empty so at the same time to bring 1 at index 4
            // so for this we need to bring new variable which will hold 1 at (indx 0) temporarly before replacing it with 5
            // Step 3: To make it short we are replacing number till the middle of array because we at the same time also filling the second part of array after 50%
            while (left < right)
            {
                int temp = array[left]; // Temporary variable which holds our number which needs to be replaced for a while
                array[left] = array[right];// We can confidently replace number already
                array[right] = temp; // Since we reverse array lets bring the saved temporary number to the last place
                left++; // To make array moving
                right--; // Because we fill up mirrored indexes we need array to also limit by 1 each loop
            }

            return array;
        }
    }
}


