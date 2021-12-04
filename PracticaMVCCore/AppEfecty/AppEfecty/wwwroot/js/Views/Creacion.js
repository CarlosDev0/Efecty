$(document).ready(function () {
    
    $('#tipoDocumento').append($('<option id="Cédula"> Cédula</option>'));
    $('#tipoDocumento').append($('<option id="Tarjeta Identidad"> Tarjeta Identidad</option>'));

    

    $('#guardar').on('click', function () {
        if (validarFecha() && validarNumero()) {
            var obj = {};
            obj.nombreApellidos = $('#nombreApellido').val();
            obj.estadoCivil = $('input[name=estadoCivil]:checked').val(); //$('#estadoCivil').val();
            obj.tipoDocumento = $('#tipoDocumento').val();;
            obj.fechaNacimiento = $('#fechaNacimiento').val();  
            obj.valorGanar = $('#valorGanar').val();

            $.getJSON("../Home/GuardarCliente", obj, function (data) {

                alert("Cliente Guardado Exitosamente");
                $('#nombreApellido').val('');
                $('#valorGanar').val('');
            });
            
        }
    });


});

function OnlyNumbers(e) {
    var key = window.event ? e.which : e.keyCode;
    if (key < 48 || key > 57)
        e.preventDefault();
}

function validarFecha() {
    var respuesta = true;
    var Fecha = $("#fechaNacimiento").val();
    var Ano = parseInt(Fecha.substring(6, 10), 10);
    var Mes = parseInt(Fecha.substring(3, 5), 10);
    var Dia = parseInt(Fecha.substring(0, 2), 10);
    if (Dia > 31 || Dia < 1 || Dia == undefined || Dia == null || isNaN(Dia)) {
        respuesta = false;
    }
    if (Mes > 12 || Mes < 1 || Mes == undefined || Mes == null || isNaN(Mes)) {
        respuesta = false;
    }
    if (Ano > 2015 || Ano < 1900 || Ano == undefined || Ano == null || isNaN(Ano)) {
        respuesta = false;
    }
    if (!respuesta) {
        alert("Por favor verifique el formato de fecha ingresado. Debe ser: dd/mm/yyyy");
    }
    return respuesta;
    var FechaIni = new Date(Ano, Mes, Dia);
}

function validarNumero() {
    var vr = $("#valorGanar").val();
    if (vr == 0 || vr == null || vr == undefined || isNaN(vr)) {
        alert("Por favor verifique el valor del Campo: Valor a Ganar.");
        return false;
    } else {
        return true;
    }
}