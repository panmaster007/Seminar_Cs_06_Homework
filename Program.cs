int ReadInput(string message)
{
    Console.WriteLine(message); 
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;  
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = ReadInput($"Введите {i + 1} число");
    }
    return array;  
}

void PrintArray(int[] array)
{
    Console.WriteLine("Введены следующие числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"=> {array[i]}");
    }
}
 
int CountPosNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = ReadInput("Сколько будет чисел? >");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Чисел больше 0 => {CountPosNumbers(array)}");
