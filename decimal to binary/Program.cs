using System;


namespace decimal_to_binary
{
    public class Program()
    {
        static void Main()
        {

            int option = 0;
            string? entrada = "";
            int valor;
            IConversor conversor;
            Retorno<int> retorno = new Retorno<int>()
            {
                Success = false,
            }; 


            while (option != -1)
            {
                try
                {
                    Util.printMenu();

                    entrada = Console.ReadLine();
                    if (entrada == "-1") break;

                    retorno = Util.verificaNumero(entrada);
                    option = retorno.Success ? retorno.Dados[1] : 0; 


                    Console.Clear();
                    Util.printMensagem(option);



                    switch (option)
                    {
                        case 1:

                            entrada = Console.ReadLine();
                            retorno = Util.verificaNumero(entrada);
                            valor = retorno.Success ? retorno.Dados[1] : 0;
                            conversor = ConversorFactory.ObterConversor("1");
                            Console.WriteLine(conversor.Converter(valor) + "\n");


                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }

                    

                    Util.printMensagemContinuar();

                    retorno.Success = false;
                    while (!retorno.Success)
                    {
                        retorno = Util.validaContinuacao(Console.ReadLine());
                        
                    }

                    if (retorno.Dados[0] == 2) break;
                    Console.Clear();



                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro interno: " + ex.ToString());
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }



        }

    }
}
