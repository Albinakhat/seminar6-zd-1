//Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4
int totalPositiveNumbers = 0;
bool b = true;
while (b)
{
    Console.Write("Хотите ввести число? Если ДА наберите 1: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n==1)
    {
        Console.Write("ВВедите число: ");
        int m = Convert.ToInt32(Console.ReadLine());
        if(m>0)
        {
          totalPositiveNumbers = totalPositiveNumbers +1;
        } 
    }
    else
    {
        Console.Write($"Спасибо! Чисел больше 0 введено {totalPositiveNumbers} раз");
        b=false;
    }
}