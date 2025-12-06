//Лабораторная работа №6
//Функции
//Средний уровеньВ. Вариант 30
void Con()
{
    Console.Write("Введите число в восьмеричной системе: ");
    string vosem = Console.ReadLine();
    int number = Convert.ToInt32(vosem, 8);
    Console.WriteLine($"Число в десятичной системе счисления: {number}");
}
Con();
