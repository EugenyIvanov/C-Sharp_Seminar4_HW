Console.Clear();
int [] array = new int[10];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
int indexMax = 0;
for(int j = 0; j < array.Length; j++)
{
    if(array[j] > array[indexMax])
    {
        indexMax = j;
    }
}
Console.WriteLine();
Console.WriteLine(array[indexMax]);