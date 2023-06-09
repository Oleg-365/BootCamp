// Быстрая Сортировка(QuickSort)
// Стратегия "Разделяй и властвуй" 


// [5, 2, 4, 3, 1]
// [1, 2, 3, 4, 5]

// [] or [57]
// [5, 3] - [3, 5]

// [2, 3, 1]
// [2] - опорный элемент
// [1] + [2] + [3]

// [3, 4, 1, 2]
// [3] - опорный элемент
// [1, 2] + [3] + [4]
//  |
// [1] - опорный элемент
// [] + [1] + [2]


int Partition(int[] array, int start, int end) // [1, 2, 4, 5, 3] 2 4
{
    int marker = start; // Индекс опорного элемента 2
    for (int i = start; i < end; i++)
    {
        if (array[i] < array[end])
        {
            (array[marker], array[i]) = (array[i], array[marker]);
            marker++;
        }
    }
    // Перемещение array[end] между левым и правым подмассивами
    (array[marker], array[end]) = (array[end], array[marker]);
    // [1, 2, 3, 4, 5]
    // maker = 2
    Console.WriteLine($"[{string.Join(", ", array)}]");
    return marker;
}


void Quicksort(int[] array, int start, int end) // [5, 3, 4, 1, 2] 0 4
{
    if (start >= end)
        return;
    
    int pivot = Partition(array, start, end); // 2
    Quicksort(array, start, pivot - 1); // [1, 2, 3, 4, 5] 2 1
    Quicksort(array, pivot + 1, end); // [1, 2, 3, 4, 5] 3 4
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n]; 
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 101); // [1; 100]
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Quicksort(array, 0, array.Length - 1); // [5, 3, 4, 1, 2] 0 4
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

// Сортировка пузырьком, выбором, вставками O(n^2)
// Быстрая сортировка O(n * log2(n))