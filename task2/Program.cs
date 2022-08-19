Console.WriteLine("Находим наибольшее из двух целых чисел");

Console.WriteLine("Введите число N1");

int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N2");

int n2 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n2 > max)
{
    max = n2;
}

Console.WriteLine("Наибольшее из двух чисел: " + max);