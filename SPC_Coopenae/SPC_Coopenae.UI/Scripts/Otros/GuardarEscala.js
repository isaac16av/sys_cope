$('#btn_agregar').click(function (e) {
    e.preventDefault();

    if ($.trim($('#txt_pctmin').val()) == "" || $.trim($('#txt_pctmax').val()) == "" || $.trim($('#txt_comision').val()) == "") return;

    var pct_min = $('#txt_pctmin').val(),
        pct_max = $('#txt_pctmax').val(),
        comision = $('#txt_comision').val(),
        detallesBody = $('#tbl_detallesEscala tbody');

    var escalaItem = '<tr><td>' + pct_min + '</td>' +
        '<td>' + pct_max + '</td>' +
        '<td>' + comision + '</td></tr>';

    detallesBody.append(escalaItem);

    limpiar();

});

function limpiar() {
    $('#txt_pctmin').val('');
    $('#txt_pctmax').val('');
    $('#txt_comision').val('');
}

$('#btn_guardar').click(function (e) {
    e.preventDefault();

    var detallesArray = [];
    detallesArray.length = 0;

    $.each($('#tbl_detallesEscala tbody tr'), function () {
        detallesArray.push({
            PCTMinimo: $(this).find('td:eq(0)').html(),
            PCTMaximo: $(this).find('td:eq(1)').html(),
            PCTComision: $(this).find('td:eq(2)').html(),
        });
    });

    var data = JSON.stringify({
        descripcion: $('#txt_descripcion').val(),
        detalles: detallesArray
    });

    $.when(GuardarEscala(data)).then(function (response) {
        console.log(response);
    }).fail(function (err) {
        console.log(err);
    });

});

function GuardarEscala(data) {
    return $.ajax({
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        type: 'POST',
        url: '/Areas/Mantenimientos/Escala/Registrar',
        data: data,
        succes: function (result) {
            alert(result);
            location.reload();
        },
        error: function () {
            alert('Ocurrió un error al guardar la escala');
        }
    });
}