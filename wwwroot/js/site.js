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
                    $("#NombreSerie").html("Temporadas de la serie");
                    var contenido = "";
                    response.forEach(element =>
                        contenido += "<p>Temporada " + element.numeroTemporada + " - " + element.tituloTemporada + "</p>"
                    );
                    $("#ContenidoSerie").html(contenido);
                },
            error:
                function (response)
                {
                    $("#NombreSerie").html("Temporadas de la serie");
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
                    $("#NombreSerie").html("Actores de la serie");
                    var contenido = "";
                    response.forEach(element =>
                        contenido += "<p>" + element.nombre + "</p>"
                    );
                    $("#ContenidoSerie").html(contenido);
                },
            error:
                function (response)
                {
                    $("#NombreSerie").html("Actores de la serie");
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
                    $("#NombreSerie").html(response.nombre);
                    $("#ContenidoSerie").html("<h5>" + response.añoInicio + "</h5>" + "<p>" + response.sinopsis + "</p>");
                },
            error:
                function (response)
                {
                    $("#NombreSerie").html(response.nombre);
                    $("#ContenidoSerie").html("No se encontró más información de esta serie");
                }
        }
    );
}