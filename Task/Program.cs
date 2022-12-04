// Написать программу, которая из имеющегося массива строк формирует маасив из строк, длина которых меньше либо равна трем символам.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Пример: ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

int size = 6;
int n = 3;
string[] arrayOne = new string [size];
Console.WriteLine($"Введите набор символов {size} раз");
fillArray(arrayOne);
Console.Clear();
PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine($"Новый массив из элементов, количество символов в которых меньше либо равно {n}: ");
if (GetSecondArraySize(arrayOne) == 0)
{
    Console.WriteLine("Искомых элементов для переноса в новый массив нет");
}
else 
{
    string[] arrayTwo = TransferElements(arrayOne);
    PrintArray(arrayTwo);
}


// задание массива
void fillArray (string [] arr)
{
    for (int i = 0; i < size; i++) 
    {
     arr[i] = Console.ReadLine () ?? "";
    }
}

// печать массива
void PrintArray(string [] arr)
{
    int arrlength = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < arrlength; i++) 
    {
     Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

int GetSecondArraySize(string [] arr)
{
int secondSize = 0;
for (int i = 0; i < size; i++) 
    {
    if(arr[i].Length <= n)
    {
        secondSize++;
    }
    }
    return secondSize;
}

string[] TransferElements(string [] arr)
{
    string[] arrayTwo = new string[GetSecondArraySize(arrayOne)];
    for (int i = 0, j = 0; i < size; i++) 
    {
    if(arr[i].Length <= n)
     {
        arrayTwo[j] = arr[i];
        j++;
     }
    }
 return arrayTwo;
}
