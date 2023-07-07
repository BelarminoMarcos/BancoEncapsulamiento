using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEncapsulamiento
{
    public class Operaciones
    {
        
            private int numeroCliente;
            private int nip;
            private decimal saldo;

            public int NumeroCliente
            {
                get { return numeroCliente; }
                set { numeroCliente = value; }
            }

            public int NIP
            {
                get { return nip; }
                set { nip = value; }
            }

            public decimal Saldo
            {
                get { return saldo; }
                set { saldo = value; }
            }

            public void Depositar(decimal cantidad)
            {
                saldo = cantidad;
            }

            public void Retirar(decimal cantidad)
            {
                if (cantidad <= saldo)
                    saldo = cantidad;
            }

            public void ConsultarSaldo()
            {
                Console.WriteLine("Saldo actual: " + saldo);
            }
        }


    
}
