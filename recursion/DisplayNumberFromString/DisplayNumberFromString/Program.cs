string numbers = "123456789";
int i = numbers.Length-1;

displayNumber(numbers, i);

static void displayNumber(string _s,int _i)
{
    if(_i>=0)
    {
        displayNumber(_s, _i-1);
        Console.WriteLine(_s[_i]);
    }
    
}