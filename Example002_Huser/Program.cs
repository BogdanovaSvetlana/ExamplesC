Console.WriteLine("Введите ваше имя ");
string username = Console.ReadLine();
Console.Write("Привет, ");
Console.Write(username);




string[] str = {"Hi", "Micael", "!"};

string a = str[0];
string b = str[1];
string c = str[2];

Console.WriteLine($"{a} {b} {c}\n");

for(int i = 0; i < str.Length; i++)
{
    Console.Write(str[i] + " ");
}

Console.WriteLine();
Console.WriteLine(); 

int j = 0;
while(j < str.Length)
{
    Console.Write(str[j] + " ");
    j++;
}

Console.WriteLine();
Console.WriteLine(); 

int n = 0;
do
{
    Console.Write(str[n] + " ");
    n++;
}
while (n < str.Length);

//Возведение заданного числа в заданную степень
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень возведения: ");
int value = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = 1;

while ( value>0)
{
if (value%2!=0)
{
result = result * number;
value=value-1;
}
else
{
result = result *result;
value=value/2;
}
}
Console.WriteLine(result);