using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 chi sonni kiriting : ");
        string num1 = Console.ReadLine();
        Console.WriteLine("2 chi sonni kiriting : ");
        string num2 = Console.ReadLine();
        Console.WriteLine("Ishorani tanlang ( - , + , / , *) : ");
        string sym = Console.ReadLine();
        int sum1 = Convert.ToInt32(num1);
        int sum2 = Convert.ToInt32(num2);

if (sym == "+"){
    Console.WriteLine(sum1+sum2);
}else if (sym == "-"){
    Console.WriteLine(sum1-sum2);
}else if (sym == "*"){
    Console.WriteLine(sum1*sum2);
}else if (sym == "/"){
    Console.WriteLine(sum1/sum2);
}
    }
}
