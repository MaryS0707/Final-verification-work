# ___Итоговая проверочная работа___

## _Задача:_
> Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## _Примеры:_
```
["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
```

## _Решение:_

1. Создать первоначальный массив из строк N-ой длины. 

```
string [] originArray = new string [10];
```

2. Заполнить его

```
for (int i = 0; i < originArray.Length; i++)
{
    Console.Write("Enter element " + i + ":  ");
    originArray[i] = Console.ReadLine();
}
```

3. Определить длину для нового двумерного массива, в котором будут храниться строки длиной меньше/равно 3
```
int finalArraySize = 0;
for (int i = 0; i <  originArray.Length; i++)
{
    if (originArray[i].Length <= 3)
        finalArraySize++;
}
```

4. Создать итоговый массив
```
string[] finalArray = new string[finalArraySize];
```

5. Заполнить итоговый массив
```
int finalArrayIndx = 0;
    for (int i = 0; i < originArray.Length; i++)
    {
        if (originArray[i].Length <= 3) 
        finalArray[finalArrayIndx++] = originArray[i];
}
```

6. Вывести оба массива на экран
```
Console.Write("Original Array: ");
for (int i = 0; i < originArray.Length; i++)
{
    Console.Write(originArray[i] + ((i != originArray.Length - 1) ? ", " : ""));
}

Console.WriteLine();

Console.Write("New Array: ");
for (int i = 0; i < finalArray.Length; i++)
{
    Console.Write(finalArray[i] + ((i != finalArray.Length - 1) ? ", " : ""));
}

```