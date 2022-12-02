int num = 256230148;

Console.WriteLine(count(num,0));

static int count (int _num, int _zero)
{
    if (_num == 0)
        return _zero;

    return count(_num / 10, ++_zero);
}