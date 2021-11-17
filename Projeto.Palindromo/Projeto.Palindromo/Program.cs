using System;

namespace Projeto.Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra e lhe direi se é palindromo !");
            Console.WriteLine(VerificaPalindromo(Console.ReadLine().ToLower()));
        }

        private static string VerificaPalindromo(string palavra)
        {
            for(int pos=0; pos<palavra.Length;pos++)
            {
                if (palavra[pos] != palavra[palavra.Length - (pos + 1)])
                    return "Está palavra não é um palindromo";
            }
            return "Ok, Esta palavra é um palindromo !";
        }
    }
}
