namespace Debito;
using Consultas;
class Depositos
{
    HelperDepositos helper = new HelperDepositos();
    public void DepositosDebito(string TarjetaDebito)
    {
        double Deposito;
        bool valido = false;
        while(!valido)
        {
            Console.WriteLine("Bienvenido a la sección depositos");
            Console.WriteLine("Solo aceptamos billetes con las siguientes denominaciones");
            Console.WriteLine("$20, $50, $100, $200, $500, $1000");
            Console.Write("Ingrese el saldo a depositar: ");
            string? input = Console.ReadLine();

            if(double.TryParse(input, out Deposito))
            {
                if(Deposito > 0 && (Deposito % 20 == 0|| Deposito % 50 == 0 || Deposito % 100 ==0 ))
                {
                    valido = true;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un valor valido");
            }

            if(helper.ModificarSaldo(TarjetaDebito, Deposito))
            {
                Console.WriteLine("El saldo ha sido actualizado correctamente");
                Console.ReadKey();
            }


        }


    }
}