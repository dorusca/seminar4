/*Задача 1: А) найти сумму чисел от 1 до А  (не возвратный метод)
void MetFindSum (int a)
{
int summa = 0;
for (int current =1; current <= a; current++)
{
    summa += current; // summa = summa+ current
}
Console.WriteLine ($"Сумма чисел от 1 до {a} равна {summa}");
}
Console.WriteLine ("Введите число: ");
int user_num = Convert.ToInt32 (Console.ReadLine ());

MetFindSum (user_num );

Б) найти сумму чисел от 1 до А  ( возвратный метод)

int MetFindSum (int a)
{
int summa = 0;
for (int current =1; current <= a; current++)
summa += current; // summa = summa+ current
{
    return summa;
}

}
Console.WriteLine ("Введите число: ");
int user_num = Convert.ToInt32 (Console.ReadLine ());

int result = MetFindSum (user_num );
Console.WriteLine ($"Сумма чисел от 1 до {user_num} равна {result}");



Задача 2: Напишите программу, которая принимает на
 вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5

int CountOfDigits (int number)
{
int current =1;
while (number>=10)
{
    number = number / 10;
    current++;
}
return current;
}
Console.WriteLine ("Введите число: ");
int user_num = Convert.ToInt32 (Console.ReadLine ());

int count_digit;
int user_num1 = (-1)*user_num;
if (user_num >= 0)
count_digit= CountOfDigits (user_num );
else 
count_digit = CountOfDigits (user_num1 );
Console.WriteLine ($"Введенное число {user_num} состоит из {count_digit} цифр");

Задача 3: Напишите программу, которая принимает на вход число N и выдаёт
 произведение чисел от 1 до N.
4 -> 24
5 -> 120

void Factorial (int n)
{
int multi =1; 
for (int current =1; current <= n; current++)
{
    multi *=current;
}
Console.WriteLine($"{n} -> {multi}");
}
Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine ());

if (num<0)
{
while(num<0)
{
    Console.WriteLine ("Введите положительное число: ");
num = Convert.ToInt32 (Console.ReadLine ());
}
}
Factorial (num);


 
Задача 4: Напишите программу, которая выводит массив из 8 элементов,
   заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]

int []CreatNewArray(int size)
{
int []array = new int [size];
for (int i= 0; i< size; i++)
array [i] = new Random().Next(0,2);
return array;

}
void SchowArray (int []array)
{
    for (int i= 0; i< array.Length; i++)
    Console.Write (array [i] +  " ");
}
Console.Write ("Введите колличество элементов: ");
int count_elem = Convert.ToInt32 (Console.ReadLine ());

int [] array1 = CreatNewArray(count_elem);
SchowArray (array1);
Задача 4: Напишите программу, которая выводит массив из n-го колличества элементов,
   заполненный числами заданными пользователем.*/

int []CreatNewArray(int size, int min, int max)
{
int []array = new int [size];
for (int i= 0; i< size; i++)
array [i] = new Random().Next(min, max+1);
return array;

}
void SchowArray (int []array)
{
    for (int i= 0; i< array.Length; i++)
    Console.Write (array [i] +  " ");
}

Console.Write ("Введите колличество элементов: ");
int count_elem = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("Введите максимальное значение элементов: ");
int maxValue = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("Введите минимальное значение элементов: ");
int minValue = Convert.ToInt32 (Console.ReadLine ());


int [] array1 = CreatNewArray( count_elem, minValue, maxValue);
SchowArray (array1);

