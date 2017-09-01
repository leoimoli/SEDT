function AltaEquipo_Guardar()
{
    var name = "my name";
    var isAttending = true;
    var returnAddress = "myEmail@gmail.com";
    SendMail(name, isAttending, returnAddress);
}

function SendMail(person, isAttending, returnEmail)
{
    var pageUrl = "/AltaEquipoWF.aspx/GuardarDatos";

    var ObjetoVista = {
        NombreEquipo: document.getElementById("txt_AltaEquipoWF_NombreEquipo").value,
        Siglas: document.getElementById("txt_AltaEquipoWF_Siglas").value,
        SitioWeb: document.getElementById("txt_AltaEquipoWF_SitioWeb").value,
        TelefonoDeContacto: document.getElementById("txt_AltaEquipoWF_TelefonoDeContacto").value,
        ImagenEscudo: 'ImagenEscudo: TODO'
    };

    var datos = JSON.stringify(ObjetoVista);

    $.ajax({
        type: "POST",
        url: pageUrl,
        data: "{obj:" + datos + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Request: " + XMLHttpRequest.toString()
             + "\n\nStatus: " + textStatus
              + "\n\nError: " + errorThrown);
        },
        success: function (result) {
            // alert("We returned: " + result.d);
        }
    });

}

$('[id*=UpdatePanel_AltaEquipo_Botones]').on("click", '[id*=btnGuardar]', function () {
    alert("Holis");
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(Mensaje_Exito);
});

// The function returns the product of p1 and p2
function Mensaje_Exito() {
    var asd = new PNotify({
        title: 'Exito!',
        text: 'El equipo ha sido guardado exitosamente!!',
        type: 'success',
        styling: 'bootstrap3'
    });
}

var btnCust = '<button type="button" class="btn btn-default" title="Add picture tags" ' +
    'onclick="alert(\'Call your custom code here.\')">' +
    '<i class="glyphicon glyphicon-tag"></i>' +
    '</button>';

$("#avatar-2").fileinput({
    overwriteInitial: true,
    maxFileSize: 1500,
    showClose: false,
    showCaption: false,
    showBrowse: false,
    browseOnZoneClick: true,
    removeLabel: '',
    removeIcon: '<i class="glyphicon glyphicon-remove"></i>',
    removeTitle: 'Cancel or reset changes',
    elErrorContainer: '#kv-avatar-errors-2',
    msgErrorClass: 'alert alert-block alert-danger',
    defaultPreviewContent: '<img src="/Template/fileInput/img/Escudo.png" alt="Su Escudo" style="width:160px"><h6 class="text-muted">Seleccionar un escudo</h6>',
    layoutTemplates: { main2: '{preview} {remove} {browse}' },
    allowedFileExtensions: ["jpg", "png", "gif"]
});