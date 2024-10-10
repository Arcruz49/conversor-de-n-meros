using System;

namespace decimal_to_binary
{
    public interface IConversor
    {
        protected string Resultado { get; }
        string Converter(int numeroOutraBase);
    }
}
