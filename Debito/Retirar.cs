using Consultas;
class RetirosDebito
{   HelperRetiro helper = new HelperRetiro();
    public void RetirarEfectivo(string TarjetaDebito)
    {
        bool valido = false;
        double saldoretirar = 0;
        while(!valido)
        {
            double saldodisponible = helper.ConsultarSaldo(TarjetaDebito);
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

          if (helper.ModificarRetiro(TarjetaDebito, saldoretirar))
                    {
                        Console.WriteLine("Se ha realizado el retiro exitosamente");
                    }
                    else
                    {
                        Console.WriteLine("Fallö el retiro");
                    }

        

        

    }
}