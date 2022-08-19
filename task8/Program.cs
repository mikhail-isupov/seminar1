Console.WriteLine("Выводим все четные числа от 1 до N");

Console.WriteLine("Введите целое число  N ");

int n = Convert.ToInt32(Console.ReadLine());

int step = 1;

int i = 1;

if (n < i)
{
    step = -1;
}

while (Math.Abs(i) <= Math.Abs(n))
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }

    i = i + step;

}
