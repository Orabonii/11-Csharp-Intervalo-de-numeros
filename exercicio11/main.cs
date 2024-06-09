using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Solicita um número ao usuário
            Console.WriteLine("Por favor, digite um número:");
            int numero;

            // Tenta converter a entrada para um número inteiro
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                // Verifica se o número está no intervalo de 10 a 20 (inclusive)
                if (numero >= 10 && numero <= 20)
                {
                    Console.WriteLine("O número está no intervalo de 10 a 20 (inclusive).");
                }
                else
                {
                    Console.WriteLine("O número não está no intervalo de 10 a 20.");
;
            }
        }
    }
}
