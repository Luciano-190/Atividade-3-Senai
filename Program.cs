class Program
{
    static void Main()
    {
        int[] num = new int[10];
        int i = 0, par = 0;
        for (i = 0; i < num.Length; i++)
        {
            Console.WriteLine("Informe o primeiro número");
            num[i] = int.Parse(Console.ReadLine());
            if(num[i] % 2 == 0)
            {
                Console.WriteLine($" O número {num[i]} é par!!");
                par++;
            }
        }
        Console.WriteLine($"Você tem um total de {par} números pares!!");
    }
}