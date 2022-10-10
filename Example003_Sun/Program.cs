int numberA = 3;
int numberB = 5;
int result = numberA + numberB;
Console.WriteLine(result);

string[,] str = { 
    // 0          1                   2
    {"Сегодня", "замечательная", "погода"}, // 0
    {"Как",     "твои",          "дела?"} // 1
};

Console.WriteLine(str[0,2]);
Console.WriteLine($"{str[0,0]} {str[0,1]} {str[0,2]}");

int rows = str.GetUpperBound(0) + 1;    // количество строк
int columns = str.Length / rows;        // количество столбцов

 for (int j = 0; j < columns; j++)
    {
        Console.Write(str[0,j] + " ");
    }
    Console.WriteLine();
        

Console.WriteLine();
Console.WriteLine(); 

int i = 0;
while(i < columns)
{
    Console.Write(str[0,i] + " ");
    i++;
}

Console.WriteLine();
Console.WriteLine(); 

int n = 0;
do
{
    Console.Write(str[0,n] + " ");
    n++;
}
while (n < columns);