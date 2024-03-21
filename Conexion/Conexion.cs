namespace ConexioBase;
using Microsoft.Data.SqlClient;

public class ConexionBD
{
    private string connectionString = "Server=LAPTOP-TQH24RE4;DataBase=BANKSTAR;Integrated Security=True;Encrypt=False;";
    public SqlConnection conexion;
    public ConexionBD()
    {
        conexion = new SqlConnection(connectionString);
    }

    public SqlConnection AbrirConexion()
    {
        try
        {
            conexion.Open();
            return conexion;
        }
        catch(FormatException)
        {
            Console.WriteLine("Se detectado un error en la conexion");
            throw;
        }
    }

    public void CerrarConexion()
    {
        try
        {
            conexion.Close();
        }
        catch(FormatException)
        {
            Console.WriteLine("Error en cerrar conexion con la base de datos");
            throw;
        }
    }

}