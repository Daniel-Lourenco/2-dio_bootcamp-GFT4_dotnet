using System.Collections.Generic;
using Colecoes.Model;

List<string> estados = new List<string>();
estados.Add("SP");
estados.Add("RJ");
estados.Add("BA");

System.Console.WriteLine($"Essa lista tem {estados.Count} elementos");

for (int i = 0; i < estados.Count; i++)
{
    
    
}

















// int[] array = new int[5] {6, 3, 8, 4, 9};
// int[] arrayCopia = new int[10];

// var op = new OperacoesArrays();

// string[] arrayString = op.ConverterArrayParaString(array);


// System.Console.WriteLine(arrayString);
// System.Console.WriteLine($"Capacidade atual do array: {array.Length}");
// op.RedimensionarArray(ref array, array.Length * 2);
// System.Console.WriteLine($"A nova capacidade do array é: {array.Length}");

// int valorProcurado = 4;
// int valorAchado = op.ObterValor(array, valorProcurado);

// int indice = op.ObterIndice(array, valorProcurado);

// if (indice > -1)
// {
//     System.Console.WriteLine($"O indice do valor {valorProcurado} é {indice}");
// }
// else
// {
//     System.Console.WriteLine("Valor não existente no array");
// }







// bool maiorQue = op.TodosMaiorQue(array, valorProcurado);
// bool existe = op.Existe(array, valorProcurado);

// if (maiorQue)
// {
//     System.Console.WriteLine($"São todos maiores que {valorProcurado}");
// }
// else
// {
//     System.Console.WriteLine($"Nem todos são maiores que {valorProcurado}");
// }

// if (existe)
// {
//     System.Console.WriteLine($"Encontrei o valor {valorProcurado}");
// }
// else
// {
//     System.Console.WriteLine($"Não foi encontrado o valor {valorProcurado}");
// }

// System.Console.WriteLine("O array original é: ");
// op.ImprimirArray(array);

// System.Console.WriteLine("O array ordenado é: ");
// op.OrdenarArray(ref array);
// op.ImprimirArray(array);

// System.Console.WriteLine("O array copiado e ordenado é: ");
// op.CopiarArray(ref array, ref arrayCopia);
// op.OrdenarArray(ref arrayCopia);
// op.ImprimirArray(arrayCopia);
