using ImaginaryNumber;

Number number = new Number(1,-2);
Console.WriteLine("Le nombre est: "+ number.ToString());

number.SetImaginary(6);
Console.WriteLine("Le nombre est: " + number.ToString());

Console.Write("L'ordre de grandeur: ");
Console.WriteLine(number.GetMagnitude());

Number anotherNumber = new Number(-5,8);
number.Sum(anotherNumber);
Console.Write("après l'addition: ");
Console.WriteLine(number.ToString());