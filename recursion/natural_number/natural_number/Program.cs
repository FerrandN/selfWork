int n = 10;

naturalNumber(n);

static void naturalNumber (int _n)
{
    if( _n > 0 )
    {
        naturalNumber(_n - 1);
        Console.WriteLine(_n);
    }
}