namespace EvTapshirigi2
{
    internal class Program
    {
        static void Main(string[] args)
        {   //5-e bolunen 7-e bolunmeyen
            
            Console.Write("Massivin uzunlugunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 5 == 0 && arr[i] % 7 != 0)

                    Console.WriteLine(arr[i]);
            }
        }
    }
}
