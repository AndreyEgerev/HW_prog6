// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}
//функция вывода массива
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("] ");
}
//функция ввода массива чисел
int[] InputArray (int[] array)
{
	for (int index = 0; index<array.Length; index++)
	{
		array[index] = GetNumberInt($"Введите {index+1}-е число - ");
    }
	return array;
}
//функция подсчета чисел больше 0
int CountPositiveNumber ( int[] array)
{
	int countPositiveNum = 0;
	for (int index = 0; index < array.Length; index++)
	{
		if (array[index]>0)
		{
			countPositiveNum++;
		}
	}
	return countPositiveNum;
}

int numberElements = GetNumberInt("Введите количество элементов - ");
int[] userElements = new int[numberElements];

InputArray(userElements);
PrintArray(userElements); 
Console.WriteLine($"Количество элементов больше 0 - {CountPositiveNumber(userElements)}");