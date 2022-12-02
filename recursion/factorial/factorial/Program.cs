int n = 10;

Console.WriteLine(factorial(n));

static int factorial(int _n)
{
    if(_n > 1)
    {
        _n = _n*factorial(_n-1);
    }

    return _n;
}