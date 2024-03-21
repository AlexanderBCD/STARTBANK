using Consultas;
class RetirosDebito
{   HelperRetiro helper = new HelperRetiro();
    public void RetirarEfectivo(string TarjetaDebito)
    {
        bool valido = false;
        while(!valido)
        {
            double saldodisponible = (helper.ConsultarSaldo(TarjetaDebito));
            double saldoretirar;
            Console.Clear();
            Console.WriteLine("Bienvenido al apartado de retiros");
            Console.WriteLine($"Saldo disponible: {saldodisponible}");
            Console.WriteLine("Ingrese saldo a retirar: ");
            string? input = Console.ReadLine();

            if(double.TryParse(input, out saldoretirar))
            {
                if(saldoretirar >0 && saldoretirar<=saldodisponible)
                {
                    valido = true;

                }

            }
            else
            {
                Console.WriteLine("Ingresar un valor valido");
            }

        }

        

    }
}