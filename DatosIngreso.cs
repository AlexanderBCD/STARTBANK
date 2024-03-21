abstract class DatosIngresos
{
    protected string? tarjeta;
    protected string? contraseña;
    public virtual string? Tarjeta {get{return tarjeta;}set{tarjeta = value;}}
    public virtual string? Contraseña{get{return contraseña;}set{contraseña = value;}}

    public abstract void Identificador();
}