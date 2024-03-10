// See https://aka.ms/new-console-template for more information
Console.Write("Enter numbers of array : ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(99);
}

int max = 0, min = 100;

for (int i = 0;i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine("Max = "+max+"    "+"min = "+min);
