def quicksort(array):
    if len(array) < 2: #  [] or [47]
        return array
    else:
        pivot = array[0] #  Опорный элемент
        # array = [5, 4, 3, 1, 2, 5]
        #          0  1  2  3  4  5
        # array[1:] = [4, 3, 1, 2]
        less = [i for i in array[1:] if i <= pivot]  # List comperhensions
        greater = [i for i in array[1:] if i > pivot]
        return quicksort(less) + [pivot] + quicksort(greater)


print(quicksort([5, 2, 3, 4, 5, 6, 5, 1, 2, 0, 7]))


# List(список) - Python ([1, 45, 1.78, 'Hello', True])
# Array(массив) - С# ([1, 2, 3, 4, 5, 6]) - int