// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}
//функция вывода массива
void PrintArray(double[] arr)
{
    //Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    //Console.WriteLine("] ");
}

//функция проверки на возможность пересечения линий
bool CrossLine(int[] klines)
{
	bool crossLine = true;
    if (klines[0] == klines[2]) // проверка на наклон линии (параллельность)
	{
		crossLine = false;
        return crossLine;
	}
	return crossLine;	
}

//Функция поиска пересечения линий
double[] FindCrossPoint (int[] kLines)
{
	// kLines[0] - k1
	// kLines[1] - b1
	// kLines[2] - k2
	// kLines[3] - b2
	double[] crossPoint = new double[2]; // 0 - X; 1 - Y
    crossPoint[0] = (kLines[1]-kLines[3]) / (kLines[2]-kLines[0]); //x=(b1-b2)/(k2-k1)
    crossPoint[1] = kLines[0] * crossPoint[0] + kLines[1]; // y=k1*x+b1
	
	return crossPoint;
}

int[] kLines = new int[4];//массив коэффициентов линий
double[] cross = new double[2];
//Ввод значений коэффициентов
Console.WriteLine("Поиск пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 ");
kLines[0] = GetNumberInt("Введите k1 - ");
kLines[1] = GetNumberInt("Введите b1 - ");
kLines[2] = GetNumberInt("Введите k2 - ");
kLines[3] = GetNumberInt("Введите b2 - ");
//Поиск точки пересечения линий
bool crossLine = CrossLine(kLines);
// Вывод точки пересечения линий
if (crossLine)
{
	cross = FindCrossPoint(kLines);
    Console.Write("Точка пересечения - ");
    PrintArray(cross);
}
else
{
	Console.WriteLine("Прямые не пересекаются");
}