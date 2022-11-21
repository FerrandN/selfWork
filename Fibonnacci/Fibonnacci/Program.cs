int count = 15;
int[] array = new int[count];

fibonacci(count, array);

for (int i = 0; i < count; i++)
{
    Console.WriteLine(array[i]);
}


static int[] fibonacci (int c, int[] fiboSequence)
{
    if (c == 2)
    {
        fiboSequence[1] = 1;
    }
    else
    {
        fibonacci(c-1, fiboSequence);
        fiboSequence[c-1] = fiboSequence[c - 2] + fiboSequence[c-3];
    }
    return fiboSequence;
}
