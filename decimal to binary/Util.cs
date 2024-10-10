using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace decimal_to_binary
{
    public class Util
    {
        public static void printMenu()
        {
            string mensagem = @"
***********************************************
*          CONVERSOR DE NÚMEROS             *
***********************************************
* Selecione a opção de conversão:             *
*                                             *
* 1 - Converter para Binário                  *
*                                             *
* (Digite -1 para sair)                       *
***********************************************
";
            Console.WriteLine(mensagem);
        }

        public static void printMensagem(int? tipoConversao)
        {
            try
            {
                if (tipoConversao == null) throw new Exception("Erro nulo na mensagem");
                if (tipoConversao == 0) return;
                var mensagem = "Digite o número decimal para ser convertido em ";
                Dictionary<int, string> map = new Dictionary<int, string>
                {
                    { 1, "Binário" }
                };
                mensagem += map[tipoConversao.Value] + ":";
                Console.WriteLine(mensagem);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao imprimir mensagem: " + ex.ToString());
            }
        }

        public static void printMensagemContinuar()
        {
            Console.WriteLine("Deseja fazer uma outra conversão? (S/N)");
        }

        public static Retorno<int> validaContinuacao(string opcao = "")
        {
            opcao = opcao.ToUpper();
            if(opcao == "S") return new Retorno<int>
            {
                Success = true,
                Dados = { 1 }
            };
            if (opcao == "N") return new Retorno<int>
            {
                Success = true,
                Dados = { 2 }
            };

            return new Retorno<int>
            {
                Success = false
            };

        }

        public static Retorno<int> verificaNumero(string n)
        {
            int num;
            if (int.TryParse(n, out num))
            {
                return new Retorno<int>
                {
                    Success = true,
                    Dados = {num}
                }; 
            }

            return new Retorno<int>
            {
                Success = false,
            };
        }
    }
}
