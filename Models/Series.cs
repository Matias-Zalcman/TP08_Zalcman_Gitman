namespace TP08_Zalcman_Gitman.Models;

public class Series
{
    private int _IdSerie;
    private string _Nombre;
    private int _AñoInicio;
    private string _Sinopsis;
    private string _ImagenSerie;

    public Series(int idSerie, string nombre, int añoInicio, string sinopsis, string imagenSerie)
    {
        _IdSerie = idSerie;
        _Nombre = nombre;
        _AñoInicio = añoInicio;
        _Sinopsis = sinopsis;
        _ImagenSerie = imagenSerie;
    }

    public Series()
    {

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

    public int AñoInicio
    {
        get { return _AñoInicio; }
        set { _AñoInicio = value; }
    }

    public string Sinopsis
    {
        get { return _Sinopsis; }
        set { _Sinopsis = value; }
    }

    public string ImagenSerie
    {
        get { return _ImagenSerie; }
        set { _ImagenSerie = value; }
    }
}