using System.Globalization;

class Program
{
    static void Main()
    {
        int i = 0;
        double[,] aluno = new double[10, 2];
        double maior = 0, menor = 9999999999999999999, maiorAltura = 0, menorAltura = 0;
        for(i = 0; i < aluno.GetLength(0) ; i++)
        {
            Console.WriteLine($"Informe o codigo do {i+1}º aluno");
            aluno[i,0] = double.Parse(Console.ReadLine());
        }
        for(i = 0; i < aluno.GetLength(0) ; i++)
        {
            Console.WriteLine($"Informe a altura do {i+1}º aluno");
            aluno[i,1] = double.Parse(Console.ReadLine());
        }
        for(i = 0; i < aluno.GetLength(0); i++)
        {
            if (aluno[i,1] < menor)
            {
                menor = aluno[i,0];
                menorAltura = aluno[i,1];
            }
            if (aluno[i,1] > maior)
            {
                maior = aluno[i,0];
                maiorAltura = aluno[i,1];
            }
        }
        Console.WriteLine($"O aluno com a maior altura e o aluno {maior}, ele tem {maiorAltura} de altura.\nO aluno com menor altura e o aluno {menor}, ele tem {menorAltura} de altura.");
    }
}