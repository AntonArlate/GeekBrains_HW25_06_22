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
            break;
        case 2:
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
