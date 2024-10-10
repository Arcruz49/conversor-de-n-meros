using System;


namespace decimal_to_binary
{
    public class Retorno<T>
    {
        public bool Success { get; set; }
        public int? CodigoResposta { get; set; }
        public string? Message { get; set; }
        public List<T> Dados { get; set; } = new List<T>();

    }
}
