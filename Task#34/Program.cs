// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int size = 4;
int[] array = new int [size];

for (int i = 0; i < array.Length; ++i){
    array[i] = new Random().Next(100, 1000);
}
Console.WriteLine(string.Join(",",array));

int sum = 0;

foreach (int count in array)
{
   if (count % 2 == 0){
    sum++; 
}
}
Console.WriteLine("Количество четных чисел в массиве: " + sum);