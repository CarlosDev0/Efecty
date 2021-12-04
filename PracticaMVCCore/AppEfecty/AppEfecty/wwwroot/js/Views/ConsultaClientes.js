$(document).ready(function () {
    var obj = {};
    $.getJSON("../Home/ConsultarClientes", obj,
        function (result) {
                if (result != null) {
                    var tabla = document.getElementById("tablaCliente");
                    $.each(result, function (x, y) {
                        $('<tr><td>' + y.idPersona + '</td><td>' + y.nombreApellidos + '</td><td>' + y.tipoDocumento + '</td><td>' + y.estadoCivil + '</td></tr>').appendTo(tabla);

                    });

                }

        }
    );
});
