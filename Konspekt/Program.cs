/*
1. Константные(+)
2. Логарифмические(бинарный поиск) O(log2(n)) (+)
3. Линейные(+)
4. Линейно-логарифмические(быстрая сортировка, сортировка слиянием) (+)
5. Квадратные(сортировак пузырьком, сортировка выбором, сортировка вставками)
6. Кубические
7. Степенные (рекурсия)
*/


// Напишите программу, которая запрашивает у пользователя число(n). Необходимо сумму чисел от 1 до n.
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Результат: {((n + 1) / 2.0) * n}");
// O(1)

// int n = int.Parse(Console.ReadLine()!);
// int n = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// for (int i = 1; i <= n; i++)
//     result = result + i;
// Console.WriteLine($"Результат: {result}");
// O(n)


// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 101); // [1, 100]
// }

// void SortArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = 0; j < array.Length - 1; j++)
//         {
//             if (array[j] > array[j + 1])
//             {
//                 int temp = array[j];
//                 array[j] = array[j + 1];
//                 array[j + 1] = temp;
//             }
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// SortArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
// O(n^2)

int[] array = new int[5];
int[,] array2D = new int[5, 5];
int[,,] array3D = new int[5, 5, 5];
int count = 0;
for (int i = 0; i < array3D.GetLength(0); i++)
{
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            array3D[i, j, k] = count;
            count++;
            Console.WriteLine($"{array3D[i, j, k]} ({i}, {j}, {k})");
        }
    }
}
// O(n^3)
// https://www.notion.so/C-6e505408d2574e518ebef95f794d2769
// Коды могут отличаться между тем, что было на семинаре и в ноушене 