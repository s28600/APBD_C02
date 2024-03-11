// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        int[] tab = new int[10];
        Random rand = new Random();
        
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = rand.Next()%100;
        }
        
        foreach (var elem in tab)
        {
            Console.WriteLine(elem);
        }
        Console.WriteLine("Average: " + Average(tab));
    }

    public static int Average(int[] tab)
    {
        var sum = 0;
        foreach (var num in tab)
        {
            sum += num;
        }
        return sum / tab.Length;
    }
}