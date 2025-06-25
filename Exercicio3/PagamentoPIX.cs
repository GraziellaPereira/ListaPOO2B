using interfacePagamentos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Boleto
{
    public class PagamentoPIX : IPagamentos
    {
        public void ProcessarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento de R${valor:F2} processado via PIX.");
        }
        public override string ToString()
        {
            return "PIX";
        }

    }
}
