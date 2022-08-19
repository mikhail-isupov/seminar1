Console.WriteLine("Находим наибольшее из трех целых чисел");

Console.WriteLine("Введите N1:");

int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N2:");

int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N3:");

int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n2 > max)
{
    max = n2;
}

if (n3 > max)
{
    max = n3;
}

Console.WriteLine("Максимальное значение из трех чисел: " + max);

