namespace Lab1.Files
{
    public class ArrayFunctions
    {
        public void ReverseArr(int[] arr)
        {
            ArgumentNullException.ThrowIfNull(arr);

            int i = 0, j = arr.Length - 1;
            while (i < j)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
                ++i;
                --j;
            }
            PrintArr(arr);
        }

        private static void PrintArr(int[] arr)
        {
            foreach(var x in arr)
            {
                Console.Write(x+" ");
            }
        }
    }
}