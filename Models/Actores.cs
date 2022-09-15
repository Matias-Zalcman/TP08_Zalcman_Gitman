namespace TP08_Zalcman_Gitman.Models;

public class Actores
{
    private int _IdActor;
    private int _IdSerie;
    private string _Nombre;

    public Actores(int idActor, int idSerie, string nombre)
    {
        _IdActor = idActor;
        _IdSerie = idSerie;
        _Nombre = nombre;
    }

    public Actores()
    {

    }

    public int IdActor
    {
        get { return _IdActor; }
        set { _IdActor = value; }
    }

    public int IdSerie
    {
        get { return _IdSerie; }
        set { _IdSerie = value; }
    }

    public string Nombre
    {
        get { return _Nombre; }
        set { _Nombre = value; }
    }
}