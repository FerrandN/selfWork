
for (int i = 0; i < 10; i++ )
{
    Console.WriteLine(fibonacci(i));
}

static int fibonacci (int _n)
{
    if (_n == 0)
    {
        return 0;
    } 
    else if (_n == 1)
    {
        return 1;
    }
    else
    {
        int result =  fibonacci(_n-1) + fibonacci(_n-2);
        return result;
    }

}



