namespace menor_distancia_array
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var arr2 = new List<int>() { 1, 2, 3 };
            var arr1 = new List<int>() { 10, 20, 30 };
            MenorDistancia(arr1, arr2);
        }

        private static void MenorDistancia(List<int> array1, List<int> array2)
        {
            while (true)
            {
                var maxArray1 = ObterValorMaximo(array1);

                var minArray2 = int.MaxValue;
                minArray2 = ObterValorMinimo(array2, maxArray1, minArray2);

                if (minArray2 != int.MaxValue)
                {
                    Console.WriteLine(minArray2 - maxArray1);
                }
                else
                {
                    TrocarArrays(ref array1, ref array2);
                    continue;
                }

                break;
            }
        }

        private static int ObterValorMinimo(List<int> array2, int maxArray1, int minArray2)
        {
            foreach (var num in array2)
            {
                if (num > maxArray1 && num < minArray2)
                {
                    minArray2 = num;
                }
            }

            return minArray2;
        }

        private static int ObterValorMaximo(List<int> array)
        {
            var max = int.MinValue;
            foreach (var num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        private static void TrocarArrays(ref List<int> array1, ref List<int> array2)
        {
            (array1, array2) = (array2, array1);
        }
    }
}