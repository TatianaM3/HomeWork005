double[] array = new double[5]{3, 7, 22, 2, 78};

Console.WriteLine(string.Join(", ",array));

double min = array[0];

for (int i = 0; i < 5; ++i){
    if (array[1] < min) min = array [1];
    if (array[2] < min) min = array [2];
    if (array[3] < min) min = array [3];
    if (array[4] < min) min = array [4];
}
Console.WriteLine("Минимальный элемент массива: " + min);

double max = array[0];

for (int i = 0; i < 5; ++i){
    if (array[1] > max) max = array [1];
    if (array[2] > max) max = array [2];
    if (array[3] > max) max = array [3];
    if (array[4] > max) max = array [4];
}
Console.WriteLine("Максимальный элемент массива: " + max);

double dif = max - min;

Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + dif);