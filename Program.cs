// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8


Console.Clear();
int[] RecursionNumbers(int[] list, int a, int b, int count)
{
    list[count] = a;
    if (a == b)
    {
        return list;
    }
    else
    {
        return RecursionNumbers(list, a + 1, b, count + 1);
    }
}

// Метод выводит массив на экран
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 0)                           //для нахождения четных чисел
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
}

Console.WriteLine("Введите первое число - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - ");
int n = Convert.ToInt32(Console.ReadLine());

int[] finalArray = new int[n - m + 1];

finalArray = RecursionNumbers(finalArray, m, n, 0);
ShowArray(finalArray);


//=======================================================================================================================================================

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
int m = InputNumbers("Введите значение m: ");
int n = InputNumbers("Введите значение n: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
PrintSumm(m, n, temp = 0);
void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}


//========================================================================================================================================================

// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
//M = 28; N = 7 -> 7

Console.Clear();
int first = 0;
first = InputNumber("меньшее");
int second = InputNumber("большее");
int nod = first;

System.Console.WriteLine($"\nНаибольший общий делитель (НОД) для натуральных чисел {first} и {second} - {PrintNOD(first, second, nod)}");

int InputNumber(string str)
{
    while (true)
    {
        Console.Write($"\nНапишите {str} натуральное число:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0 && number > first) 
            {
                return number;                
            }
            else Console.WriteLine($"Некорректно указано {str} натуральное число!\n");
        }
        else Console.WriteLine($"Некорректно указано {str} натуральное число!\n");
    }
}

int PrintNOD(int first, int second, int nod)
{
    return second % nod == 0 && first % nod == 0 ? nod : PrintNOD(first, second, nod - 1);    
}


// Дополнительная задача (задача со звёздочкой): Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int m = InputNumbers("Введите значение m: ");
int n = InputNumbers("Введите значение n: ");

int functionAkkerman = Akk(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Akk(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akk(m - 1, 1);
  else return Akk(m - 1, Akk(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

