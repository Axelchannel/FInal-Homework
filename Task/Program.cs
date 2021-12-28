int[] CreateNewArr() //Генерация массива А
{
    int[] a = new int[5];
    for (int n = 0; n < a.Length; n++)
    {
        a[n] = new Random().Next(-10, 10);
        Console.Write($" {a[n]} ");
    }
    return a;
}

int FindCountEven(int[] a) //Подсчёт количества чётных элементов
{
    int сount = 0;
    for (int p = 0; p < a.Length; p++)
    {
        if (a[p] % 2 == 0)
            сount++;
    }
    return сount;
}

void FindEvenElements(int[] b, int count) //Создание нового массива В и его печать
{
    int[] c = new int[count];
    for (int k = 0, j = 0; k < b.Length; k++)
    {
        if (b[k] % 2 == 0 && b[k] !=0)
        {
            c[j] = b[k];
            Console.Write($" {c[j]} ");
            j++;
        }
    }
}



int[] arrayA = CreateNewArr();
int count = FindCountEven(arrayA);
Console.WriteLine();
Console.WriteLine("Новый массив");
FindEvenElements(arrayA,count);





