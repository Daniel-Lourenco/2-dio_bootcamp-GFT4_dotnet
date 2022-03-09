namespace Colecoes.Model
{
    public class OperacoesArrays
    {
        public void OrdenarArray(ref int[] array)
        {
            Array.Sort(array);
        }
        public void ImprimirArray(int[] array)
        {
            System.Console.WriteLine(String.Join(",", array) + "\n");
        }
        public void CopiarArray(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, elemento => elemento == valor);
        }

        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }

        public void RedimensionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }

        public string[] ConverterArrayParaString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }

    }
}