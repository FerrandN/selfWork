int number = 50;
bool isPrime = true;

isPrime = checkPrime(number, isPrime);

static bool checkPrime(int _number, bool _isPrime, int? toCheck = null)
{
    if (_number > 0)
    {
        toCheck = toCheck ?? _number;
        if (toCheck % _number == 0)
        {
            _isPrime = false;
        }
        checkPrime(_number - 1, _isPrime, toCheck);
    }
    return _isPrime;
}

Console.WriteLine(isPrime);