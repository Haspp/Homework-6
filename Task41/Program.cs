int size = InputInt("Введите размер массива: ");
int[] array = new int[size];

for(int i = 0; i < size; i++)
{
    Console.Write("Введите {0} число: ", i + 1);
    array[i] = int.Parse(Console.ReadLine());
}

int positiveNumbers = 0;

for(int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        positiveNumbers++;
    }
}
Console.WriteLine(positiveNumbers);

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
    
}
