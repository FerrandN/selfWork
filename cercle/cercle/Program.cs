using cercle;

string userInput;
double rayon = 0;
bool validAnswer = false;

Console.WriteLine("what's the R of your circle");
userInput = Console.ReadLine();
while (!validAnswer)
{
    try
    {
        rayon = double.Parse(userInput);
        validAnswer = true;
    }
    catch
    {
        Console.WriteLine("wrong input");
    }
    CircleDatas C = new CircleDatas(rayon);


    Console.WriteLine(C.GetArea() + " " +  C.GetPerimeter());
}

