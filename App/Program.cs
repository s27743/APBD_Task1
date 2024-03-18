Console.WriteLine("Hello, World!");
var x = 0;
var y = 1;
var z = 2;

Console.WriteLine(Average([1, 2, 3, 4]));
return;

static float Average(int[] arr)
{
    var sum = 0f;
    foreach (int value in arr)
    {
        sum += value;
    }

    return sum / arr.Length;
}