namespace Debito;

class MenuDebito
{
    public void Menu(string TarjetaDebito)
    {
        while(true)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al apartado Debito");
                Console.WriteLine("1. Depositar efectivo");
                Console.WriteLine("2. Retiro de efectivo");
                Console.WriteLine("3. Consultar Saldo");
                Console.WriteLine("4. Cambio de contraseña");
                Console.WriteLine("5. Mostrar Transacciones");
                Console.WriteLine("6. Regresar al menu principal");
                Console.Write("Ingrese la opción elegida: ");
                string? opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1":
                    
                        Depositos depo = new Depositos();
                        depo.DepositosDebito(TarjetaDebito);

                    break;

                    case "2":

                        RetirosDebito ret = new RetirosDebito();
                        ret.RetirarEfectivo(TarjetaDebito);
                        
                    break;

                    case "3":

                    break;

                    case "4":

                    break;

                    case "5":

                    break;

                    case "6":

                    return;
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Datos invalidos");
            }
        }
    }

    private Depositos Depositos()
    {
        throw new NotImplementedException();
    }
}