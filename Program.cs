using BancoEncapsulamiento;


class Program
{
   
        static void Main(string[] args)
        {
            List<Operaciones> cuentas = new List<Operaciones>();

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1. Registrar cuenta");
                Console.WriteLine("2. Acceder a cuenta existente");
                Console.WriteLine("3. Cerrar");
                Console.Write("Seleccione una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el número de cliente: ");
                        int numeroCliente = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el NIP: ");
                        int nip = Convert.ToInt32(Console.ReadLine());

                    Operaciones nuevaCuenta = new Operaciones();
                        nuevaCuenta.NumeroCliente = numeroCliente;
                        nuevaCuenta.NIP = nip;
                        cuentas.Add(nuevaCuenta);
                       
                        break;

                    case 2:
                        Console.Write("Numero de cliente: ");
                        int cliente = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el NIP: ");
                        int clave = Convert.ToInt32(Console.ReadLine());

                    Operaciones cuentaEncontrada = cuentas.Find(c => c.NumeroCliente == cliente && c.NIP == clave);

                        if (cuentaEncontrada != null)
                        {
                            bool acceder = true;

                            while (acceder)
                            {
                                Console.WriteLine("1. Consultar saldo");
                                Console.WriteLine("2. Depositar");
                                Console.WriteLine("3. Retirar");
                                Console.WriteLine("4. Menú principal");
                             
                                int opcionCuenta = Convert.ToInt32(Console.ReadLine());

                                switch (opcionCuenta)
                                {
                                    case 1:
                                        cuentaEncontrada.ConsultarSaldo();
                                        break;

                                    case 2:
                                        Console.Write("Ingrese la cantidad a depositar: ");
                                        decimal CantidadADeposito = Convert.ToDecimal(Console.ReadLine());
                                        cuentaEncontrada.Depositar(CantidadADeposito);
                                        Console.WriteLine("¡Depósito exitoso!");
                                        break;

                                    case 3:
                                        Console.Write("Ingrese la cantidad a retirar: ");
                                        decimal CantidadARetirar = Convert.ToDecimal(Console.ReadLine());
                                        cuentaEncontrada.Retirar(CantidadARetirar);
                                        break;

                                    case 4:
                                        acceder = false;
                                        break;
                                }

                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("La cuenta no Existe");
                        }

                        break;

                    case 3:
                        salir = true;
                      break;

                       
                }

                Console.WriteLine();
            }
        }
    
}
