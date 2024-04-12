// See https://aka.ms/new-console-template for more information


static int max(int[] ints)
{
    switch (ints.Length)
    {
        case 0:
            {
                Console.WriteLine("Array is empty");
                return -1;
            }
        case 1:
            {
                return ints[0];
            }
        default:
            {
                int maxValue = ints[0];
                foreach (var digit in ints)
                {
                    if (digit > maxValue)
                    {
                        maxValue = digit;
                    }
                }
                return maxValue;
            }
    }
}
