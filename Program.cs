using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ВВедите сумму, которую желаете обналичить. Введённая сумма должна делиться на 100.");

        if (int.TryParse(Console.ReadLine(), out int cash))
        {
            if (cash < 150000)
            {
                if (cash % 100 == 0)
                {
                    cashOut(cash);
                }
                else
                {
                    Console.WriteLine("Запрошенная сумма невозможно выдать ровно.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Запрошена слишком большая сумма, ограничение на вывод 150.000");
                return;
            }
        }
        else
        {
            Console.WriteLine("Введена некорректная сумма.");
        }
    }
    static void cashOut(int cash)
    {
        int[] money = {5000, 2000, 1000, 500, 200, 100};
        int[] count = new int[6];
        int remain = cash;

        for (int i = 0; i < money.Length; i++)
        {
            count[i] = remain / money[i];
            remain %= money[i];
        }

        if (remain == 0)
        {
            Console.WriteLine($"Для выдачи {cash} рублей потребуется:");
            for (int i = 0; i < money.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{count[i]} по {money[i]}");
                }
            }
        }

    }
}
