using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace TP08_Zalcman_Gitman.Models;

public static class BD
{
    private static string _connectionString = @"Server=.;DataBase=BDSeries;Trusted_Connection=True;";
    private static List<Series> _ListadoSeries = new List<Series>();

    public static List<Series> ListarSeries()
    {
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Series";
            _ListadoSeries = db.Query<Series>(sql).ToList();
        }
        return _ListadoSeries;
    }

    public static List<Temporadas> ListarTemporadas(int IdSerie)
    {
        List<Temporadas> _ListadoTemporadas = new List<Temporadas>();
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Temporadas WHERE IdSerie = @id";
            _ListadoTemporadas = db.Query<Temporadas>(sql, new {id = IdSerie}).ToList();
        }
        return _ListadoTemporadas;
    }

    public static List<Actores> ListarActores(int IdSerie)
    {
        List<Actores> _ListadoActores = new List<Actores>();
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Actores WHERE IdSerie = @id";
            _ListadoActores = db.Query<Actores>(sql, new {id = IdSerie}).ToList();
        }
        return _ListadoActores;
    }

    public static Series VerInfoSerie(int IdSerie)
    {
        Series MiSerie = null;
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Series WHERE IdSerie = @id";
            MiSerie = db.QueryFirstOrDefault<Series>(sql, new {id = IdSerie});
        }
        return MiSerie;
    }
}