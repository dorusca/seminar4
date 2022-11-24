/*ДОМАШНЯЯ РАБОТА

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

int Degree(int a, int b)
{
int result =1; 
for (int count=1; count <= b; count++)
{
    result *= a ; 
}
return result;

}
Console.WriteLine ("Введите первое число: ");
int num1 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine ("Введите второе число: ");
int num2 = Convert.ToInt32 (Console.ReadLine ());

if (num2<0)
{
    Console.WriteLine ("Введите положительное число: ");
num2 = Convert.ToInt32 (Console.ReadLine ());
}
int result = Degree (num1, num2);
Console.WriteLine ($"{num1},{num2} ->{result}  ");


Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


int NumberLen(int a)  // метод подсчета цифр в числе
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;   
}

void SummaNumbers(int n, int numb) // метод суммы
{
    int sum = 0;
    for (int i = 1; i <= numb; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"сумма цифр {sum}");
}
Console.WriteLine ("Введите число: ");
int user_num = Convert.ToInt32 (Console.ReadLine ());

int num = NumberLen(user_num);
SummaNumbers( user_num, num);

Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.*/

int [] NewArray(int size)
{
int []array = new int [size];
for (int i= 0; i< size; i++)
array [i] = new Random().Next(1,100);
return array;

}
void SchowArray (int []array)
{
    for (int i= 0; i< array.Length; i++)
    Console.Write (array [i] +  " ");
}
Console.Write ("Введите колличество элементов: ");
int count_elem = Convert.ToInt32 (Console.ReadLine ());

int [] array1 = NewArray(count_elem);
SchowArray (array1);



