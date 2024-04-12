// See https://aka.ms/new-console-template for more information


using System.Globalization;

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
                int sum = 0;
                foreach (var digit in ints)
                {
                    sum += digit;
                }
                return (sum/ints.Length);
            }
    }
}
