void TaskMenu()
{
	bool exitOut = true;

	while (exitOut == true)
	{
		Console.WriteLine("Введите номер задачи(1, 2, либо q/Q для выхода):");
		string selectTask = "";
		selectTask = Console.ReadLine();

		switch (selectTask)
		{
			case "1":
				{
					Console.Clear();
					Task_1();
					break;
				}

			case "2":
				{
					Console.Clear();
					Task_2();
					break;
				}

			case "q":
				{
					exitOut = false;
					Console.Clear();
					break;
				}

			case "Q":
				{
					exitOut = false;
					Console.Clear();
					break;
				}

			default:
				{
					Console.WriteLine("Вы не попали в нужную кнопку, попробуйте ещё раз!");
					break;
				}
		}
	}
}

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

int CountPositiveNumbers(int[] array)
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

void Task_1()
{
	Console.Clear();
	int length = ReadInput("Сколько будет чисел? >");
	int[] array;
	array = InputArray(length);
	PrintArray(array);
	Console.WriteLine($"Чисел больше 0 => {CountPositiveNumbers(array)}");
}

void Task_2()
{
	double k1 = ReadInput("k1");
	double b1 = ReadInput("b1");
	double k2 = ReadInput("k2");
	double b2 = ReadInput("b2");

	double deltaK = k1 - k2;
	double deltaB = b1 - b2;
	double x = (-1) * deltaB / deltaK;
	double y = k2 * x + b2;

	Console.WriteLine($"Координаты пересечения данных прямых: x = {x}, y = {y}");
	Console.WriteLine("Для продолжения нажмите 'Ввод'...");
	Console.ReadLine();
}

TaskMenu();