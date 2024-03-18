Console.WriteLine("Hello, World!");
var x = 0;
var y = 1;
var z = 2;

Console.WriteLine(Average([1, 2, 3, 4]));
Console.WriteLine(Max([1, 2, 3, 4]));
return;

static float Average(int[] arr)
{
    var suma = 0f;
    foreach (int value in arr)
    {
        suma += value;
    }

    return suma / arr.Length;
}

static float Max(int[] arr)
{
    var max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    return max;
}