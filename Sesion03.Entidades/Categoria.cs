namespace Sesion03.Entidades
{
    public class Categoria
    {
        public string Nombre { get; set; }
        public TipoCategoria? TipoCategoria { get; set; }

        // Esto es el constructor
        public Categoria()
        {
            Nombre = default!;
        }

        public Categoria(string nombre)
        {
            // El calificador this es redundante
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
