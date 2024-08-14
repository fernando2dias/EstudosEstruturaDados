namespace EstruturaDados
{
    public class BuscaBinaria
    {
        public BuscaBinaria(string[] lista, int item)
        {
            var inicio = 0;
            var fim = lista.Length-1;
            var meio = 0;
            var tentativas = 0;
            var escolha = 0;

            while (inicio <= fim)
            {
                tentativas++;
                meio = (inicio + fim) / 2;
                escolha = meio;

                if (escolha == item)
                {
                    Console.WriteLine($"Nome: [{lista[item]}] Posição: [{item}] encontrado em {tentativas} tentativa(s)"); ;
                }
                if (escolha > item)
                {
                    fim = meio - 1;
                }
                else
                {
                    inicio = meio + 1;
                }
            }
        }
    }
}