using System;

class Program
{
    static void Main()
    {
        double peso;
        double altura;
        double imc;
        string diagnostico;

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                                         -- Calculadora de IMC --\n");
        Console.ResetColor();

        Console.Write("Digite seu peso em kg...: ");
        peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite sua altura em m..: ");
        altura = Convert.ToDouble(Console.ReadLine());

        imc = peso / Math.Pow(altura, 2);
        // ou imc = peso / (altura * altura);

        /*
                17      18,5        25      30      35      40
        --------|---------|----------|-------|------|--------|---------
        -------- (imc < 17)
                ---------- (imc < 18.5)
                          ----------- (imc < 25)
                                     -------- (imc < 30)
                                              ------ (imc < 35)
                                                      ------- (imc < 40)
                                                                         ----------------------------- else
        */

        if (imc < 17)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            diagnostico = "Muito abaixo do peso";
        }
        else if (imc < 18.5)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            diagnostico = "Abaixo do peso";
        }
        else if (imc < 25)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            diagnostico = "Peso normal";
        }
        else if (imc < 30)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            diagnostico = "Acima do peso";
        }
        else if (imc < 35)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            diagnostico = "Obesidade I";
        }
        else if (imc < 40)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            diagnostico = "Obesidade II (severa)";
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            diagnostico = "Obesidade III (mórbida)";
        }

        Console.WriteLine($"\nSeu IMC é {imc:N2} kg/m².");
        Console.WriteLine($"Diagnóstico: {diagnostico}");

        // Resetar as cores para o padrão do console
        Console.ResetColor();
    }
}