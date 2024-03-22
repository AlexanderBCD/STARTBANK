using Microsoft.Data.SqlClient;
using ConexioBase;

class HelperRetiro
{
    ConexionBD conexionBD = new ConexionBD();
    public double ConsultarSaldo(string TarjetaDebito)
    {
        string query ="SELECT saldoDisponible FROM saldo WHERE TarjetaDebito = @TarjetaDebito";

        try
        {
            using (SqlCommand command = new SqlCommand(query, conexionBD.AbrirConexion()))
            {
                command.Parameters.AddWithValue("@TarjetaDebito",TarjetaDebito);
                object result = command.ExecuteScalar();

                return result == null ? 0 : Convert.ToDouble(result);
                
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Erro en la consulta");
            throw;
        }
        finally
        {
            conexionBD.CerrarConexion();
        }
    }

    public bool ModificarRetiro(string TarjetaDebito, double saldoRetirado)
    {
        string query ="UPDATE saldo SET saldodisponible = saldodisponible - @saldoRetirado WHERE TarjetaDebito = @TarjetaDebito";

        try
        {
            using(SqlCommand command = new SqlCommand(query, conexionBD.AbrirConexion()))
            {
                command.Parameters.AddWithValue("@TarjetaDebito",TarjetaDebito);
                command.Parameters.AddWithValue("@saldoRetirado", saldoRetirado);

                int count = command.ExecuteNonQuery();
                return count > 0;

            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Error al obtener la consulta");
            throw;
        }
        finally
        {
            conexionBD.CerrarConexion();
        }
    }
}