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

void Task_1()
{
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

	Console.Clear();
	int length = ReadInput("Сколько будет чисел? >");
	int[] array;
	array = InputArray(length);
	PrintArray(array);
	Console.WriteLine($"Чисел больше 0 => {CountPosNumbers(array)}");
}

void Task_2()
{



}

TaskMenu();