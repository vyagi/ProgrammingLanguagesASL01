using System.Collections.Generic;

namespace BasicStructures
{
    public static class ArrayUtils
    {
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
