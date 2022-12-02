int range = 20;
sortEven(range);


static void sortEven (int _range)
{
    if (_range > 0)
    {
        if(_range%2 == 0)
        {
            Console.WriteLine(_range);
        }
        sortEven(_range - 1);
    }
}