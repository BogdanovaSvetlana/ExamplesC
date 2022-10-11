int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);


// Программа задает двумерный массив и принимает на вхлд 
// число, затем проверяет сколько раз оно встречается в массиве
int InputNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Преобразование массива в строку с заданным разделителем
string intArrayToString(int[,] array) 
{
    int lenght0 = array.GetLength(0); // получение длины массива
    int lenght1 = array.GetLength(1); // получение длины массива
    string textarray = String.Empty; // обнуление строки
    for( int i = 0; i < lenght0; i++) // цикл по элементам массива
    {
        for(int j = 0; j < lenght1; j++)
        {
            textarray += array[i, j]; // добавление в строку значения текущего элемента массива
            if(j < lenght1 - 1) // проверка: является ли элемент последним (нужно ли добавить разделитель в строку)
            textarray += ", "; // добавление разделителя между элементами в строку
        }
        textarray += "\n";
    }
    return textarray; // возврат значения элементов массива в виде полученной строки
}

void FillArray(int[,] array, int min, int max)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
}

int getResalt(int[,] array, int a)
{
    int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows; 
    int resalt = 0;
    for(int j = 0; j <columns; j++)
    {
        for(int i = 0; i < rows; i++)
        {
           if( a != array[i, j])
           {
            resalt = resalt + 0;
           }
           else
           {
            resalt++;
           }
        }
    }
     return resalt;
}

int m = InputNumber("Введите первую размерность массива: "),
    n = InputNumber("Введите вторую размерность массива: "),
    a = InputNumber("Введите число, а мы поищем сколько раз оно встречается в нашей матрице!"),
    min = InputNumber("Введите минимальное значение случайных чисел: "),
    max = InputNumber("Введите максимальное значение случайных чисел: ");
int[,] array = new int[m, n];


FillArray(array, min, max);
Console.WriteLine(intArrayToString(array));
Console.WriteLine($"Число {a} в нашем массиве ");
Console.WriteLine($"находится {getResalt(array, a)} раз");