using System.Transactions;
using ConexioBase;
using Microsoft.Data.SqlClient;
class HelperDepositos
{
    ConexionBD conexionBD = new ConexionBD();
    public bool ModificarSaldo(string TarjetaDebito, double Deposito)
    {
        string query ="UPDATE saldo SET saldodisponible = saldodisponible + @Deposito WHERE TarjetaDebito = @TarjetaDebito";
    
        try
        {
            using(SqlCommand command = new SqlCommand(query,conexionBD.AbrirConexion()))
            {
                command.Parameters.AddWithValue("@Deposito", Deposito);
                command.Parameters.AddWithValue("@TarjetaDebito",TarjetaDebito);

               int rowsAffected = command.ExecuteNonQuery();
               if(rowsAffected <=0)
               {
                    return false;
               }

               return true;
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Error en la consulta");
            throw;
        }
        finally
        {
            conexionBD.CerrarConexion();
        }

    }
}