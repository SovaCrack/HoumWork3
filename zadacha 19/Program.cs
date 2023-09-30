//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
//14121 -> нет
//23432 -> да
//12821 -> да


static bool IsPalindrome(int number)
{
    if (number > 9999 && number < 100000)
    {
        int n1 = number % 10;
        int n2 = number / 10 % 10;
        //int n3 = number / 100 % 10;
        int n4 = number / 1000 % 10;
        int n5 = number / 10000 % 10;
        //Console.WriteLine($"{number},{n1}, {n2}, {n3}, {n4}, {n5}");
        if (n1 == n5 && n2 == n4) return true;
        else return false;
    }
    else
    {
        Console.WriteLine("Число не пятизначное");
        return false;
    }
}
