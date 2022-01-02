int[] NewArray = new int[8];
System.Console.WriteLine("Массив: ");
for (int i = 0; i < NewArray.Length; i++)
{
    NewArray[i] = new Random().Next(1,10);
    System.Console.Write($"{NewArray[i]}");
}
System.Console.WriteLine();
System.Console.WriteLine("Массив с четными числами: ");
for (int i = 0; i < NewArray.Length; i++)
{
    if (NewArray[i] % 2 == 0) System.Console.Write($"{NewArray[i]} ");
}
