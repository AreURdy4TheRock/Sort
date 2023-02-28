namespace NoName
{
    internal class Program
    {
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i+1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static int[] SortArrayAsc(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length;i++)
            {
                for (int j = i + 1;j< result.Length;j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }
        static int[] SortArrayDesc(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }
        static void SortArray(in int[] result, out int[] sortedasc, out int[] sorteddesc)
        {
            sortedasc = SortArrayAsc(result);
            foreach (int item in sortedasc)
            {
                Console.WriteLine(item);
            }
            sorteddesc = SortArrayDesc(result);
            foreach (int item in sorteddesc)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            var array = GetArrayFromConsole(10);
            SortArray(array, out int[] sortedasc, out int[] sorteddesc);  
            Console.ReadKey();
        }
    }
}