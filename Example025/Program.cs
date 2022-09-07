Console.Clear();
Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
int product = 1;
for(int i = 1; i <= b; i++)
{
    product = product * a;
}
Console.Write(product);