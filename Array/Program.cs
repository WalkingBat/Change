int[] NewArray = new int[8];
System.Console.WriteLine("Массив: ");
for (int i = 0; i < NewArray.Length; i++)
{
    NewArray[i] = new Random().Next(1,10);
    System.Console.Write($"{NewArray[i]}");
}
System.Console.WriteLine();

