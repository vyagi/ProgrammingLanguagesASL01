using System.Collections.Generic;

namespace BasicStructures
{
    public static class ArrayUtils
    {
        public static int[] Accumulate(int[] inputArray)
        {
            var array = new int[inputArray.Length];
            
            array[0] = inputArray[0];
            
            for (var i = 1; i < inputArray.Length; i++) 
                array[i] = array[i - 1] + inputArray[i];

            return array;
        }

        public static int[] Zip(int[] arr1, int[] arr2)
        {
            var length = arr1.Length < arr2.Length
                ? arr1.Length
                : arr2.Length;

            var newArray = new int[length];

            for (var i = 0; i < length; i++) 
                newArray[i] = arr1[i] + arr2[i];

            return newArray;
        }

        public static int[] PickPositive(int[] inputArray) => Round(inputArray, 1);

        public static int[] Round(int[] inputArray, int threshold)
        {
            var result = new List<int>();

            foreach (var element in inputArray)
                if (element >= threshold)
                    result.Add(element);

            return result.ToArray();
        }

        public static int[] Reverse2(int[] inputArray)
        {
            var result = new int[inputArray.Length];
            
            for (var i = 0; i < inputArray.Length; i++) 
                result[inputArray.Length - 1 - i] = inputArray[i];

            return result;
        }

        public static void Reverse1(int[] inputArray)
        {                                               
            for (var i = 0; i < inputArray.Length / 2; i++)
            {
                var temp = inputArray[i];
                inputArray[i] = inputArray[inputArray.Length - 1 - i];
                inputArray[inputArray.Length - 1 - i] = temp;
            }
        }
    }
}
