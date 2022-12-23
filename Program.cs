internal class Program
{
  private static void Main(string[] args)
  {
    // declarando os numeros para acessar de forma mais facil no algoritmo valor entre 1 e 1
    string[]  numerosPorExtenso = new string[10] { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };

    // declarando o numero que sera convertido
    string NumeroPorExtenso(int numero)
    {
      // declarando o numero que sera convertido
      int[] digitos = new int[numero.ToString().Length];

      for(int i = 0; i < digitos.Length; i++)
      {
        digitos[i] = int.Parse(numero.ToString()
        [i].ToString());
      }

      //loop para percorrer o array de digitos e ir montando a string de saída
      //com o nome de cada digito , utilizando a array de nomes de números por extenso

      string saida = "";
      for(int i = 0; i < digitos.Length; i++)
      {
        saida += numerosPorExtenso[digitos[i]] + " ";
      }
      return saida;
     
    }
    // chamando a função
    Console.WriteLine(NumeroPorExtenso(1234567890));
  }
}