int n = 10;
int result = 0;

result = sumOfNaturalNumber(n, result);

static int sumOfNaturalNumber(int _n , int _result)
{
    if (_n>0)
    {
       _result = sumOfNaturalNumber(_n-1, _result) +_n;
    }

    return _result;
}

Console.WriteLine(result);