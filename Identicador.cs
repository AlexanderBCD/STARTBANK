using Consultas;
using Debito;
class Check: DatosIngresos
{
    Helperidentificador helper = new Helperidentificador();
    public override void Identificador()
    {
        while(true)
        {
            Console.Clear();
            Console.Write("Ingrese los datos de la tarjeta: ");
            Tarjeta = Console.ReadLine() ?? string.Empty;

            if(helper.IdentificadorDebito(Tarjeta))
            {
                Console.Write("Ingresar Contraseña: ");
                Contraseña = Console.ReadLine();
                if(helper.ContraseñaCorrectaDebito(Tarjeta,Contraseña))
                {
                    MenuDebito db = new MenuDebito();
                    db.Menu(Tarjeta);
                }
                
            }
            else if(helper.IdentificadorCredito(Tarjeta))
            {
                Console.Write("Ingresar Contraseña: ");
                Contraseña = Console.ReadLine();
                if(helper.ContraseñaCorrectaCredito(Tarjeta,Contraseña))
                {

                }
            }
            else
            {
                Console.WriteLine("Tarjeta no registrada");
            }
        }
    }
}