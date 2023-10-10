var arr2 = new List<int>() { 1, 2, 3 };
var arr1 = new List<int>() { 10, 20, 30 };
MenorDistancia(arr1, arr2);

void MenorDistancia(List<int> array1, List<int> array2)
{
    while (true)
    {
        var maxArray1 = array1[0];

        foreach (var i in array1)
        {
            if (i > maxArray1)  
                maxArray1 = i;
        }

        var minArray2 = 2147483647;
        
        foreach (var num in array2)
        {
            if (num > maxArray1 && num < minArray2)
            {
                minArray2 = num;
            }
        }

        if (minArray2 != int.MaxValue)
        {
            Console.WriteLine(minArray2 - maxArray1);
        }
        else
        {
            (array1, array2) = (array2, array1);
            continue;
        }

        break;
    }
}