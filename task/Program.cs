// Cоздали первоначальный двумерный массив
string [] originArray = new string [10];

// Заполнили его
for (int i = 0; i < originArray.Length; i++)
{
    Console.Write("Enter element " + i + ":  ");
    originArray[i] = Console.ReadLine();
}

// Определили длину для нового двумерного массива, в котором будут храниться строки длиной меньше/равно 3
int finalArraySize = 0;
for (int i = 0; i <  originArray.Length; i++)
{
    if (originArray[i].Length <= 3)
        finalArraySize++;
}

// Создали итоговый массив
string[] finalArray = new string[finalArraySize];

// Заполнили итоговый массив
int finalArrayIndx = 0;
    for (int i = 0; i < originArray.Length; i++)
    {
        if (originArray[i].Length <= 3) 
        finalArray[finalArrayIndx++] = originArray[i];
}

// Вывод первоначального массива
Console.Write("Original Array: ");
for (int i = 0; i < originArray.Length; i++)
{
    Console.Write(originArray[i] + ((i != originArray.Length - 1) ? ", " : ""));
}

Console.WriteLine();

//Вывод итогового массива
Console.Write("New Array: ");
for (int i = 0; i < finalArray.Length; i++)
{
    Console.Write(finalArray[i] + ((i != finalArray.Length - 1) ? ", " : ""));
}
