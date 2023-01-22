/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] CreateRandomArray(int N)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        Console.Write($"Введите {i+1}-число: ");
        RandomArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return RandomArray;
}

void PositiveNumbers (int[] array)
{
    int s = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) s+=1;
    }
    Console.Write($"Количество чисел больше 0 равно = {s}");
}

Console.Write("Введите количество чисел, которое необходимо ввести: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] Array = CreateRandomArray(M);

PositiveNumbers(Array);