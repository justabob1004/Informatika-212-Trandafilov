byte n = byte.Parse(Console.ReadLine());
double[] array = new double[n];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = -50 + (50 - (-50)) * rnd.NextDouble();
    Console.WriteLine($"array[{i}]={array[i]}");
}
Console.WriteLine();
Console.WriteLine($"array[0]={array[0]}\t array[{n - 1}]={array[n - 1]}");
Console.Read();
