using System.Buffers;



// Составить программу, которая будет генерировать случайные числа в интервале [a;b] и заполнять ими двумерный массив размером 10 на 10.
// В массиве необходимо найти номер строки с минимальным элементом.
// Поменять строки массива местами, строку с минимальным элементом и первую строку массива. Организовать удобный вывод на экран.


int Message(string text) {
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[,] GetDoubleMass(int a, int b) {
    double[,] MyArray = new double[10,10];
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            Random rnd = new Random();
            MyArray[i,j] = rnd.Next(a,b) + rnd.NextDouble();
            MyArray[i,j] = Math.Round(MyArray[i,j],3);
        }
    }
    return MyArray;
}

void GetMass(double[,] arr) {
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
   
}

int FindMinElementInMass(double[,] arr) {
    double min = arr[0,0];
    int MinRow = 0;
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            if (arr[i,j] < min) {
                min = arr[i,j];
                MinRow = i;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент массива: {min}");
    Console.WriteLine($"Номер строки с минимальным элементом массива: {MinRow}");
    return MinRow;
}

double[,] ReplaceRowFithMinElement(double[,] arr, int MinimalRow) {
    double temp;
    int count = 0;
    for (int i = MinimalRow; i <= MinimalRow; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            temp = arr[MinimalRow,j];
            arr[MinimalRow,j] = arr[count,j];
            arr[count,j] = temp;
        }
    }
    return arr;
}





int size_a = Message("Введите нижнюю границу чисел массива");
int size_b = Message("Введите верхнюю границу чисел массива");
double[,] DoubleArr = GetDoubleMass(size_a, size_b);
GetMass(DoubleArr);
Console.WriteLine();
int minimal = FindMinElementInMass(DoubleArr);
Console.WriteLine();
DoubleArr = ReplaceRowFithMinElement(DoubleArr,minimal);
GetMass(DoubleArr);
Console.WriteLine();
Console.WriteLine($"1 и {minimal} строка поменялись местами");




 
