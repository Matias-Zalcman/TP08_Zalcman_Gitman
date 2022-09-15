// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function MostrarTemporadas(IdS)
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerTemporadasAjax',
            data: { IdSerie: IdS },
            success:
                function (response)
                {
                    $("#NombreSerie").html("Temporadas de la serie @ViewBag.listadoSeries[" + IdS + "].Nombre");
                    $("#ContenidoSerie").html("@{foreach(Temporadas temporada in " + response + "){<p>Temporada @temporada.NumeroTemporada - @temporada.TituloTemporada</p>}}");
                },
            error:
                function (response)
                {
                    $("#NombreSerie").html("Temporadas de la serie @ViewBag.listadoSeries[" + IdS + "].Nombre");
                    $("#ContenidoSerie").html("No se encontraron temporadas de esta serie");
                }
        }
    );
}

function MostrarActores(IdS)
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerActoresAjax',
            data: { IdSerie: IdS },
            success:
                function (response)
                {
                    $("#NombreSerie").html("Actores de la serie @ViewBag.listadoSeries[" + IdS + "].Nombre");
                    $("#ContenidoSerie").html("@{foreach(Actores actor in " + response + "){<p>@actor.Nombre</p>}}");
                },
            error:
                function (response)
                {
                    $("#NombreSerie").html("Actores de la serie @ViewBag.listadoSeries[" + IdS + "].Nombre");
                    $("#ContenidoSerie").html("No se encontraron actores de esta serie");
                }
        }
    );
}

function MostrarInfo(IdS)
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerInfoSerieAjax',
            data: { IdSerie: IdS },
            success:
                function (response)
                {
                    $("#NombreSerie").html("Actores de la serie @ViewBag.listadoSeries[" + IdS + "].Nombre");
                    $("#ContenidoSerie").html("@{foreach(Actores actor in " + response + "){<p>@actor.Nombre</p>}}");
                },
            error:
                function (response)
                {
                    $("#NombreSerie").html("Actores de la serie @ViewBag.listadoSeries[" + IdS + "].Nombre");
                    $("#ContenidoSerie").html("No se encontraron actores de esta serie");
                }
        }
    );
}