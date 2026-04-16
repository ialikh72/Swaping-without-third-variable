using System;
class Quiz
{
    static void Main()
    {
        int a = 5;
        int b = 9;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a={0} and b={1}",a,b);
    }
}
