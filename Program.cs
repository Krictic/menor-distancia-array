namespace menor_distancia_array
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var arr2 = new List<int>() { 1, 2, 2, 3, 3, 3, 6 };
            var arr1 = new List<int>() { 10, 10, 20, 30, 30, 30 };
            MenorDistancia(arr1, arr2);
        }

        /// <summary>
        /// Função para encontrar a menor distância entre os valores de array1 e array2.
        /// </summary>
        /// <param name="array1">O primeiro array.</param>
        /// <param name="array2">O segundo array.</param>
        private static void MenorDistancia(List<int> array1, List<int> array2)
        {
            while (true)
            {
                var valoresTrocados = false;
                
                // Passo: Encontrar os valores maximos e mínimos dos dois arrays.
                var maxArray1 = ObterValorMaximo(array1);
                var minArray2 = int.MaxValue;
                minArray2 = ObterValorMinimo(array2, maxArray1, minArray2);
                
                // Se minArray2 não for igual a int.MaxValue, então temos uma menor distância.
                // Caso contrário, trocamos os valores dos arrays e tentamos novamente.
                if (minArray2 != int.MaxValue)
                {
                    Console.WriteLine($"Menor distancia: {minArray2 - maxArray1}");
                }
                else
                {
                    // Caso os valores já tenham sido trocados e a menor distacia não foi encontrada
                    // significa que não há menor distancia entre os arrays informados.
                    if (!valoresTrocados)
                    {
                        Console.WriteLine("Não foi possível encontrar a menor distancia entre os arrays informados..");
                        return;
                    }
                    TrocarArrays(ref array1, ref array2);
                    continue;
                }

                break;
            }
        }
        
        /// <summary>
        /// Função auxiliar para encontrar o valor mínimo de array2 que seja
        /// maior que o valor máximo de array1.
        /// </summary>
        /// <param name="array2">O array a ser pesquisado.</param>
        /// <param name="maxArray1">O valor máximo de array1.</param>
        /// <param name="minArray2">O valor mínimo atual de array2.</param>
        /// <returns>O valor mínimo de array2 que seja maior que maxArray1.</returns>
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
        
        /// <summary>
        /// Função auxiliar para encontrar o valor máximo de um array.
        /// </summary>
        /// <param name="array">O array a ser pesquisado.</param>
        /// <returns>O valor máximo do array.</returns>
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

        /// <summary>
        /// Função para trocar os valores de array1 pelos valores de array2
        /// e vice-versa, permitindo uma busca recursiva da menor distância.
        /// </summary>
        /// <param name="array1">O primeiro array.</param>
        /// <param name="array2">O segundo array.</param>
        /// <param name="valoresTrocados">Variavel booleana informando se os valores já foram trocados.</param>
        private static void TrocarArrays(ref List<int> array1, ref List<int> array2)
        {
            (array1, array2) = (array2, array1);
        }
    }
}