// 3. Напишите программу, которая принимает
//    на вход целое число из отрезка [10, 99] и показывает
//    наибольшую цифру числа.

int MaxNumber(int a)
{
    Console.WriteLine(a);
    
    if (a % 10 > a / 10)    
        return a % 10;
    return a / 10;
    
}


Console.WriteLine(MaxNumber(new Random().Next(10, 100)));