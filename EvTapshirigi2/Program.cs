namespace EvTapshirigi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 15, 25, 35, 55, 78, 90, 12, 74 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 5 == 0 && arr[i] % 7 != 0)
                    Console.WriteLine(arr[i]);

            }
        }
    }
}