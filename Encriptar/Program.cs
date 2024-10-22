using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita que o usuário digite uma palavra ou frase
        Console.WriteLine("Digite uma palavra ou frase:");
        string texto = Console.ReadLine().ToUpper();

        string textoEncriptado = "";

        foreach (char letras in texto)
        {
            // Verifica se o caractere é uma letra do alfabeto
            if (char.IsLetter(letras))
            {
                // Encontrar posição da letra no alfabeto.
                int position = letras - 'A' + 1;
                // Adiciona a posição ao resultado, formatado com 2 dígitos
                textoEncriptado += position.ToString("00");
            }
            // Adiciona um . antes dos numeros da string
            if (char.IsDigit(letras))
            {
                textoEncriptado += $".{letras}";
            }
        }

        // Exibe a palavra "encriptada"
        Console.WriteLine($"Palavra encriptada: {textoEncriptado}");
    }
}
