namespace Sesion03.Entidades
{
    public class Producto
    {
        public Categoria Categoria { get; set; } = new();
        public string Codigo { get; set; } = default!;
        public string Nombre { get; set; } = default!;
        public float Precio { get; set; }
        public Dimensiones Dimensiones { get; set; }

        public override string ToString()
        {
            return $"{Codigo} | {Nombre}";
        }
    }

    public struct Dimensiones
    {
        public int Ancho { get; set; }
        public int Alto { get; set; }

        public int Sumar()
        {
            return Ancho + Alto;
        }

        public Dimensiones(int ancho, int alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public Dimensiones()
        {
            
        }

        public override string ToString()
        {
            return $"Dimensiones: Ancho: {Ancho} | Alto: {Alto}";
        }
    }
}
