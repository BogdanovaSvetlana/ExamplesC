double numberA = 12;
double numberB = 5;
Console.WriteLine(numberA / numberB);

string[,] str = { 
    // 0          1                   2
    {"Сегодня", "замечательная", "погода"},// 0
    {"Как",     "твои",          "дела?"}, // 1
    {"Какой",   "сегдня",        "день?"}, // 2
    {"Бла бла", "ту ту ту",      "1111"},  // 3
    {"Фууу",    "баррр",         "биззз!"} // 4
};

int x = 2;


// Без использования циклов 
Console.WriteLine($"{str[x, 0]} {str[x, 1]} {str[x, 2]}");

// Цикл For
int rows = str.GetUpperBound(0) + 1;    // количество строк
int columns = str.Length / rows;        // количество столбцов

 for (int j = 0; j < columns; j++)
    {
       Console.Write(str[x ,j] + " ");
    }
    Console.WriteLine();


Console.WriteLine();
Console.WriteLine(); 

// Цикл While

int i = 0;
while(i < columns)
{
    Console.Write(str[x ,i] + " ");
    i++;
}

Console.WriteLine();
Console.WriteLine(); 

// Цикл Do

int n = 0;
do
{
    Console.Write(str[x, n] + " ");
    n++;
}
while (n < columns);

