//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


void CountNumbers (int userNum)
{
    int sum = 0;
    int size = 6;
    for (int count = 1; count > size; count++)
    {
        if(userNum > 0)
            userNum = sum + 1;
    Console.WriteLine($"User enter {sum} times numbers more then 0");
    }
}


Console.WriteLine("Enter number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number: ");
int userNumber3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number: ");
int userNumber4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number: ");
int userNumber5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number: ");
int userNumber6 = Convert.ToInt32(Console.ReadLine());
int countNumbers = userNumber, userNumber2, userNumber3, userNumber4, userNumber5, userNumber6;
CountNumbers(countNumbers);





//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//пересечение когда значения x и y совпадают
//k1*x + b1 = k2*x + b2
//x*(k1 - k2)  = b2 - b1
//x = ()/()...
//double - тип данных

нет ни единой идеи как это решить :(