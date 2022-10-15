// Программа из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Массив можно ввести с клавит, либо задать на 
//старте выполнения алгоритма. При решении лучше использовать массивы, а не коллекции.


// Чтение данных из консоли
string ReadData(string line)
{

    Console.WriteLine(line);
    return Console.ReadLine() ?? "0";
}

// обрабатываем входящие данные
string[] ParceReadData(string line)
{

    line = line.Replace(" ", "");
    line = line.Replace("]", "");
    line = line.Replace("[", "");

    string[] parcedLine = line.Split(",");
    return parcedLine;
}

// Создаём массив с необходимыми данными
string[] ChangeArray(string[] parcedLine)
{
    int count = 0;
    for (int i = 0; i < parcedLine.Length; i++)
    {
        if (parcedLine[i].Length <= 3)
        {
            count++;
        }
    }

    // Задаём длину массива, равную количеству необходимых элементов
    string[] finalArray = new string[count];
    int j = 0;
    for (int i = 0; i < parcedLine.Length; i++)
    {
        if (parcedLine[i].Length <= 3)
        {
            finalArray[j] = parcedLine[i];
            j++;
        }
    }
    return finalArray;
}

// Печатаем массив
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

PrintArray(ChangeArray(ParceReadData(ReadData("Введите массив: "))));
