// Это Main работа. Версии при их наличии будут распределены в репозитории по соответствующим веткам.

int programm;
Boolean exit = true;

while (exit)
{
    Console.WriteLine("Введите число для соответствующей задачи:");
    Console.WriteLine("1. На вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("2. Принимает на вход три числа и выдаёт максимальное из этих чисел.");
    Console.WriteLine("3. На вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
    Console.WriteLine("4. На вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    programm = Convert.ToInt32(Console.ReadLine());
    switch (programm)
    {
        case 1:
            // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

            Console.WriteLine("Введите первое число: ");
            int num_A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int num_B = Convert.ToInt32(Console.ReadLine());

            if (num_A > num_B)
            {
                Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
            }
            else
            {
                Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
            }
            break;

        case 2:
            // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

            Console.WriteLine("Введите 3 числа:");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            int num_2 = Convert.ToInt32(Console.ReadLine());
            int num_3 = Convert.ToInt32(Console.ReadLine());

            int max = num_1;

            if (num_2 > max)
            {
                max = num_2;
            }

            if (num_3 > max)
            {
                max = num_3;
            }

            Console.WriteLine("Наибольшее из введённых чисел -> " + max);
            break;
            
        case 3:
            break;
        case 4:
            break;
        default:
            exit = false;
            break;
    }
}

