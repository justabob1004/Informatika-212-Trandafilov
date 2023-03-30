using System.Drawing;

List<int> ints = new List<int>();
ints.Add(1);
ints.Add(10);
ints.Add(23);
ints.Add(28);
ints.Add(16);
foreach(int elem in ints)
{
    Console.WriteLine($"{elem}\t");
}
//
Console.WriteLine();
ints.Add(30);
foreach(int elem in ints)
{
    Console.WriteLine($"{elem}\t");
}
//Вставка эдеентов по указанному индексу (сдвиг в право)
Console.WriteLine();
ints.Insert(0, 500);
foreach (int elem in ints)
{
    Console.WriteLine($"{elem}\t");
}
//Добавление в список одномерного массива
Console.WriteLine();
ints.AddRange(new[] { -5, 0, 14 });
foreach(int elem in ints)
{
    Console.WriteLine($"{elem}\t");
}
//Определение кол-ва элементов коллекции.
Console.WriteLine();
//int size =ints.Count;
//Console.WriteLine($"Текущее кол-во элементов = {size}");
Console.WriteLine($"Текущее кол-во элементов = {ints.Count}");
//Определение индекса элемента со значением 25
Console.WriteLine();
Console.WriteLine($"Индекс элемента со значением 25 ={ints.IndexOf(25)}");
//Удаление из коллекции первого вхождения элемента со значения 10
Console.WriteLine();
ints.Remove(10);
foreach (int elem in ints)
{
    Console.WriteLine($"{elem}\t");
}
//Удаление из коллекции элемента с указанным индексом
Console.WriteLine();
ints.RemoveAt(2);
foreach (int elem in ints)
{
    Console.WriteLine($"{elem}\t");
}
//Coh
Console.WriteLine();
ints.Reverse();
foreach (int elem in ints)
{
    Console.WriteLine($"{elem}\t");
}
Console.Read();