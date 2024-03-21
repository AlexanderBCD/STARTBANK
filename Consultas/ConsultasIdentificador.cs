namespace Consultas;
using Microsoft.Data.SqlClient;
using ConexioBase;
using Microsoft.VisualBasic;
using System.Diagnostics;

class Helperidentificador
{
    ConexionBD conexionBD = new ConexionBD();
    public bool IdentificadorDebito(string TarjetaDebito)
    {
        string query = "SELECT COUNT(*) FROM usuario WHERE TarjetaDebito = @TarjetaDebito";
        try
        {
            using (SqlCommand command = new SqlCommand(query, conexionBD.AbrirConexion()))
            {
                command.Parameters.AddWithValue("@TarjetaDebito", TarjetaDebito);
                int count = (int)command.ExecuteScalar();
                return count >0;
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Error en realizar la consulta");
            throw;
        }
        finally
        {
            conexionBD.CerrarConexion();
        }
    }

    public bool IdentificadorCredito(string TarjetaCredito)
    {
        string query = "SELECT COUNT(*) FROM usuario WHERE TarjetaCredito = @TarjetaCredito";

        try
        {
            using (SqlCommand command = new SqlCommand(query, conexionBD.AbrirConexion()))
            {
                command.Parameters.AddWithValue("@TarjetaCredito",TarjetaCredito);
                int count = (int)command.ExecuteScalar();
                return count >0;
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Error al analizar la consulta");
            throw;
        }
        finally
        {
            conexionBD.CerrarConexion();
        }
    }

    public bool ContraseñaCorrectaDebito(string TarjetaDebito, string? Contraseña)
    {
        string query = "SELECT COUNT(*) FROM usuario WHERE TarjetaDebito = @TarjetaDebito AND Contraseña = @Contraseña";

        try
        {
            using (SqlCommand command = new SqlCommand(query, conexionBD.AbrirConexion()))
            {
                command.Parameters.AddWithValue("@TarjetaDebito",TarjetaDebito);
                command.Parameters.AddWithValue("@Contraseña",Contraseña);

                int count = (int)command.ExecuteScalar();
                return count >0;
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Hubo un error al realizar la consulta");
            throw;
        }
        finally
        {
            conexionBD.CerrarConexion();
        }
    }

    public bool ContraseñaCorrectaCredito(string TarjetaCredito, string? Contraseña)
    {
        string query = "SELECT COUNT(*) FROM usuario WHERE TarjetaCredito = @TarjetaCredito AND Contraseña = @Contraseña";

        try
        {
            using (SqlCommand command = new SqlCommand(query, conexionBD.AbrirConexion()))
            {
                command.Parameters.AddWithValue("@TarjetaCredito",TarjetaCredito);
                command.Parameters.AddWithValue("@Contraseña",Contraseña);

                int count = (int)command.ExecuteScalar();
                return count >0;
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Hubo un error al realizar la consulta");
            throw;
        }
        finally
        {
            conexionBD.CerrarConexion();
        }
    }
}