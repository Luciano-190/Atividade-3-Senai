class Program
{
    static void Main()
    {
        int i = 0, maior = 0, menor = 999999999;
        int[] num = new int[10];
        for (i = 0; i < num.Length; i++)
        {
            Console.WriteLine($"Informe o {i + 1}º número do vetor");
            num[i] = int.Parse(Console.ReadLine());
        }
        for(i = 0; i < num.Length; i++)
        {
            if (maior < num[i])
            {
                maior = num[i];
            }
            if(menor > num[i])
            {
                menor = num[i];
            }
        }
        Console.WriteLine($"O seu maior número e {maior}, e o menor número e o {menor}");
    }
}