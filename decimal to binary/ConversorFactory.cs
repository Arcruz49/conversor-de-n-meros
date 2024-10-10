namespace decimal_to_binary
{
    public static class ConversorFactory
    {
        public static IConversor ObterConversor(string opcao)
        {
            return opcao switch
            {
                "1" => new ConversorBinario(),
                _ => null,
            };
        }
    }
}
