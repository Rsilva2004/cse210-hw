using System;

class Program
{
    static void Main(string[] args)
    {
        Assingment a1 = new Assingment("Samuel Jackson", "Multiplication");
        Console.WriteLine(a1.GetSummmary());

        MathAssingment a2 = new MathAssingment("Rafael Aranha", "Decimals", "1.9", "10.4");
        Console.WriteLine(a2.GetSummmary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssingment a3 = new WritingAssingment("Sadie Sink", "Brazilian History", "Participation in World War II");

        Console.WriteLine(a3.GetSummmary());
        Console.WriteLine(a3.GetWritingInformation());
    }

}