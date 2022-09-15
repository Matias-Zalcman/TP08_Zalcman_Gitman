namespace TP08_Zalcman_Gitman.Models;

public class Temporadas
{
    private int _IdTemporada;
    private int _IdSerie;
    private int _NumeroTemporada;
    private string _TituloTemporada;

    public Temporadas(int idTemporada, int idSerie, int numeroTemporada, string tituloTemporada)
    {
        _IdTemporada = idTemporada;
        _IdSerie = idSerie;
        _NumeroTemporada = numeroTemporada;
        _TituloTemporada = tituloTemporada;
    }

    public Temporadas()
    {

    }

    public int IdTemporada
    {
        get { return _IdTemporada; }
        set { _IdTemporada = value; }
    }

    public int IdSerie
    {
        get { return _IdSerie; }
        set { _IdSerie = value; }
    }

    public int NumeroTemporada
    {
        get { return _NumeroTemporada; }
        set { _NumeroTemporada = value; }
    }

    public string TituloTemporada
    {
        get { return _TituloTemporada; }
        set { _TituloTemporada = value; }
    }
}