
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o texto encriptado:");
        string textoEncriptado = Console.ReadLine();

        string textoOriginal = "";
        for (int i = 0; i < textoEncriptado.Length; i++)
        {
            if (char.IsDigit(textoEncriptado[i]) && (i == 0 || textoEncriptado[i - 1] != '.'))
            {
                string numero = textoEncriptado.Substring(i, 2);
                int position = int.Parse(numero);
               
                char letra = (char)('A' + position - 1);
                textoOriginal += letra;
                
                i++;
            }
            else if (textoEncriptado[i] == '.' && i + 1 < textoEncriptado.Length && char.IsDigit(textoEncriptado[i + 1]))
            {
                textoOriginal += textoEncriptado[i + 1];
                i++;
            }
        }
        Console.WriteLine($"Texto original: {textoOriginal}");
    }
}
