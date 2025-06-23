using interfacePagamentos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Boleto
{
    public class PagamentoBoleto : IPagamentos
    {
        public void ProcessarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento de R${valor:F2} processado via boleto bancário.");
        }
        public override string ToString()
        {
            return "Boleto Bancário";
        }

    }
}
