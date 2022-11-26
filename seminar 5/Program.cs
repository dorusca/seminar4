/*Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.

int []CreatNewArray (int size)
{
int [] array = new int [size];
for (int i =0; i < size; i++)
array [i] = new Random (). Next (-9,10);
return array;

}

void ShowArray (int [] array)
{
    for (int i =0; i< array.Length; i++)
    Console.Write (array [i] + "  "); 
}

int SumNegNumber (int [] array)
{
    int sumNeg=0;
for (int i =0; i< array.Length; i++)
if (array [i] < 0) 
    sumNeg += array [i];
return sumNeg;
}

int SumPozNumber (int [] array)
{
    int sumPoz=0;
for (int i =0; i< array.Length; i++)
if (array [i] > 0) 
    sumPoz += array [i];
return sumPoz;
}



Console.Write ("Введите колличество элементов :  ");
int count_elem= Convert. ToInt32 (Console. ReadLine ());
int [] array1 = CreatNewArray (count_elem);
ShowArray (array1);
int  resultNeg = SumNegNumber (array1);
Console.Write ($"Сумма отрицательных элементов равна : {resultNeg} ");

int  resultPoz = SumPozNumber (array1);
Console.Write ($"Сумма положительных элементов равна : {resultPoz} ");


/*Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21


int []CreatRandomArray (int size, int min, int max)
{
int [] newArray = new int [size];
for (int i =0; i < size; i++)
newArray [i] = new Random (). Next ( min, max+1);
return newArray;

}

void ShowArray (int [] array)
{
    for (int i =0; i< array.Length; i++)
    Console.Write (array [i] + "  "); 
    Console.WriteLine ();
}

int [] FindMultiPar (int[] arrayCreatad)
{
int size2;
if (arrayCreatad.Length %2 == 0)
    size2= arrayCreatad.Length /2;
else size2 = (arrayCreatad.Length +1) / 2;

int [] arrayMulti = new int [size2];
for ( int i =0; i <arrayCreatad.Length / 2; i++)
{
    arrayMulti [i] = arrayCreatad [i] *arrayCreatad [arrayCreatad.Length-1-i];
}
if ( arrayCreatad.Length %2 !=0)
arrayMulti [size2 -1] = arrayCreatad [size2 -1];
return arrayMulti;
    
}


Console.Write ("Введите колличество элементов :  ");
int array_size = Convert. ToInt32 (Console. ReadLine ());


Console.Write ("Введите минимальное значение элементов :  ");
int array_min = Convert. ToInt32 (Console. ReadLine ());

Console.Write ("Введите максимальное значение элементов :  ");
int array_max = Convert. ToInt32 (Console. ReadLine ());

int [] array1 = CreatRandomArray (array_size, array_min, array_max);
ShowArray (array1);
int [] array2 = FindMultiPar (array1);
ShowArray (array2);

/*Задайте одномерный массив из 123 случайных чисел.
 Найдите количество элементов массива, значения которых лежат в отрезке [10,99].*/