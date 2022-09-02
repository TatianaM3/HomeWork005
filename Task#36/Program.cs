// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов стоящих на нечетных позициях

int size = 4;
int[] array = new int [size];

for (int i = 0; i < array.Length; ++i){
    array[i] = new Random().Next(-99, 100);
}
Console.WriteLine(string.Join(",",array));

int count = 0;


for (int i = 1; i < array.Length; i = i + 2){
    count = count  + array[i];
    }
Console.WriteLine("Сумма чисел на нечетных позициях: " + count);