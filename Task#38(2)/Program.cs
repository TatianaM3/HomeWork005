void FillArray(double[] collection){
    int lendth = 5;
    int i = 0;
    while (i < lendth){
        collection[i] = new Random().Next(1, 100);
        i++;
    }
}
void PrintArray(double[] col){
    int count = col.Length;
    int pos = 0;
    while(pos < count){
        Console.Write(col[pos] + ", ");
        pos++;
    }
}
double[] array = new double[5];

FillArray(array);
PrintArray(array);

double max = array[0];
int i = 0;

while (i < array.Length){
    if(max < array[i]){
        max = array[i];
    }
    i++;
}

double min = array[0];

while (i < array.Length){
    if (min > array[i]){
        min = array[i];
    }
    i++;
}
double dif = max - min;
Console.WriteLine("Разница между максимальным и минимальным значением массива = " + dif);