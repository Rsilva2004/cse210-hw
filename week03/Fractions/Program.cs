Fraction fraction1 = new Fraction();
Fraction fraction2 = new Fraction(6);
Fraction fraction3 = new Fraction(6, 7);

Console.WriteLine("Fractions created:");
Console.WriteLine(fraction1.GetFractionString());
Console.WriteLine(fraction2.GetFractionString());
Console.WriteLine(fraction3.GetFractionString());

Console.WriteLine();

// Testing getters e setters
fraction3.SetTop(3);
fraction3.SetBottom(4);

Console.WriteLine("Top: " + fraction3.GetTop());
Console.WriteLine("Bottom: " + fraction3.GetBottom());
Console.WriteLine("Fraction: " + fraction3.GetFractionString());
Console.WriteLine("Decimal: " + fraction3.GetDecimalValue());

Console.WriteLine();

Fraction fraction4 = new Fraction(1, 3);

Console.WriteLine("1/1 in decimal: " + fraction1.GetDecimalValue());
Console.WriteLine("6/1 in decimal: " + fraction2.GetDecimalValue());
Console.WriteLine("3/4 in decimal: " + fraction3.GetDecimalValue());
Console.WriteLine("1/3 in decimal: " + fraction4.GetDecimalValue());