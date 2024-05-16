namespace Sesion03.App.Repositorio;

// superclase
public class RepositorioBase<T> //: IRepositorioBase<T>
{
    public List<T> Lista { get; set; } = new();

    // Solo es accesible desde las clases derivadas
    protected int ContarElementos()
    {
        return Lista.Count;
    }

    // La palabra clave virtual permite sobreescribir la funcionalidad original
    // en las clases derivadas
    public virtual void Listar()
    {
        foreach (var elemento in Lista)
        {
            Console.WriteLine(elemento);
        }

        Console.WriteLine(ContarElementos());
    }

    //public void Eliminar(T objeto)
    //{
    //    if (Lista.Contains(objeto))
    //    {
    //        Lista.Remove(objeto);
    //    }
    //}
}

// clase derivada

// otra clase derivada